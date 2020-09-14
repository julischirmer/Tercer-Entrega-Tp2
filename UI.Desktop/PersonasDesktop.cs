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
    public partial class PersonasDesktop : ApplicationForm
    {
        public PersonasDesktop()
        {
            InitializeComponent();
        }

        private void PersonasDesktop_Load(object sender, EventArgs e)
        {

        }

        public PersonasDesktop(ModoForm modo) : this()
        {
            _Modo = modo;
            this.MapearPlanes();
            this.MapearTipoPersonas();
        }

        public PersonasDesktop(int ID, ModoForm modo) : this()
        {
            _Modo = modo;
            PersonasLogic persona = new PersonasLogic();
            personaActual = persona.GetOne(ID);
            this.MapearDeDatos();
            this.MapearPlanes();
            this.MapearTipoPersonas();
        }

        private Persona _personaActual;
        public Persona personaActual
        {
            get { return _personaActual; }
            set { _personaActual = value; }
        }

        public void MapearPlanes()
        {
            PersonasLogic pe = new PersonasLogic();
            cb_IdPlan.DataSource = pe.GetPlanes();
            cb_IdPlan.ValueMember = "ID";
            cb_IdPlan.DisplayMember = "Descripcion";
            if (_Modo != ModoForm.Alta)
            {
                cb_IdPlan.SelectedValue = personaActual.IDPlan;

            };
        }

        public void MapearTipoPersonas()
        {
            cb_TipoPersona.DataSource = Enum.GetValues(typeof(Persona.TiposPersonas));

            if (_Modo != ModoForm.Alta)
            {
                cb_TipoPersona.SelectedItem = personaActual.TipoPersona;

            };
            
            //cb_TipoPersona.SelectedItem = Persona.TiposPersonas.Docente;
            //cb_TipoPersona.SelectedItem = Persona.TiposPersonas.Administrador;
            //cb_TipoPersona.SelectedItem = Persona.TiposPersonas.Alumno;
        }


        public override void MapearADatos()
        {
            if (_Modo == ModoForm.Alta)
            {
                Persona PersonaNueva = new Persona();


                PersonaNueva.Nombre = this.txt_Nombre.Text;
                PersonaNueva.Apellido = this.txt_Apellido.Text;
                PersonaNueva.Legajo = int.Parse(this.txt_legajo.Text);
                PersonaNueva.Direccion = this.txt_direccion.Text;
                PersonaNueva.IDPlan = Convert.ToInt32(cb_IdPlan.SelectedValue.ToString());
                PersonaNueva.TipoPersona = (Persona.TiposPersonas)Enum.Parse(typeof(Persona.TiposPersonas), cb_IdPlan.SelectedValue.ToString());
                PersonaNueva.Email = this.txt_email.Text;
                PersonaNueva.FechaNacimiento = this.dtp_fechaNac.Value;
                PersonaNueva.Telefono = this.txt_telefono.Text;
                personaActual = PersonaNueva;
                PersonasLogic perLogic = new PersonasLogic();
                PersonaNueva.State = BusinessEntity.States.New;
                perLogic.Save(PersonaNueva);



            }

            else if (_Modo == ModoForm.Modificacion)
            {

                personaActual.Nombre = this.txt_Nombre.Text;
                personaActual.Apellido = this.txt_Apellido.Text;
                personaActual.Direccion = this.txt_direccion.Text;
                personaActual.Legajo = int.Parse(txt_legajo.Text);
                personaActual.Email = this.txt_Apellido.Text;
                personaActual.IDPlan = Convert.ToInt32(cb_IdPlan.SelectedValue.ToString());
                personaActual.TipoPersona = (Persona.TiposPersonas)Enum.Parse(typeof(Persona.TiposPersonas), cb_TipoPersona.SelectedValue.ToString());
                personaActual.FechaNacimiento = this.dtp_fechaNac.Value;
                personaActual.Telefono = this.txt_telefono.Text;

                PersonasLogic perLogic = new PersonasLogic();
                personaActual.State = BusinessEntity.States.Modified;
                perLogic.Save(personaActual);


            }
            else if (_Modo == ModoForm.Baja)
            {

                PersonasLogic perLogic = new PersonasLogic();
                personaActual.State = BusinessEntity.States.Deleted;
                perLogic.Save(personaActual);
            }
            else
                btn_aceptar.Text = "Aceptar";
        }

        public override void MapearDeDatos()
        {
            txt_Nombre.Text = this.personaActual.Nombre.ToString();
            txt_Apellido.Text = this.personaActual.Apellido.ToString();
            txt_email.Text = this.personaActual.Email.ToString();
            txt_direccion.Text = this.personaActual.Direccion.ToString();
            txt_legajo.Text = this.personaActual.Legajo.ToString();
            dtp_fechaNac.Value = this.personaActual.FechaNacimiento;
            txt_telefono.Text = this.personaActual.Telefono;


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
                txt_Nombre.Enabled = false;
                txt_Apellido.Enabled = false;
                txt_email.Enabled = false;
                txt_legajo.Enabled = false;
                txt_telefono.Enabled = false;
                txt_direccion.Enabled = false;
                
            }
            else
            {

                btn_aceptar.Text = "Aceptar";
            }


        }

        public bool Validar(string nombre, string apel, int leg, string email, string tel, string dir)
        {
            if (nombre.Length > 0 & apel.Length > 0 & leg > 0 & email.Length > 0 & tel.Length > 0 & dir.Length > 0)
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

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_Nombre.Text;
            string apellido = this.txt_Apellido.Text;
            string direccion = this.txt_direccion.Text;
            int legajo = int.Parse(this.txt_legajo.Text);
            string email = this.txt_email.Text;
            string telefono = this.txt_telefono.Text;
            


            if (Validar(nombre, apellido, legajo, email, telefono, direccion) == true)
            {
                this.GuardarCambios();
            }

            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
