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
    public partial class frm_PagoCitas : Form
    {
        CD_PagoCitas conexion = new CD_PagoCitas();
        CL_PagoCitas logicaPagoCitas = new CL_PagoCitas();
        
        public frm_PagoCitas()
        {
            InitializeComponent();
        }

        private void frm_PagoCitas_Load(object sender, EventArgs e)
        {
            Mtd_ConsultarPagoCitas();
            Mtd_MostrarCodigoCita();
        }

        public void Mtd_ConsultarPagoCitas()
        {
            DataTable dt = conexion.Mtd_ConsultarPagoCitas();
            dgv_PagoCitas.DataSource = dt;
        }

        private void Mtd_MostrarCodigoCita()
        {
            var CodigoCita = conexion.Mtd_ConsultarCodigoCita();

            foreach (var citas in CodigoCita)
            {
                cbox_CodigoCita.Items.Add(citas);
            }

            cbox_CodigoCita.DisplayMember = "Text";
            cbox_CodigoCita.ValueMember = "Value";
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Mtd_LimpiarCampos()
        {
            txt_CodigoPagoCita.Text = "";
            cbox_CodigoCita.Text = "";
            lbl_MontoCita.Text = "";
            lbl_Impuestos.Text = "";
            lbl_Descuento.Text = "";
            lbl_TotalPago.Text = "";
            dt_FechaPago.Text = "";
            cbox_TipoPago.Text = "";
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_CodigoCita.Text))
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoCita = (int)((dynamic)cbox_CodigoCita.SelectedItem).Value;
                    double MontoCita = logicaPagoCitas.Mtd_MontoCita(CodigoCita);
                    double Impuestos = logicaPagoCitas.Mtd_Impuestos(MontoCita);
                    double Descuento = logicaPagoCitas.Mtd_Descuento(MontoCita);
                    double TotalPago = logicaPagoCitas.Mtd_TotalPago(MontoCita, Impuestos, Descuento);
                    DateTime FechaPago = dt_FechaPago.Value;
                    string TipoPago = cbox_TipoPago.Text;
                    string UsuarioAuditoria = "Dylan";
                    DateTime FechaAuditoria = DateTime.Now;

                    conexion.Mtd_AgregarPagoCitas(CodigoCita, MontoCita, Impuestos, Descuento, TotalPago, FechaPago, TipoPago, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Pago Cita Agregada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtd_ConsultarPagoCitas();
                    Mtd_LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_PagoCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaSelect = dgv_PagoCitas.SelectedRows[0];

            if (filaSelect.Index == dgv_PagoCitas.RowCount -1)
            {
                MessageBox.Show("Debe Seleccionar una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_CodigoPagoCita.Text = dgv_PagoCitas.SelectedCells[0].Value.ToString();
                cbox_CodigoCita.Text = dgv_PagoCitas.SelectedCells[1].Value.ToString();
                lbl_MontoCita.Text = dgv_PagoCitas.SelectedCells[2].Value.ToString();
                lbl_Impuestos.Text = dgv_PagoCitas.SelectedCells[3].Value.ToString();
                lbl_Descuento.Text = dgv_PagoCitas.SelectedCells[4].Value.ToString();
                lbl_TotalPago.Text = dgv_PagoCitas.SelectedCells[5].Value.ToString();
                dt_FechaPago.Text = dgv_PagoCitas.SelectedCells[6].Value.ToString();
                cbox_TipoPago.Text = dgv_PagoCitas.SelectedCells[7].Value.ToString();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_CodigoCita.Text) || string.IsNullOrEmpty(txt_CodigoPagoCita.Text))
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoPagoCitas = int.Parse(txt_CodigoPagoCita.Text);
                    int CodigoCita = (int)((dynamic)cbox_CodigoCita.SelectedItem).Value;
                    double MontoCita = logicaPagoCitas.Mtd_MontoCita(CodigoCita);
                    double Impuestos = logicaPagoCitas.Mtd_Impuestos(MontoCita);
                    double Descuento = logicaPagoCitas.Mtd_Descuento(MontoCita);
                    double TotalPago = logicaPagoCitas.Mtd_TotalPago(MontoCita, Impuestos, Descuento);
                    DateTime FechaPago = dt_FechaPago.Value;
                    string TipoPago = cbox_TipoPago.Text;

                    conexion.Mtd_ActualizarPagoCitas(CodigoPagoCitas, CodigoCita, MontoCita, Impuestos, Descuento, TotalPago, FechaPago, TipoPago);
                    MessageBox.Show("Pago Cita Actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtd_ConsultarPagoCitas();
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

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_CodigoCita.Text) || string.IsNullOrEmpty(txt_CodigoPagoCita.Text))
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoPagoCitas = int.Parse(txt_CodigoPagoCita.Text);

                    conexion.Mtd_EliminarPagoCita(CodigoPagoCitas);
                    MessageBox.Show("Pago Cita Eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtd_ConsultarPagoCitas();
                    Mtd_LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbox_CodigoCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CodigoCita = (int)((dynamic)cbox_CodigoCita.SelectedItem).Value;
            double MontoCita = logicaPagoCitas.Mtd_MontoCita(CodigoCita);
            double Impuestos = logicaPagoCitas.Mtd_Impuestos(MontoCita);
            double Descuento = logicaPagoCitas.Mtd_Descuento(MontoCita);
            double TotalPago = logicaPagoCitas.Mtd_TotalPago(MontoCita, Impuestos, Descuento);

            lbl_MontoCita.Text = MontoCita.ToString();
            lbl_Impuestos.Text = Impuestos.ToString();
            lbl_Descuento.Text = Descuento.ToString();
            lbl_TotalPago.Text = TotalPago.ToString();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void frm_PagoCitas_MouseDown_1(object sender, MouseEventArgs e)
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
