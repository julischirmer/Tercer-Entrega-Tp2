using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }


        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios formUsuarios = new Usuarios();
            formUsuarios.Show();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidades formEspecialidades = new Especialidades();
            formEspecialidades.Show();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materias formMaterias = new Materias();
            formMaterias.Show();
        }

        private void Inicio_Shown(object sender, EventArgs e)
        {
            Login ingresoForm = new Login();
            ingresoForm.ShowDialog();
            if(ingresoForm.DialogResult != DialogResult.OK)
            {
                this.Dispose();
            } else
            {
                this.Opacity = 100;
                ConfigForm(ingresoForm.tipoPersona);
            }
        }

        private void ConfigForm(Persona.TiposPersonas tipo)
        {
            switch(tipo) {

                case Persona.TiposPersonas.Docente:
                    MessageBox.Show("Usted es docente");
                    btnEspecialidades.Enabled = false;
                    break;
                case Persona.TiposPersonas.Administrador:
                    MessageBox.Show("Usted es administrador");
                    break;
                case Persona.TiposPersonas.Alumno:
                    MessageBox.Show("Usted es Alumno");
                    break;
                default:
                    break;


            }
        }

        private void btn_Planes_Click(object sender, EventArgs e)
        {
            Planes formPlanes = new Planes();
            formPlanes.Show();
        }

        private void btn_Personas_Click(object sender, EventArgs e)
        {
            Personas formPersonas = new Personas();
            formPersonas.Show();
        }

        private void btn_RepUsuarios_Click(object sender, EventArgs e)
        {
            Reporte_Usuario RepUser = new Reporte_Usuario();
            RepUser.Show();
        }

        private void btn_RepCurso_Click(object sender, EventArgs e)
        {
            Reporte_Cursos RepCurso = new Reporte_Cursos();
            RepCurso.Show();
        }

        private void btn_RepPlanes_Click(object sender, EventArgs e)
        {
            Reporte_Planes RepPlanes = new Reporte_Planes();
            RepPlanes.Show();
        }
    }
    
}
