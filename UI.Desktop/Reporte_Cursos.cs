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
    public partial class Reporte_Cursos : Form
    {
        public Reporte_Cursos()
        {
            InitializeComponent();
        }

        private void Reporte_Cursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.tp2_netDataSet.cursos);

            this.reportViewer1.RefreshReport();
        }
    }
}