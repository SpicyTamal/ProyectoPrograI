using ProyectoPrograI_C_.Datos;
using ProyectoPrograI_C_.Logica;
using ProyectoPrograI_C_.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_Habitaciones : Form
    {
        CD_Habitaciones CD_Habitaciones = new CD_Habitaciones();
        CL_Habitaciones CL_Habitaciones = new CL_Habitaciones();


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
            if (string.IsNullOrEmpty(txt_CodigoHabitacion.Text))
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHabtiacion = int.Parse(txt_CodigoHabitacion.Text);

                CD_Habitaciones.Mtd_EliminarHabitaciones(CodigoHabtiacion);
                MessageBox.Show("Habitacion Eliminada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mtd_ConsultarHabitaciones();
                Mtd_LimpiarCampos();
            }
        }

        private void Mtd_ConsultarHabitaciones()
        {
            DataTable dt = CD_Habitaciones.Mtd_ConsultarHabitaciones();
            dgv_Habitaciones.DataSource = dt;
        }

        private void frm_Habitaciones_Load(object sender, EventArgs e)
        {
            Mtd_ConsultarHabitaciones();
        }

        private void dgv_Medicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_TipoHabitacion.Text) || string.IsNullOrEmpty(cbox_Estado.Text))
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string NuumeroHabitacion = cbox_NumeroHabitacion.Text;
                    string Ubicacion = cbox_Ubicacion.Text;
                    string TipoHabitacion = cbox_TipoHabitacion.Text;
                    double Costo = double.Parse(lbl_Costo.Text);
                    string Estado  = cbox_Estado.Text;
                    string UsuarioAuditoria = Cache_Usuario.Usuario;
                    DateTime FechaAuditoria = CL_Habitaciones.MtdFechaHoy();

                    CD_Habitaciones.Mtd_AgregarHabitaciones(NuumeroHabitacion, Ubicacion, TipoHabitacion, Costo, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Habitacion Agregada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtd_ConsultarHabitaciones();
                    Mtd_LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Mtd_LimpiarCampos()
        {
            txt_CodigoHabitacion.Text = "";
            cbox_NumeroHabitacion.Text = "";
            cbox_Ubicacion.Text = "";
            cbox_TipoHabitacion.Text = "";
            lbl_Costo.Text = "";
            cbox_Estado.Text = "";
        }

        private void cbox_TipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Costo.Text = CL_Habitaciones.MtdCostoHabitaciones(cbox_TipoHabitacion.Text).ToString();
        }

        private void dgv_Habitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSelect = dgv_Habitaciones.SelectedRows[0];

            if (FilaSelect.Index == dgv_Habitaciones.RowCount -1)
            {
                MessageBox.Show("Debe Seleccionar una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_CodigoHabitacion.Text = dgv_Habitaciones.SelectedCells[0].Value.ToString();
                cbox_NumeroHabitacion.Text = dgv_Habitaciones.SelectedCells[1].Value.ToString();
                cbox_Ubicacion.Text = dgv_Habitaciones.SelectedCells[2].Value.ToString();
                cbox_TipoHabitacion.Text = dgv_Habitaciones.SelectedCells[3].Value.ToString();
                cbox_Estado.Text = dgv_Habitaciones.SelectedCells[5].Value.ToString();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_TipoHabitacion.Text) || string.IsNullOrEmpty(cbox_Estado.Text))
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoHabitacion = int.Parse(txt_CodigoHabitacion.Text);
                    string NuumeroHabitacion = cbox_NumeroHabitacion.Text;
                    string Ubicacion = cbox_Ubicacion.Text;
                    string TipoHabitacion = cbox_TipoHabitacion.Text;
                    double Costo = double.Parse(lbl_Costo.Text);
                    string Estado = cbox_Estado.Text;;

                    CD_Habitaciones.Mtd_ActualizarHabitaciones(CodigoHabitacion, NuumeroHabitacion, Ubicacion, TipoHabitacion, Costo, Estado);
                    MessageBox.Show("Habitacion Actualizada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtd_ConsultarHabitaciones();
                    Mtd_LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Mtd_LimpiarCampos();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void frm_Habitaciones_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
