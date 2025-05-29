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

        private void frm_PagoPlanilla_Load(object sender, EventArgs e)
        {
            Mtd_MostrarCodigoEmpleados();
            mtd_ConsultarPagos();
        }

        private void lbl_Sueldo_Click(object sender, EventArgs e) { }

        private void cbox_CodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_CodigoEmpleado.SelectedItem != null)
            {
                int codigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;
                lbl_Sueldo.Text = conexion.mtd_ConsultarSalario(codigoEmpleado).ToString("C2"); //devuelve el salario con el cboxcodigo usado
                lbl_Bono.Text = conexion.mtd_ConsultarBono(codigoEmpleado).ToString("C2");
                lbl_MontoTotal.Text = conexion.mtd_ConsultarMontoTotal(codigoEmpleado, txt_HorasExtras.Text).ToString("C2");
            }
            //int codigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;
            
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_CodigoEmpleado.Text) || string.IsNullOrEmpty(cbox_Estado.Text) || string.IsNullOrEmpty(txt_UsuarioAuditoria.Text))
            {
                MessageBox.Show("Por favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int codigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;
                    DateTime FechaPago = dtp_FechaPago.Value.Date;
                    double Sueldo = conexion.mtd_ConsultarSalario(codigoEmpleado);
                    double Bono = conexion.mtd_ConsultarBono(codigoEmpleado);
                    double MontoHorasExtras = string.IsNullOrEmpty(txt_HorasExtras.Text) ? 0 : double.Parse(txt_HorasExtras.Text);
                    double TotalMonto = conexion.mtd_ConsultarMontoTotal(codigoEmpleado, txt_HorasExtras.Text);
                    string Estado = cbox_Estado.Text;
                    string UsuarioAuditoria = txt_UsuarioAuditoria.Text;
                    DateTime FechaAuditoria = DateTime.Today.Date;
                    conexion.mtd_AgregarPago(codigoEmpleado, FechaPago, Sueldo, Bono, MontoHorasExtras, TotalMonto, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Pago realizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_ConsultarPagos();
                    mtd_VaciarEspacios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_PagoPlanilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgv_PagoPlanilla.SelectedRows[0];

            if (FilaSeleccionada.Cells[0].Value == null || string.IsNullOrWhiteSpace(FilaSeleccionada.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cbox_CodigoEmpleado.Text = FilaSeleccionada.Cells[1].Value.ToString();                 
                string codigoTexto = cbox_CodigoEmpleado.Text;
                var item = cbox_CodigoEmpleado.Items.Cast<dynamic>().FirstOrDefault(x => x.Value.ToString() == codigoTexto);

                if (item != null)
                {
                    int codigoEmpleado = (int)item.Value;
                    lbl_Sueldo.Text = Convert.ToDecimal(FilaSeleccionada.Cells[3].Value).ToString("C2");
                    lbl_Sueldo.Text = Convert.ToDecimal(FilaSeleccionada.Cells[4].Value).ToString("C2");
                    lbl_Sueldo.Text = Convert.ToDecimal(FilaSeleccionada.Cells[5].Value).ToString("C2");
                    txt_HorasExtras.Text = "";
                }
                else
                {
                    MessageBox.Show("Código de empleado no válido o no encontrado en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            /*
            var FilaSeleccionada = dgv_PagoPlanilla.SelectedRows[0];

            if (FilaSeleccionada.Cells[0].Value == null || string.IsNullOrWhiteSpace(FilaSeleccionada.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cbox_CodigoEmpleado.Text = FilaSeleccionada.Cells[1].Value.ToString();

                if (cbox_CodigoEmpleado.SelectedItem != null)
                {
                    int codigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;

                    lbl_Sueldo.Text = conexion.mtd_ConsultarSalario(codigoEmpleado).ToString("C2");
                    lbl_Bono.Text = conexion.mtd_ConsultarBono(codigoEmpleado).ToString("C2");
                    lbl_MontoTotal.Text = conexion.mtd_ConsultarMontoTotal(codigoEmpleado, txt_HorasExtras.Text).ToString("C2");
                }
                else
                {
                    MessageBox.Show("Código de empleado no válido o no encontrado en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
            var FilaSeleccionada = dgv_PagoPlanilla.SelectedRows[0];
            if (FilaSeleccionada.Index == dgv_PagoPlanilla.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cbox_CodigoEmpleado.Text = dgv_PagoPlanilla.SelectedCells[1].Value.ToString();

                // Ahora que has actualizado el ComboBox, puedes obtener SelectedItem
                if (cbox_CodigoEmpleado.SelectedItem != null)
                {
                    int codigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;

                    lbl_Sueldo.Text = conexion.mtd_ConsultarSalario(codigoEmpleado).ToString("C2");
                    lbl_Bono.Text = conexion.mtd_ConsultarBono(codigoEmpleado).ToString("C2");
                    lbl_MontoTotal.Text = conexion.mtd_ConsultarMontoTotal(codigoEmpleado, txt_HorasExtras.Text).ToString("C2");
                }
                else
                {
                    MessageBox.Show("Código de empleado no válido o no encontrado en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            int codigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;
            var FilaSeleccionada = dgv_PagoPlanilla.SelectedRows[0];
            if (FilaSeleccionada.Index == dgv_PagoPlanilla.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cbox_CodigoEmpleado.Text = dgv_PagoPlanilla.SelectedCells[0].Value.ToString();

                lbl_Sueldo.Text = conexion.mtd_ConsultarSalario(codigoEmpleado).ToString("C2");
                lbl_Bono.Text = conexion.mtd_ConsultarBono(codigoEmpleado).ToString("C2");
                lbl_MontoTotal.Text = conexion.mtd_ConsultarMontoTotal(codigoEmpleado, txt_HorasExtras.Text).ToString("C2");


                
                txt_NombreEmpleado.Text = dgv_PagoPlanilla.SelectedCells[1].Value.ToString();
                cbox_TipoTrabajo.Text = dgv_PagoPlanilla.SelectedCells[2].Value.ToString();
                txt_Especialidad.Text = dgv_PagoPlanilla.SelectedCells[3].Value.ToString();
                lbl_Sueldo.Text = sueldos.mtd_Salarios(cbox_TipoTrabajo.Text).ToString("C2");
                dtp_FechaAlta.Text = dgv_PagoPlanilla.SelectedCells[5].Value.ToString();
                cbox_Estado.Text = dgv_PagoPlanilla.SelectedCells[6].Value.ToString();
                txt_UsuarioAuditoria.Text = dgv_PagoPlanilla.SelectedCells[7].Value.ToString();
                

            } */
        }
        

        private void Mtd_MostrarCodigoEmpleados()
        {
            var CodigoEmpleados = conexion.mtd_ListaEmpleados();
            foreach (var Empleado in CodigoEmpleados)
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

        private void txt_HorasExtras_TextChanged(object sender, EventArgs e) { }

        private void mtd_VaciarEspacios()
        {
            cbox_CodigoEmpleado.SelectedIndex = -1;
            cbox_Estado.SelectedIndex = -1;
            dtp_FechaPago.Value = DateTime.Today;
            txt_HorasExtras.Clear();
            lbl_Sueldo.Text = "0.00";
            lbl_Bono.Text = "0.00";
            lbl_MontoTotal.Text = "0.00";
            cbox_Estado.SelectedIndex = -1;
            txt_UsuarioAuditoria.Clear();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            mtd_VaciarEspacios();
        }
    }
}
