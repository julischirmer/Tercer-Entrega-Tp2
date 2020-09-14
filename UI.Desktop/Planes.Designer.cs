namespace UI.Desktop
{
    partial class Planes
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
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgv_planes = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.tsb_Editar = new System.Windows.Forms.ToolStripButton();
            this.tsb_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planes)).BeginInit();
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(658, 415);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(658, 442);
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
            this.tableLayoutPanel1.Controls.Add(this.btn_actualizar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_salir, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_planes, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_actualizar.Location = new System.Drawing.Point(492, 337);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(64, 19);
            this.btn_actualizar.TabIndex = 0;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(560, 337);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(56, 19);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dgv_planes
            // 
            this.dgv_planes.AllowUserToAddRows = false;
            this.dgv_planes.AllowUserToDeleteRows = false;
            this.dgv_planes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_planes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.desc_plan,
            this.id_especialidad,
            this.Desc_Especialidad});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_planes, 2);
            this.dgv_planes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_planes.Location = new System.Drawing.Point(2, 2);
            this.dgv_planes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_planes.Name = "dgv_planes";
            this.dgv_planes.ReadOnly = true;
            this.dgv_planes.RowHeadersWidth = 51;
            this.dgv_planes.RowTemplate.Height = 24;
            this.dgv_planes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_planes.Size = new System.Drawing.Size(614, 331);
            this.dgv_planes.TabIndex = 2;
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
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID Plan";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // desc_plan
            // 
            this.desc_plan.DataPropertyName = "Descripcion";
            this.desc_plan.HeaderText = "Descripcion Plan";
            this.desc_plan.MinimumWidth = 6;
            this.desc_plan.Name = "desc_plan";
            this.desc_plan.ReadOnly = true;
            this.desc_plan.Width = 125;
            // 
            // id_especialidad
            // 
            this.id_especialidad.DataPropertyName = "IDEspecialidad";
            this.id_especialidad.HeaderText = "ID Especialidad";
            this.id_especialidad.MinimumWidth = 6;
            this.id_especialidad.Name = "id_especialidad";
            this.id_especialidad.ReadOnly = true;
            this.id_especialidad.Width = 125;
            // 
            // Desc_Especialidad
            // 
            this.Desc_Especialidad.DataPropertyName = "DescEspecialidad";
            this.Desc_Especialidad.HeaderText = "Especialidad";
            this.Desc_Especialidad.Name = "Desc_Especialidad";
            this.Desc_Especialidad.ReadOnly = true;
            // 
            // Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 442);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Planes";
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.Planes_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dgv_planes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Nuevo;
        private System.Windows.Forms.ToolStripButton tsb_Editar;
        private System.Windows.Forms.ToolStripButton tsb_Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Especialidad;
    }
}