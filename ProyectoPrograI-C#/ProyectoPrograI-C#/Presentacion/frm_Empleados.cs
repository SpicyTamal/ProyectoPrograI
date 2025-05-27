using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograI_C_.Datos;
using ProyectoPrograI_C_.Logica;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_Empleados : Form
    {
        // Instancia de la clase de lógica de empleados
        Logica.CL_Empleados sueldos = new Logica.CL_Empleados();
        //Instancia de la clase datos de empleados
        Datos.CD_Empleados empleados = new Datos.CD_Empleados(); 
        public frm_Empleados()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Disminuir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_NombreEmpleado.Clear();
            cbox_TipoTrabajo.SelectedIndex = -1;
            txt_Especialidad.Clear();
            lbl_Sueldo.Text = 0.ToString("2c");
            cbox_Estado.SelectedIndex = -1;

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NombreEmpleado.Text) || string.IsNullOrEmpty(cbox_TipoTrabajo.Text) || string.IsNullOrEmpty(txt_Especialidad.Text) ||
                string.IsNullOrEmpty(cbox_Estado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Nombre = txt_NombreEmpleado.Text;
                    string TipoTrabajo = cbox_TipoTrabajo.Text;
                    string Especialidad = txt_Especialidad.Text;
                    double Sueldo = sueldos.mtd_Salarios(cbox_TipoTrabajo.Text);
                    DateTime FechaAlta = dtp_FechaAlta.Value;
                    string Estado = cbox_Estado.Text;
                    DateTime FechaAuditoria = DateTime.Today;
                    string UsuarioAuditoria = "Kevin_Monterroso"; //pendiente de revision para funcionar con el sing in

                    empleados.mtd_AgregarEmpleado(Nombre, TipoTrabajo, Sueldo, Especialidad, FechaAlta, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Empleado agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_ConsultarEmpleados();
                    //metodo de limpiar casillas()
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void mtd_ConsultarEmpleados()
        {
            DataTable Dt = empleados.mtd_ConsultarEmpleados();
            dgv_Empleados.DataSource = Dt;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

        }

        private void cbox_TipoTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Sueldo.Text = sueldos.mtd_Salarios(cbox_TipoTrabajo.Text).ToString("C2");
        }
    }
}
