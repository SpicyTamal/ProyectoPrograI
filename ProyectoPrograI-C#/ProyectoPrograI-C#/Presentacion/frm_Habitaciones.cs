using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using ProyectoPrograI_C_.Datos;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_Habitaciones : Form
    {
        CD_Habitaciones CD_Habitaciones = new CD_Habitaciones();


        public frm_Habitaciones()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Mtd_ConsultarHabitaciones()
        {
            DataTable dt = CD_Habitaciones.Mtd_ConsultarHabitaciones();
            dgv_Medicamentos.DataSource = dt;
        }

        private void frm_Habitaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
