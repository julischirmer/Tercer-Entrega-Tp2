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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private Persona.TiposPersonas _tipoPersona;

        public Persona.TiposPersonas tipoPersona
        {
            get { return _tipoPersona; }
            set {_tipoPersona = value; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(txtContraseña.PasswordChar == '\0')
            {
                txtContraseña.PasswordChar = '*';
            } else
            {
                txtContraseña.PasswordChar = '\0';
            }
            
        }

        private void btnCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogic user = new UsuarioLogic();
            Usuario usuarioActual = user.validarUsuario(txtUsuario.Text, txtContraseña.Text);

            if (usuarioActual is null)
            {
                lbMensaje.Text = "Usuario no existente o datos incorrectos";
                pError.BackColor = Color.Brown;
                pError.Visible = true;
                lbMensaje.Visible = true;

            } else {
                PersonasLogic pers = new PersonasLogic();
                Persona personaActual = new Persona();
                personaActual = pers.GetOne(usuarioActual.idPersona);
                tipoPersona = personaActual.TipoPersona;
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            
            
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            pError.Visible = false;
            lbMensaje.Visible = false;
        }
    }
}
