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
    public partial class EspecialidadesDesktop : ApplicationForm
    {
        #region Constructores
        public EspecialidadesDesktop()
        {
            InitializeComponent();
        }

        public EspecialidadesDesktop(ModoForm modo) : this()
        {
            _Modo = modo;
        }

        public EspecialidadesDesktop(int ID, ModoForm modo) : this()
        {
            _Modo = modo;
            EspecialidadLogic especialidad = new EspecialidadLogic();
            EspecialidadActual = especialidad.GetOne(ID);
            this.MapearDeDatos();
        }

#endregion

        #region Propiedades
        public Especialidad _EspecialidadActual;
        public Especialidad EspecialidadActual
        {
            get { return _EspecialidadActual; }
            set { _EspecialidadActual = value; }
        }
        #endregion;

        #region Metodos


        public override void MapearADatos()
        {




            if (_Modo == ModoForm.Alta)
            {
                Especialidad EspecialidadNueva = new Especialidad();


                EspecialidadNueva.Descripcion = this.txtDescripcion.Text;
                EspecialidadLogic nuevaespecialidad = new EspecialidadLogic();
                EspecialidadActual = EspecialidadNueva;
                EspecialidadNueva.State = BusinessEntity.States.New;
                nuevaespecialidad.Save(EspecialidadActual);



            }

            else if (_Modo == ModoForm.Modificacion)
            {

                EspecialidadActual.Descripcion = this.txtDescripcion.Text;


                EspecialidadLogic nuevaespecialidad = new EspecialidadLogic();
                EspecialidadActual.State = BusinessEntity.States.Modified;
                nuevaespecialidad.Save(EspecialidadActual);


            }
            else if (_Modo == ModoForm.Baja)
            {

                EspecialidadLogic nuevaespecialidad = new EspecialidadLogic();
                EspecialidadActual.State = BusinessEntity.States.Deleted;
                nuevaespecialidad.Save(EspecialidadActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }


        public  bool Validar(string desc)
        {
            if (desc.Length > 0 & desc.Length < 50)
            {
                return true;
            }
            else
            {
                this.Notificar("Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public override void MapearDeDatos()
        {
            this.txtId.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;

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
            }
            else
            {
                btnAceptar.Text = "Aceptar";
            }
        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
        }

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string Descripcion = this.txtDescripcion.Text;

            if (Validar(Descripcion) == true)
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
