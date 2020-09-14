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
    public partial class Especialidades : System.Web.UI.Page
    {
        #region Metodos
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
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
                    this.Entity = new Especialidad();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    if (ValidarTamaño() == true)
                    {
                        this.SaveEntity(this.Entity);
                        this.gridView.DataBind();
                        this.formPanel.Visible = false;
                    }
                    else
                    {
                        string script = "alert(\"La descripcion debe tener mas de 10 carateres\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    break;

                case FormModes.Baja:                    
                    this.DeleteEntity(this.SelectedID);
                    this.formPanel.Visible = false;
                    this.gridView.DataBind();                

                    break;

                case FormModes.Alta:

                    if (ValidarTamaño() == true)
                    {
                        this.Entity = new Especialidad();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.gridView.DataBind();
                        this.formPanel.Visible = false;
                    }
                    else
                    {
                        string script = "alert(\"La descripcion debe tener mas de 10 carateres\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    break;

                default:
                    break;
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
            this.txt_descripcion.Text = string.Empty;
        }

        public void EnableForm(bool enable)
        {
            this.txt_descripcion.Enabled = enable;
        }

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        private void SaveEntity(Especialidad esp)
        {
            this.Logic.Save(esp);
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.txt_ID.Text = this.Entity.ID.ToString();
            this.txt_descripcion.Text = this.Entity.Descripcion;
        }

        private void LoadEntity(Especialidad esp)
        {
            esp.Descripcion = this.txt_descripcion.Text;
        }
               

        public bool ValidarTamaño()
        {
            if (txt_descripcion.Text.Length > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        EspecialidadLogic _logic;
        private EspecialidadLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new EspecialidadLogic();
                }
                return _logic;
            }
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        private Especialidad Entity
        {
            get;
            set;
        }

        public int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
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