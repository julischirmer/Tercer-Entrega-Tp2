using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class Personas : Form

    {
        public Personas()
        {
            InitializeComponent();
            dgvPersonas.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            PersonasLogic ul = new PersonasLogic();
            this.dgvPersonas.DataSource = ul.GetAll();


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsb_Nuevo_Click(object sender, EventArgs e)
        {
            PersonasDesktop formPersonas = new PersonasDesktop(ApplicationForm.ModoForm.Alta);
            formPersonas.ShowDialog();
            this.Listar();
        }

        private void tsb_Editar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonasDesktop formPersonas = new PersonasDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formPersonas.ShowDialog();
            this.Listar();
        }

        private void tsb_Eliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonasDesktop formPersonas = new PersonasDesktop(ID, ApplicationForm.ModoForm.Baja);
            formPersonas.ShowDialog();
            this.Listar();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
