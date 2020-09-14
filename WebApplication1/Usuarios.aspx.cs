using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        #region Metodos 

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
            gridView.DataBind();
        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Modificacion:
                    this.Entity = new Usuario();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    if (ValidarClave() == true)
                    {
                        this.SaveEntity(this.Entity);
                        this.gridView.DataBind();
                        this.formPanel.Visible = false;
                    }
                    else
                    {
                        string script = "alert(\"La contraseña, no coincide!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    break;
                case FormModes.Baja:
                    if (ValidarClave() == true)
                    {
                        this.DeleteEntity(this.SelectedID);
                        this.formPanel.Visible = false;
                        this.gridView.DataBind();
                    }
                    else
                    {
                        string script = "alert(\"La contraseña, no coincide!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }                   
             
                    break;

                case FormModes.Alta:                   

                    if (ValidarClave() == true)
                    {
                        this.Entity = new Usuario();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.gridView.DataBind();
                        this.formPanel.Visible = false;
                    }
                    else
                    {
                        string script = "alert(\"La contraseña, no coincide!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    break;

                default:
                    break;
            }
            
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {           
            this.SelectedID = (int)this.gridView.SelectedValue; 
        }

        protected void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.EnableForm(true);
                this.btn_Aceptar.Text = "Aceptar";
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }


        protected void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.btn_Aceptar.Text = "Crear";
            this.ClearForm();
            this.EnableForm(true);
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.EnableForm(false);
                this.formPanel.Visible = true;
                this.btn_Aceptar.Text = "Eliminar";
                this.FormMode = FormModes.Baja;
                this.LoadForm(this.SelectedID);
            }

        }

        private void ClearForm()
        {
            this.txt_nombre.Text = string.Empty;
            this.txt_Usuario.Text = string.Empty;
            this.txt_nombre.Text = string.Empty;
            this.txt_apellido.Text = string.Empty;
            this.txt_email.Text = string.Empty;
            this.txt_clave.Text = string.Empty;
            this.chb_habilitado.Checked = false;

        }

        private void LoadEntity(Usuario usuario)
        {
            usuario.NombreUsuario = this.txt_Usuario.Text;
            usuario.Nombre = this.txt_nombre.Text;
            usuario.Apellido = this.txt_apellido.Text;
            usuario.Email = this.txt_email.Text;
            usuario.Clave = this.txt_clave.Text;
            usuario.Habilitado = this.chb_habilitado.Checked;
        }
        
        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }

        

        private void LoadForm (int id)
        {
            this.Entity = this.Logic.GetOne(id); 
            this.txt_ID.Text = this.Entity.ID.ToString();
            this.txt_Usuario.Text = this.Entity.NombreUsuario;
            this.txt_nombre.Text = this.Entity.Nombre;
            this.txt_apellido.Text = this.Entity.Apellido;
            this.txt_email.Text = this.Entity.Email;
            this.txt_clave.Text = this.Entity.Clave;
            this.chb_habilitado.Checked = this.Entity.Habilitado;            
        }

        public bool ValidarClave()
        {
            if (this.txt_clave.Text != this.txt_confClave.Text)
            {             
                return false;
            }
            else
            {
                return true;
            }

            
        }
        

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        public void EnableForm(bool enable)
        {
            this.txt_Usuario.Enabled = enable;
            this.txt_nombre.Enabled = enable;
            this.txt_apellido.Enabled = enable;
            this.txt_email.Enabled = enable;
            this.txt_clave.Enabled = enable;
            this.chb_habilitado.Checked = enable;
        }

        
        #endregion

        #region Enum

        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }

        #endregion 

        #region Propiedades

        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        private Usuario Entity
        {
            get;
            set;
        }

        public int SelectedID
        {
            get
            {
                if(this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }








        #endregion

        
    }
}