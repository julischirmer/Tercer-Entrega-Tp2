namespace UI.Desktop
{
    partial class Personas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.id_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.tsb_Editar = new System.Windows.Forms.ToolStripButton();
            this.tsb_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1656, 344);
            this.toolStripContainer1.Location = new System.Drawing.Point(9, 10);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1656, 371);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dgvPersonas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Actualizar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Salir, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1656, 344);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_persona,
            this.nombre,
            this.apellido,
            this.direccion,
            this.email,
            this.telefono,
            this.fecha_nac,
            this.legajo,
            this.Tipo_Persona,
            this.id_plan,
            this.desc_plan});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvPersonas, 2);
            this.dgvPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonas.Location = new System.Drawing.Point(2, 2);
            this.dgvPersonas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersWidth = 51;
            this.dgvPersonas.RowTemplate.Height = 24;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(1652, 317);
            this.dgvPersonas.TabIndex = 0;
            // 
            // id_persona
            // 
            this.id_persona.DataPropertyName = "ID";
            this.id_persona.HeaderText = "ID";
            this.id_persona.MinimumWidth = 6;
            this.id_persona.Name = "id_persona";
            this.id_persona.ReadOnly = true;
            this.id_persona.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "Apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "Direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // fecha_nac
            // 
            this.fecha_nac.DataPropertyName = "FechaNacimiento";
            this.fecha_nac.HeaderText = "Fecha Nacimiento";
            this.fecha_nac.MinimumWidth = 6;
            this.fecha_nac.Name = "fecha_nac";
            this.fecha_nac.ReadOnly = true;
            this.fecha_nac.Width = 125;
            // 
            // legajo
            // 
            this.legajo.DataPropertyName = "Legajo";
            this.legajo.HeaderText = "Legajo";
            this.legajo.MinimumWidth = 6;
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            this.legajo.Width = 125;
            // 
            // Tipo_Persona
            // 
            this.Tipo_Persona.DataPropertyName = "TipoPersona";
            this.Tipo_Persona.HeaderText = "Tipo de Persona";
            this.Tipo_Persona.MinimumWidth = 6;
            this.Tipo_Persona.Name = "Tipo_Persona";
            this.Tipo_Persona.ReadOnly = true;
            this.Tipo_Persona.Width = 125;
            // 
            // id_plan
            // 
            this.id_plan.DataPropertyName = "IDPlan";
            this.id_plan.HeaderText = "ID Plan";
            this.id_plan.MinimumWidth = 6;
            this.id_plan.Name = "id_plan";
            this.id_plan.ReadOnly = true;
            this.id_plan.Width = 125;
            // 
            // desc_plan
            // 
            this.desc_plan.DataPropertyName = "DescPlan";
            this.desc_plan.HeaderText = "Descripcion del Plan";
            this.desc_plan.MinimumWidth = 6;
            this.desc_plan.Name = "desc_plan";
            this.desc_plan.ReadOnly = true;
            this.desc_plan.Width = 125;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Actualizar.Location = new System.Drawing.Point(1528, 323);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(66, 19);
            this.btn_Actualizar.TabIndex = 1;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.Location = new System.Drawing.Point(1598, 323);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(56, 19);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Nuevo,
            this.tsb_Editar,
            this.tsb_Eliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(213, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsb_Nuevo
            // 
            this.tsb_Nuevo.Image = global::UI.Desktop.Properties.Resources.mas;
            this.tsb_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Nuevo.Name = "tsb_Nuevo";
            this.tsb_Nuevo.Size = new System.Drawing.Size(66, 24);
            this.tsb_Nuevo.Text = "Nuevo";
            this.tsb_Nuevo.Click += new System.EventHandler(this.tsb_Nuevo_Click);
            // 
            // tsb_Editar
            // 
            this.tsb_Editar.Image = global::UI.Desktop.Properties.Resources.lapiz;
            this.tsb_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Editar.Name = "tsb_Editar";
            this.tsb_Editar.Size = new System.Drawing.Size(61, 24);
            this.tsb_Editar.Text = "Editar";
            this.tsb_Editar.Click += new System.EventHandler(this.tsb_Editar_Click);
            // 
            // tsb_Eliminar
            // 
            this.tsb_Eliminar.Image = global::UI.Desktop.Properties.Resources.eliminar;
            this.tsb_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Eliminar.Name = "tsb_Eliminar";
            this.tsb_Eliminar.Size = new System.Drawing.Size(74, 24);
            this.tsb_Eliminar.Text = "Eliminar";
            this.tsb_Eliminar.Click += new System.EventHandler(this.tsb_Eliminar_Click);
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1755, 384);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Personas";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.Personas_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Nuevo;
        private System.Windows.Forms.ToolStripButton tsb_Editar;
        private System.Windows.Forms.ToolStripButton tsb_Eliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_plan;
    }
}