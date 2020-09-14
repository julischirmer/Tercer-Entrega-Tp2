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
    public partial class MateriasDesktop : ApplicationForm
    {
        public MateriasDesktop()
        {
            InitializeComponent();
            
        }

        public MateriasDesktop(ModoForm modo) : this()
        {
            _Modo = modo;
            this.MapearPlanes();
        }

        public MateriasDesktop(int ID, ModoForm modo) : this()
        {
            _Modo = modo;
            MateriaLogic materia = new MateriaLogic();
            materiaActual = materia.GetOne(ID);
            this.MapearDeDatos();
            this.MapearPlanes();
        }

        private Materia _materiaActual;
        public Materia materiaActual
        {
            get { return _materiaActual; }
            set { _materiaActual = value; }
        }
        
        public override void MapearADatos()
        {
            if (_Modo == ModoForm.Alta)
            {
                Materia MateriaNueva = new Materia();


                MateriaNueva.Descripcion = this.txtDescripcion.Text;
                MateriaNueva.HSSemanales = int.Parse(this.txtHSSemanales.Text);
                MateriaNueva.HSTotales = int.Parse(this.txtHSTotales.Text);
                MateriaNueva.IDPlan = Convert.ToInt32(txtIDPlan.SelectedValue.ToString());
                materiaActual = MateriaNueva;
                MateriaLogic matlogic = new MateriaLogic();
                MateriaNueva.State = BusinessEntity.States.New;
                matlogic.Save(MateriaNueva);



            }

            else if (_Modo == ModoForm.Modificacion)
            {

                materiaActual.Descripcion = this.txtDescripcion.Text;
                materiaActual.HSSemanales = int.Parse(this.txtHSSemanales.Text);
                materiaActual.HSTotales = int.Parse(this.txtHSTotales.Text);
                materiaActual.IDPlan = Convert.ToInt32(txtIDPlan.SelectedValue.ToString());
                MateriaLogic matlogic = new MateriaLogic();
                materiaActual.State = BusinessEntity.States.Modified;
                matlogic.Save(materiaActual);


            }
            else if (_Modo == ModoForm.Baja)
            {

                MateriaLogic matlogic = new MateriaLogic();
                materiaActual.State = BusinessEntity.States.Deleted;
                matlogic.Save(materiaActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }

        public void MapearPlanes()
        {
            MateriaLogic ml = new MateriaLogic();
            txtIDPlan.DataSource = ml.GetPlanes();
            txtIDPlan.ValueMember = "ID";
            txtIDPlan.DisplayMember = "Descripcion";
            if(_Modo != ModoForm.Alta)
            {
                txtIDPlan.SelectedValue = materiaActual.IDPlan;

            };
        }
        public override void MapearDeDatos()
        {
            txtID.Text = materiaActual.ID.ToString();
            txtDescripcion.Text = materiaActual.Descripcion;
            txtHSSemanales.Text = materiaActual.HSSemanales.ToString();
            txtHSTotales.Text = materiaActual.HSTotales.ToString();

            if (_Modo == ModoForm.Alta)
            {
                btnAceptar.Text = "Guardar";
            }
            else if (_Modo == ModoForm.Modificacion)
            {

                btnAceptar.Text = "Guardar";
            }
            else if (_Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
                txtID.Enabled = false;
                txtDescripcion.Enabled = false;
                txtHSSemanales.Enabled = false;
                txtHSTotales.Enabled = false;
                txtIDPlan.Enabled = false;
            }
            else
            {
                
                btnAceptar.Text = "Aceptar";
            }
        }
        public bool Validar(string descripcion, int sem, int tot)
        {
            if (descripcion.Length != 0 & sem>= 0 & tot>= 0)
            {
                return true;
            }
            else
            {
                this.Notificar("Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {

            string descripcion = this.txtDescripcion.Text;
            int hssemanales = int.Parse(this.txtHSSemanales.Text);
            int hstotales = int.Parse(this.txtHSTotales.Text);
   


            if (Validar( descripcion, hssemanales, hstotales) == true)
            {
                this.GuardarCambios();
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
