namespace UI.Desktop
{
    partial class Materias
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
            this.tscMaterias = new System.Windows.Forms.ToolStripContainer();
            this.tlpMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.id_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_semanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tsMateria = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscMaterias.ContentPanel.SuspendLayout();
            this.tscMaterias.TopToolStripPanel.SuspendLayout();
            this.tscMaterias.SuspendLayout();
            this.tlpMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.tsMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscMaterias
            // 
            // 
            // tscMaterias.ContentPanel
            // 
            this.tscMaterias.ContentPanel.Controls.Add(this.tlpMaterias);
            this.tscMaterias.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tscMaterias.ContentPanel.Size = new System.Drawing.Size(1067, 527);
            this.tscMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMaterias.Location = new System.Drawing.Point(0, 0);
            this.tscMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tscMaterias.Name = "tscMaterias";
            this.tscMaterias.Size = new System.Drawing.Size(1067, 554);
            this.tscMaterias.TabIndex = 0;
            this.tscMaterias.Text = "toolStripContainer1";
            // 
            // tscMaterias.TopToolStripPanel
            // 
            this.tscMaterias.TopToolStripPanel.Controls.Add(this.tsMateria);
            // 
            // tlpMaterias
            // 
            this.tlpMaterias.ColumnCount = 2;
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMaterias.Controls.Add(this.dgvMaterias, 0, 0);
            this.tlpMaterias.Controls.Add(this.btnSalir, 1, 1);
            this.tlpMaterias.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMaterias.Location = new System.Drawing.Point(0, 0);
            this.tlpMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpMaterias.Name = "tlpMaterias";
            this.tlpMaterias.RowCount = 2;
            this.tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaterias.Size = new System.Drawing.Size(1067, 527);
            this.tlpMaterias.TabIndex = 0;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_materia,
            this.desc_materia,
            this.hs_semanales,
            this.hs_totales,
            this.id_plan,
            this.desc_plan,
            this.State});
            this.tlpMaterias.SetColumnSpan(this.dgvMaterias, 2);
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(4, 4);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 51;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(1059, 479);
            this.dgvMaterias.TabIndex = 2;
            // 
            // id_materia
            // 
            this.id_materia.DataPropertyName = "ID";
            this.id_materia.HeaderText = "ID Materia";
            this.id_materia.MinimumWidth = 6;
            this.id_materia.Name = "id_materia";
            this.id_materia.ReadOnly = true;
            this.id_materia.Width = 125;
            // 
            // desc_materia
            // 
            this.desc_materia.DataPropertyName = "Descripcion";
            this.desc_materia.HeaderText = "Materia";
            this.desc_materia.MinimumWidth = 6;
            this.desc_materia.Name = "desc_materia";
            this.desc_materia.ReadOnly = true;
            this.desc_materia.Width = 125;
            // 
            // hs_semanales
            // 
            this.hs_semanales.DataPropertyName = "HSSemanales";
            this.hs_semanales.HeaderText = "Horas Semanales";
            this.hs_semanales.MinimumWidth = 6;
            this.hs_semanales.Name = "hs_semanales";
            this.hs_semanales.ReadOnly = true;
            this.hs_semanales.Width = 125;
            // 
            // hs_totales
            // 
            this.hs_totales.DataPropertyName = "HSTotales";
            this.hs_totales.HeaderText = "Horas Totales";
            this.hs_totales.MinimumWidth = 6;
            this.hs_totales.Name = "hs_totales";
            this.hs_totales.ReadOnly = true;
            this.hs_totales.Width = 125;
            // 
            // id_plan
            // 
            this.id_plan.DataPropertyName = "IDPlan";
            this.id_plan.HeaderText = "Id Plan";
            this.id_plan.MinimumWidth = 6;
            this.id_plan.Name = "id_plan";
            this.id_plan.ReadOnly = true;
            this.id_plan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_plan.Width = 125;
            // 
            // desc_plan
            // 
            this.desc_plan.DataPropertyName = "DESCPlan";
            this.desc_plan.HeaderText = "Plan";
            this.desc_plan.MinimumWidth = 6;
            this.desc_plan.Name = "desc_plan";
            this.desc_plan.ReadOnly = true;
            this.desc_plan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.desc_plan.Width = 125;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Estado";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Visible = false;
            this.State.Width = 125;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(963, 491);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.Location = new System.Drawing.Point(855, 491);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tsMateria
            // 
            this.tsMateria.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMateria.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMateria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsMateria.Location = new System.Drawing.Point(4, 0);
            this.tsMateria.Name = "tsMateria";
            this.tsMateria.Size = new System.Drawing.Size(228, 27);
            this.tsMateria.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::UI.Desktop.Properties.Resources.mas;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(76, 24);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::UI.Desktop.Properties.Resources.lapiz;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(72, 24);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEliminar.Image = global::UI.Desktop.Properties.Resources.eliminar;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(67, 24);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tscMaterias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            this.tscMaterias.ContentPanel.ResumeLayout(false);
            this.tscMaterias.TopToolStripPanel.ResumeLayout(false);
            this.tscMaterias.TopToolStripPanel.PerformLayout();
            this.tscMaterias.ResumeLayout(false);
            this.tscMaterias.PerformLayout();
            this.tlpMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.tsMateria.ResumeLayout(false);
            this.tsMateria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMaterias;
        private System.Windows.Forms.TableLayoutPanel tlpMaterias;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.ToolStrip tsMateria;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_semanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}