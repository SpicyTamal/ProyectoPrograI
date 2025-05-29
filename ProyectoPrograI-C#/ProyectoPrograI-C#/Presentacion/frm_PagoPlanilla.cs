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
    public partial class frm_PagoPlanilla : Form
    {
        CD_PagoPlanilla conexion = new CD_PagoPlanilla();
        CL_PagoPlanilla logica = new CL_PagoPlanilla();
        public frm_PagoPlanilla()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*
        public void mtd_LlenarCodigoEmpleados()          REEEEEEEEEEEMPLAZABLEEEEEEEEEEEEEEEEEE
        {
            var lista = conexion.MtdListaEmpleados(); // O CD_PagoPlanilla si ese es el correcto

            // Asignar la lista directamente como fuente de datos del ComboBox
            cbox_CodigoEmpleado.DataSource = lista;
            cbox_CodigoEmpleado.DisplayMember = "Text"; // Lo que se mostrará (CodigoEmpleado - NombreEmpleado)
            cbox_CodigoEmpleado.ValueMember = "Value";  // Lo que se usará como valor (CodigoEmpleado)
        } */
        private void frm_PagoPlanilla_Load(object sender, EventArgs e)
        {
            Mtd_MostrarCodigoPacientes();
            mtd_ConsultarPagos();
        }

        private void lbl_Sueldo_Click(object sender, EventArgs e)
        {

        }
        
        private void cbox_CodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;
            lbl_Sueldo.Text = conexion.mtd_ConsultarSalario(codigoEmpleado).ToString("C2"); //devuelve el salario con el cboxcodigo empleado
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_PagoPlanilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //esto llama a la funciond e lista en capa datos
        private void Mtd_MostrarCodigoPacientes()
        {
            var CodigoPacientes = conexion.mtd_ListaEmpleados();

            foreach (var Empleado in CodigoPacientes)
            {
                cbox_CodigoEmpleado.Items.Add(Empleado);
            }

            cbox_CodigoEmpleado.DisplayMember = "Text";
            cbox_CodigoEmpleado.ValueMember = "Value";
        }

        private void mtd_ConsultarPagos()
        {
            DataTable Dt = conexion.mtd_ConsultarPagos();
            dgv_PagoPlanilla.DataSource = Dt;
        }
    }
}
