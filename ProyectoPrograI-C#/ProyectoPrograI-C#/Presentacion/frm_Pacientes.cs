using ProyectoPrograI_C_.Datos;
using ProyectoPrograI_C_.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_Pacientes : Form
    {
        CD_Pacientes conexion = new CD_Pacientes();
        public frm_Pacientes()
        {
            InitializeComponent();
        }

        private void Mtd_MostrarCodigoHabitacion()
        {
            var CodigoHaabitacion = conexion.Mtd_ListaCodigoHabitacion();

            foreach (var Habitaciones in CodigoHaabitacion)
            {
                cbox_CodigoHabitacion.Items.Add(Habitaciones);
            }

            cbox_CodigoHabitacion.DisplayMember = "Text";
            cbox_CodigoHabitacion.ValueMember = "Value";
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_CodigoPaciente.Text))
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoPacientes = int.Parse(txt_CodigoPaciente.Text);

                conexion.Mtd_EliminarPacientes(CodigoPacientes);
                MessageBox.Show("Habitacion Eliminada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mtd_ConsultarPacientes();
                Mtd_LimpiarCampos();
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_CodigoHabitacion.Text) || string.IsNullOrEmpty(txt_Nombre.Text) || string.IsNullOrEmpty(txt_Nit.Text) || string.IsNullOrEmpty(cbox_TipoPaciente.Text) || string.IsNullOrEmpty(cbox_Estado.Text) || string.IsNullOrEmpty(dt_FechaNacimiento.Text)) 
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoHabitacion = (int)((dynamic)cbox_CodigoHabitacion.SelectedItem).Value;
                    string Nombre = txt_Nombre.Text;
                    string Nit = txt_Nit.Text;
                    DateTime FechaNacimiento = dt_FechaNacimiento.Value;
                    string TipoPaciente = cbox_TipoPaciente.Text;
                    string Estado = cbox_Estado.Text;
                    string UsuarioAuditoria = Cache_Usuario.Usuario;
                    DateTime FechaAuditoria = DateTime.Now;

                    conexion.Mtd_AgregarPacientes(CodigoHabitacion, Nombre, Nit, FechaNacimiento, TipoPaciente, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Paciente Agregada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtd_ConsultarPacientes();
                    Mtd_LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frm_Pacientes_Load(object sender, EventArgs e)
        {
            Mtd_ConsultarPacientes();
            Mtd_MostrarCodigoHabitacion();
        }

        private void Mtd_ConsultarPacientes()
        {
            DataTable DT = conexion.Mtd_ConsultarPacientes();
            dgv_Pacientes.DataSource = DT;
        }

        public void Mtd_LimpiarCampos()
        {
            cbox_CodigoHabitacion.Text = "";
            txt_Nombre.Text = "";
            txt_Nit.Text = "";
            dt_FechaNacimiento.Text = "";
            cbox_TipoPaciente.Text = "";
            cbox_Estado.Text = "";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Mtd_LimpiarCampos();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_CodigoHabitacion.Text) || string.IsNullOrEmpty(txt_Nombre.Text) || string.IsNullOrEmpty(txt_Nit.Text) || string.IsNullOrEmpty(cbox_TipoPaciente.Text) || string.IsNullOrEmpty(cbox_Estado.Text) || string.IsNullOrEmpty(dt_FechaNacimiento.Text))
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoPaciente = int.Parse(txt_CodigoPaciente.Text);
                    int CodigoHabitacion = (int)((dynamic)cbox_CodigoHabitacion.SelectedItem).Value;
                    string Nombre = txt_Nombre.Text;
                    string Nit = txt_Nit.Text;
                    DateTime FechaNacimiento = dt_FechaNacimiento.Value;
                    string TipoPaciente = cbox_TipoPaciente.Text;
                    string Estado = cbox_Estado.Text;

                    conexion.Mtd_ActualizarPacientes(CodigoPaciente, CodigoHabitacion, Nombre, Nit, FechaNacimiento, TipoPaciente, Estado);
                    MessageBox.Show("Paciente Actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtd_ConsultarPacientes();
                    Mtd_LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_Pacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSelect = dgv_Pacientes.SelectedRows[0];

            if (FilaSelect.Index == dgv_Pacientes.RowCount -1)
            {
                MessageBox.Show("Debe Seleccionar una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_CodigoPaciente.Text = dgv_Pacientes.SelectedCells[0].Value.ToString();
                cbox_CodigoHabitacion.Text = dgv_Pacientes.SelectedCells[1].Value.ToString();
                txt_Nombre.Text = dgv_Pacientes.SelectedCells[2].Value.ToString();
                txt_Nit.Text = dgv_Pacientes.SelectedCells[3].Value.ToString();
                dt_FechaNacimiento.Text = dgv_Pacientes.SelectedCells[4].Value.ToString();
                cbox_TipoPaciente.Text = dgv_Pacientes.SelectedCells[5].Value.ToString();
                cbox_Estado.Text = dgv_Pacientes.SelectedCells[6].Value.ToString();
            }
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void frm_Pacientes_MouseDown_1(object sender, MouseEventArgs e)
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
