using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            dgv_planes.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            PlanLogic pl = new PlanLogic();
            this.dgv_planes.DataSource = pl.GetAll();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsb_Nuevo_Click(object sender, EventArgs e)
        {
            PlanesDesktop formPlanes = new PlanesDesktop(ApplicationForm.ModoForm.Alta);
            formPlanes.ShowDialog();
            this.Listar();
        }

        private void tsb_Editar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Plan)this.dgv_planes.SelectedRows[0].DataBoundItem).ID;
            PlanesDesktop formPlanes = new PlanesDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formPlanes.ShowDialog();
            this.Listar();
        }

        private void tsb_Eliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Plan)this.dgv_planes.SelectedRows[0].DataBoundItem).ID;
            PlanesDesktop formPlanes = new PlanesDesktop(ID, ApplicationForm.ModoForm.Baja);
            formPlanes.ShowDialog();
            this.Listar();
        }
    }
}
