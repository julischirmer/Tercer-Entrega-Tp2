﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Reporte_Usuario : Form
    {
        public Reporte_Usuario()
        {
            InitializeComponent();
        }

        private void Reporte_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.tp2_netDataSet.usuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
