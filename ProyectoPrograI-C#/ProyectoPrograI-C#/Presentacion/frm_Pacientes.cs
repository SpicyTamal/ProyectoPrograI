﻿using ProyectoPrograI_C_.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_Pacientes : Form
    {
        CD_Conexion conectar = new CD_Conexion();

        public frm_Pacientes()
        {
            InitializeComponent();
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            conectar.MtdAbrirConexion();
        }
    }
}
