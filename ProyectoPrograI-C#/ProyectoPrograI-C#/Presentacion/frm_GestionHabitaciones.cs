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

        private void mtd_VaciarEspacios()
        {
            cbox_CodigoEmpleado.Text = "";
            cbox_CodigoHabitacion.Text = "";
            cbox_TipoGestion.Text = "";
            cbox_Estado.Text = "";
            dtp_FechaGestion.Value = DateTime.Today;
            txt_UsuarioAuditoria.Clear();
        }   

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_CodigoEmpleado.Text) || string.IsNullOrEmpty(cbox_CodigoHabitacion.Text) || string.IsNullOrEmpty(cbox_TipoGestion.Text) || string.IsNullOrEmpty(cbox_Estado.Text))
            {
                MessageBox.Show("Por favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;
                    int CodigoHabitacion = (int)((dynamic)cbox_CodigoHabitacion.SelectedItem).Value;
                    string TipoGestion = cbox_TipoGestion.Text;
                    string Estado = cbox_Estado.Text;
                    DateTime FechaGestion = dtp_FechaGestion.Value.Date;
                    string UsuarioAuditoria = txt_UsuarioAuditoria.Text;
                    DateTime FechaAuditoria = DateTime.Today.Date;
                    conexion.mtd_AgregarGestion(CodigoEmpleado, CodigoHabitacion, TipoGestion, Estado, FechaGestion, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Registro guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_ConsultarGestiones();
                    mtd_VaciarEspacios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
