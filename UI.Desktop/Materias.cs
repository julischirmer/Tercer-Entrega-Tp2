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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            dgvMaterias.AutoGenerateColumns = false;
            //this.Columna_Planes();
        }

        public void Listar()
        {
            MateriaLogic ul = new MateriaLogic();
            this.dgvMaterias.DataSource = ul.GetAll();
            

        }

        /*public void Columna_Planes()
        {
            MateriaLogic ul = new MateriaLogic();
            DataGridViewComboBoxColumn colPlanes = new DataGridViewComboBoxColumn();

            colPlanes.Name = "colPlanes";
            colPlanes.HeaderText = "Plan";
            colPlanes.DisplayIndex = 7;
            colPlanes.DataSource = ul.GetPlanes();
            colPlanes.ValueMember = "ID";
            colPlanes.DisplayMember = "Descripcion";
            dgvMaterias.Columns.Add(colPlanes);
        }*/

        private void Materias_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MateriasDesktop formMaterias = new MateriasDesktop(ApplicationForm.ModoForm.Alta);
            formMaterias.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriasDesktop formMaterias = new MateriasDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formMaterias.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriasDesktop formMaterias = new MateriasDesktop(ID, ApplicationForm.ModoForm.Baja);
            formMaterias.ShowDialog();
            this.Listar();

        }
    }
}
