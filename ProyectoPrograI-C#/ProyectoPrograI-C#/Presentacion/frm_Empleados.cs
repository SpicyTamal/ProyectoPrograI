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
using ProyectoPrograI_C_.Datos;
using ProyectoPrograI_C_.Logica;
using ProyectoPrograI_C_.Seguridad;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_Empleados : Form
    {
       
        Logica.CL_Empleados sueldos = new Logica.CL_Empleados(); //instancia de la clase logica       
        Datos.CD_Empleados empleados = new Datos.CD_Empleados(); //instancia de la clase datos
        public frm_Empleados()
        {
            InitializeComponent();
        }

        //metodos para mover el formulario con el mouse
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);                
        private void frm_Empleados_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        } 

        private void mtd_ConsultarEmpleados()
        {
            DataTable Dt = empleados.mtd_ConsultarEmpleados();
            dgv_Empleados.DataSource = Dt;
        } //llama al metodo que llena el datagridview con la tabla empleados de la base de datos

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        } //cierra el formulario

        private void btn_Disminuir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } //minimiza el formulario con el boton minimizar

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var FilaSeleccionada = dgv_Empleados.SelectedRows[0];
            if (FilaSeleccionada.Index == dgv_Empleados.RowCount - 1)
            {
                MessageBox.Show("Por favor seleccione el empleado a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string CodigoEmpleado = dgv_Empleados.SelectedCells[0].Value.ToString(); ;

                    empleados.mtd_EliminarEmpleado(CodigoEmpleado);
                    MessageBox.Show("Empleado eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_ConsultarEmpleados();
                    mtd_VaciarEspacios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } //elimina el empleado seleccionado en el datagridview

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            mtd_VaciarEspacios();
        } //limpia los espacios donde se ingresan los datos mediante el boton cancelar

        void mtd_VaciarEspacios()
        {
            txt_NombreEmpleado.Clear();
            cbox_TipoTrabajo.SelectedIndex = -1;
            txt_Especialidad.Clear();
            lbl_Sueldo.Text = 0.ToString("c2");
            cbox_Estado.SelectedIndex = -1;
            txt_UsuarioAuditoria.Clear();
            dtp_FechaAlta.Value = DateTime.Now;
        } //limpia los espacios donde se ingresan los datos

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NombreEmpleado.Text) || string.IsNullOrEmpty(cbox_TipoTrabajo.Text) || string.IsNullOrEmpty(txt_Especialidad.Text) || string.IsNullOrEmpty(cbox_Estado.Text))
            {
                MessageBox.Show("Por favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Nombre = txt_NombreEmpleado.Text;
                    string TipoTrabajo = cbox_TipoTrabajo.Text;
                    string Especialidad = txt_Especialidad.Text;
                    double Sueldo = sueldos.mtd_Salarios(cbox_TipoTrabajo.Text);
                    DateTime FechaAlta = dtp_FechaAlta.Value.Date;
                    string Estado = cbox_Estado.Text;
                    DateTime FechaAuditoria = DateTime.Today.Date;
                    string UsuarioAuditoria = Cache_Usuario.Usuario;

                    empleados.mtd_AgregarEmpleado(Nombre, TipoTrabajo, Sueldo, Especialidad, FechaAlta, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Empleado agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_ConsultarEmpleados();
                    mtd_VaciarEspacios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } //agrega un nuevo empleado a la base de datos        

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NombreEmpleado.Text) || string.IsNullOrEmpty(cbox_TipoTrabajo.Text) || string.IsNullOrEmpty(txt_Especialidad.Text) || string.IsNullOrEmpty(cbox_Estado.Text))
            {
                MessageBox.Show("Por favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string CodigoEmpleado = dgv_Empleados.SelectedCells[0].Value.ToString();
                    string Nombre = txt_NombreEmpleado.Text;
                    string TipoTrabajo = cbox_TipoTrabajo.Text;
                    string Especialidad = txt_Especialidad.Text;
                    double Sueldo = sueldos.mtd_Salarios(cbox_TipoTrabajo.Text);
                    DateTime FechaAlta = dtp_FechaAlta.Value.Date;
                    string Estado = cbox_Estado.Text;
                    DateTime FechaAuditoria = DateTime.Today.Date;
                    string UsuarioAuditoria = txt_UsuarioAuditoria.Text; //pendiente de revision para funcionar con el sing in

                    empleados.mtd_ActualizarEmpleado(CodigoEmpleado, Nombre, TipoTrabajo, Sueldo, Especialidad, FechaAlta, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Empleado actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_ConsultarEmpleados();
                    mtd_VaciarEspacios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } //actualiza los datos del empleado seleccionado en el datagridview

        private void cbox_TipoTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Sueldo.Text = sueldos.mtd_Salarios(cbox_TipoTrabajo.Text).ToString("C2");
        } //actualiza el label del sueldo al cambiar el tipo de trabajo seleccionado

        private void frm_Empleados_Load(object sender, EventArgs e)
        {
            mtd_ConsultarEmpleados();
        } //carga el datagridview con los datos de la base de datos al iniciar el formulario

        private void dgv_Empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgv_Empleados.SelectedRows[0];
            if (FilaSeleccionada.Index == dgv_Empleados.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                txt_NombreEmpleado.Text = dgv_Empleados.SelectedCells[1].Value.ToString();                
                cbox_TipoTrabajo.Text = dgv_Empleados.SelectedCells[2].Value.ToString();
                txt_Especialidad.Text = dgv_Empleados.SelectedCells[3].Value.ToString();
                lbl_Sueldo.Text = sueldos.mtd_Salarios(cbox_TipoTrabajo.Text).ToString("C2");
                dtp_FechaAlta.Text = dgv_Empleados.SelectedCells[5].Value.ToString();
                cbox_Estado.Text = dgv_Empleados.SelectedCells[6].Value.ToString();
                txt_UsuarioAuditoria.Text = dgv_Empleados.SelectedCells[7].Value.ToString();             
            }
        } //le da a los selectores y cuadros de texto su valor correspondiente a la fila seleccionada del datagridview

        //*******eventos hechos por accidente**********//
        private void label6_Click(object sender, EventArgs e) { }
        private void dtp_FechaAlta_ValueChanged(object sender, EventArgs e) { }
        private void txt_Especialidad_TextChanged(object sender, EventArgs e) { }
        private void txt_NombreEmpleado_TextChanged(object sender, EventArgs e) { }
        private void cbox_Estado_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txt_UsuarioAuditoria_TextChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void lbl_Sueldo_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dgv_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
