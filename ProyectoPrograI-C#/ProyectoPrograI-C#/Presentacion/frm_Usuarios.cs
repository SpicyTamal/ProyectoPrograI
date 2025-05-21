using ProyectoPrograI_C_.Datos;
using ProyectoPrograI_C_.Logica;
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
    public partial class frm_Usuarios: Form
    {
        CD_Usuarios cd_usuarios = new CD_Usuarios();
        CL_Medicamentos cl_medicamentos = new CL_Medicamentos();

        public frm_Usuarios()
        {
            InitializeComponent();
        }

        //METODOS Y LOGICA DEL FORM

        private void mtd_Mostrar_Lista_Empleados()
        {
            var ListaEmpleados = cd_usuarios.mtd_Lista_Empleados();

            foreach (var empleado in ListaEmpleados)
            {
                cbx_foreign_Codigo_Empleado.Items.Add(empleado);
            }

            cbx_foreign_Codigo_Empleado.DisplayMember = "Text";
            cbx_foreign_Codigo_Empleado.ValueMember = "Value";
        }

        private void mtd_Consultar_Usuarios()
        {
            DataTable Dt = cd_usuarios.mtd_Consultar_Usuarios();
            dgv_Usuarios.DataSource = Dt;
        }

        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            mtd_Consultar_Usuarios();
            mtd_Mostrar_Lista_Empleados();
        }

        private void mtd_Limpiar_Campos()
        {
            cbx_foreign_Codigo_Empleado.Text = "";
            txt_Usuario.Text = "";
            txt_Clave.Text = "";
            cbx_Tipo_Usuario.Text = "";
        }

        private void dgv_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgv_Usuarios.SelectedRows[0];

            if (FilaSeleccionada.Index == dgv_Usuarios.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_Codigo_Usuario.Text = dgv_Usuarios.SelectedCells[0].Value.ToString();
                cbx_foreign_Codigo_Empleado.Text = dgv_Usuarios.SelectedCells[1].Value.ToString();
                txt_Usuario.Text = dgv_Usuarios.SelectedCells[2].Value.ToString();
                txt_Clave.Text = dgv_Usuarios.SelectedCells[3].Value.ToString();
                txt_Codigo_Usuario.Text = dgv_Usuarios.SelectedCells[4].Value.ToString();
                cbx_Estado_Usuarios.Text = dgv_Usuarios.SelectedCells[5].Value.ToString();
                txt_Usuario_Auditoria.Text = dgv_Usuarios.SelectedCells[6].Value.ToString();
                txt_Fecha_Auditoria.Text = dgv_Usuarios.SelectedCells[7].Value.ToString();
            }
        }

        //MOVIMIENTOS DEL FORM

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void frm_Usuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //BOTONES

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Codigo_Usuario.Text) || string.IsNullOrEmpty(cbx_foreign_Codigo_Empleado.Text) || string.IsNullOrEmpty(txt_Usuario.Text) ||
               string.IsNullOrEmpty(txt_Clave.Text) || string.IsNullOrEmpty(cbx_Tipo_Usuario.Text) || string.IsNullOrEmpty(cbx_Estado_Usuarios.Text) ||
               string.IsNullOrEmpty(txt_Usuario_Auditoria.Text) || string.IsNullOrEmpty(txt_Fecha_Auditoria.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var EmpleadoSeleccionado = (dynamic)cbx_foreign_Codigo_Empleado.SelectedItem;
                    int CodigoEmpleado = (int)EmpleadoSeleccionado.Value;
                    string Usuario = txt_Usuario.Text;
                    string Clave = txt_Clave.Text;
                    string TipoUsuario = cbx_Tipo_Usuario.Text;
                    string Estado = cbx_Estado_Usuarios.Text;
                    DateTime FechaAuditoria = cl_medicamentos.mtd_Fecha_De_Hoy();
                    string UsuarioAuditoria = "Kevin_Monterroso";

                    cd_usuarios.mtd_Agregar_Usuarios(CodigoEmpleado, Usuario, Clave, TipoUsuario, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Usuario agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_Consultar_Usuarios();
                    mtd_Limpiar_Campos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Codigo_Usuario.Text) || string.IsNullOrEmpty(cbx_foreign_Codigo_Empleado.Text) || string.IsNullOrEmpty(txt_Usuario.Text) ||
               string.IsNullOrEmpty(txt_Clave.Text) || string.IsNullOrEmpty(cbx_Tipo_Usuario.Text) || string.IsNullOrEmpty(cbx_Estado_Usuarios.Text) ||
               string.IsNullOrEmpty(txt_Usuario_Auditoria.Text) || string.IsNullOrEmpty(txt_Fecha_Auditoria.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoUsuario = (int.Parse(txt_Codigo_Usuario.Text));
                    var EmpleadoSeleccionado = (dynamic)cbx_foreign_Codigo_Empleado.SelectedItem;
                    int CodigoEmpleado = (int)EmpleadoSeleccionado.Value;
                    string Usuario = txt_Usuario.Text;
                    string Clave = txt_Clave.Text;
                    string TipoUsuario = cbx_Tipo_Usuario.Text;
                    string Estado = cbx_Estado_Usuarios.Text;
                    DateTime FechaAuditoria = cl_medicamentos.mtd_Fecha_De_Hoy();
                    string UsuarioAuditoria = "Kevin_Monterroso";

                    cd_usuarios.mtd_Actualizar_Usuarios(CodigoUsuario, CodigoEmpleado, Usuario, Clave, TipoUsuario, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Usuario actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_Consultar_Usuarios();
                    mtd_Limpiar_Campos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbx_foreign_Codigo_Empleado.Text))
            {
                MessageBox.Show("Favor seleccionar empleado a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoUsuario = (int.Parse(txt_Codigo_Usuario.Text));

                    cd_usuarios.mtd_Eliminar_Usuarios(CodigoUsuario);
                    MessageBox.Show("Usuario eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_Consultar_Usuarios();
                    mtd_Limpiar_Campos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            mtd_Limpiar_Campos();
        }

        //OTROS

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbx_foreign_Codigo_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
