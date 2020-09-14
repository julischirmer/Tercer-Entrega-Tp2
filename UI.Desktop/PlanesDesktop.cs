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
    public partial class PlanesDesktop : ApplicationForm
    {
        #region Constructores
        public PlanesDesktop()
        {
            InitializeComponent();
        }

        public PlanesDesktop(ModoForm modo) : this()
        {
            _Modo = modo;
            this.MapearEspecialidades();
           
        }

        public PlanesDesktop(int ID, ModoForm modo) : this()
        {
            _Modo = modo;
            PlanLogic plan = new PlanLogic();
            PlanActual = plan.GetOne(ID);
            this.MapearDeDatos();
            this.MapearEspecialidades();
            
        }

        #endregion

        #region Propiedades

        public Plan _PlanActual;
        public Plan PlanActual
        {
            get { return _PlanActual; }
            set { _PlanActual = value; }
        }

        #endregion

        #region Metodos

        

        public override void MapearADatos()
        {

            if (_Modo == ModoForm.Alta)
            {
                Plan PlanNuevo = new Plan();


                PlanNuevo.Descripcion = this.txt_descPlan.Text;
                PlanNuevo.IDEspecialidad = Convert.ToInt32(this.cbEspecialidades.SelectedValue.ToString()); 
                PlanLogic nuevoplan = new PlanLogic();
                PlanActual = PlanNuevo;
                PlanNuevo.State = BusinessEntity.States.New;
                nuevoplan.Save(PlanActual);

            }

            else if (_Modo == ModoForm.Modificacion)
            {

                PlanActual.Descripcion = this.txt_descPlan.Text;
                PlanActual.IDEspecialidad = Convert.ToInt32(this.cbEspecialidades.SelectedValue.ToString());

                PlanLogic nuevoplan = new PlanLogic();
                PlanActual.State = BusinessEntity.States.Modified;
                nuevoplan.Save(PlanActual);


            }
            else if (_Modo == ModoForm.Baja)
            {

                PlanLogic nuevoplan = new PlanLogic();
                PlanActual.State = BusinessEntity.States.Deleted;
                nuevoplan.Save(PlanActual);
            }
            else
                btn_aceptar.Text = "Aceptar";
        }

        public void MapearEspecialidades()
        {
            PlanLogic p1 = new PlanLogic();
            cbEspecialidades.DataSource = p1.GetEspecialidad();
            cbEspecialidades.ValueMember = "ID";
            cbEspecialidades.DisplayMember = "Descripcion";
            if (_Modo != ModoForm.Alta)
            {
                cbEspecialidades.SelectedValue = PlanActual.IDEspecialidad;
            }
        }

        
        public override void MapearDeDatos()
        {
            
            txt_idPlan.Text = this.PlanActual.ID.ToString();
            txt_descPlan.Text = this.PlanActual.Descripcion;

            if (_Modo == ModoForm.Alta)
            {
                btn_aceptar.Text = "Guardar";
            }
            else if (_Modo == ModoForm.Modificacion)
            {
                btn_aceptar.Text = "Guardar";
            }
            else if (_Modo == ModoForm.Baja)
            {
                btn_aceptar.Text = "Eliminar";
                txt_idPlan.Enabled = false;
                txt_descPlan.Enabled = false;
                cbEspecialidades.Enabled = false;

            }
            else
            {
                btn_aceptar.Text = "Aceptar";
            }
        }
        public bool Validar(string desc)
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


        public override void GuardarCambios()
        {
            this.MapearADatos();
        }

        #endregion

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string descripcion = this.txt_descPlan.Text;

            if (Validar(descripcion) == true)
            {
                this.GuardarCambios();
            }

            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
