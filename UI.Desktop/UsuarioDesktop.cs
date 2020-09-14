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
using System.Globalization;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public UsuarioDesktop(ModoForm modo) : this()
        {
            _Modo = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this() 
        {
            _Modo = modo;
            UsuarioLogic usuario = new UsuarioLogic();
           UsuarioActual = usuario.GetOne(ID);
            this.MapearDeDatos();
        }

        #region Propiedades
        public Usuario _Usuarioactual;
        public Usuario UsuarioActual
        {
            get { return _Usuarioactual; }
            set { _Usuarioactual = value; }
        }
        #endregion;

        #region Metodos


        public override void MapearADatos()
        {
     
           
           
            
            if (_Modo == ModoForm.Alta)
            {
                Usuario UsuarioNuevo = new Usuario();
                

                UsuarioNuevo.Habilitado = this.chkHabilitado.Checked;
                UsuarioNuevo.Nombre = this.txtNombre.Text;
                UsuarioNuevo.Apellido = this.txtApellido.Text;
                UsuarioNuevo.Email = this.txtEmail.Text;
                UsuarioNuevo.Clave = this.txtClave.Text;
                UsuarioNuevo.NombreUsuario = this.txtUsuario.Text;
                UsuarioActual = UsuarioNuevo;
                UsuarioLogic nuevousuario = new UsuarioLogic();
                UsuarioNuevo.State = BusinessEntity.States.New;
                nuevousuario.Save(UsuarioActual);



            }

            else if (_Modo == ModoForm.Modificacion)
            {
              
                UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                UsuarioActual.Nombre = this.txtNombre.Text;
                UsuarioActual.Apellido = this.txtApellido.Text;
                UsuarioActual.Email = this.txtEmail.Text;
                UsuarioActual.Clave = this.txtClave.Text;
                UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                
                UsuarioLogic nuevousuario = new UsuarioLogic();
                UsuarioActual.State = BusinessEntity.States.Modified;
                nuevousuario.Save(UsuarioActual);
       

            }
            else if (_Modo == ModoForm.Baja)
            {
           
                UsuarioLogic nuevousuario = new UsuarioLogic();
                UsuarioActual.State = BusinessEntity.States.Deleted;
                nuevousuario.Save(UsuarioActual);
            }
            else
                btnAceptar.Text = "Aceptar";
        }

        
        public bool Validar(string apellido, string nombre, string email, string usuario, string clave, string conf)
        {
            if (apellido.Length != 0 & nombre.Length != 0 & email.Length != 0 & usuario.Length != 0 & clave.Length != 0 & clave == conf
                & clave.Length <= 8)
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
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;

            if(_Modo == ModoForm.Alta)
            {
                btnAceptar.Text = "Guardar";
            } else if(_Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            } else if(_Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
            } else
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

            string Apellido = this.txtApellido.Text;
            string Nombre = this.txtNombre.Text;
            string Email = this.txtEmail.Text;
            string NombreUsuario = this.txtUsuario.Text;
            string Clave = this.txtClave.Text;
            string Conf = this.txtConfirmClave.Text;


            if (Validar(Apellido, Nombre, Email, NombreUsuario, Clave, Conf) == true)
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
