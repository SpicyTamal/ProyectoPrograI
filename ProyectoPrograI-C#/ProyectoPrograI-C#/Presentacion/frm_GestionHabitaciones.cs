using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograI_C_.Datos;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_GestionHabitaciones : Form
    {
        CD_GestionHabitaciones conexion = new CD_GestionHabitaciones();
        public frm_GestionHabitaciones()
        {
            InitializeComponent();
        }

        private void frm_GestionHabitaciones_Load(object sender, EventArgs e)
        {
            mtd_MostrarEmpleados();
            mtd_MostrarHabitaciones();
            mtd_ConsultarGestiones();
        }
        private void mtd_MostrarEmpleados()
        {
            var CodigoEmpleados = conexion.mtd_ListaEmpleados();
            foreach (var Empleado in CodigoEmpleados)
            {
                cbox_CodigoEmpleado.Items.Add(Empleado);
            }
            cbox_CodigoEmpleado.DisplayMember = "Text";
            cbox_CodigoEmpleado.ValueMember = "Value";
        }
        private void mtd_MostrarHabitaciones()
        {
            var CodigoHabitaciones = conexion.mtd_ListaHabitaciones();
            foreach (var Habitacion in CodigoHabitaciones)
            {
                cbox_CodigoHabitacion.Items.Add(Habitacion);
            }
            cbox_CodigoHabitacion.DisplayMember = "Text";
            cbox_CodigoHabitacion.ValueMember = "Value";
        }

        private void mtd_ConsultarGestiones()
        {
            DataTable Dt = conexion.mtd_ConsultarGestiones();
            dgv_GestionHabitaciones.DataSource = Dt;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
