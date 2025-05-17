using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoPrograI_C_.Logica;
using ProyectoPrograI_C_.Datos;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_Medicamentos: Form
    {
        CD_Medicamentos cd_medicamentos = new CD_Medicamentos();
        CL_Medicamentos cl_medicamentos = new CL_Medicamentos();

        public frm_Medicamentos()
        {
            InitializeComponent();
        }

        //METODOS Y LOGICA DEL FORM

        public void cbx_Tipo_Medicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbx_Tipo_Medicamento.Text))
            {
                MessageBox.Show("Seleccione una descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_Costo_Medicamentos.Text = cl_medicamentos.mtd_Costo_Medicamentos(cbx_Tipo_Medicamento.Text).ToString("c");
            }
        }

        private void mtd_Consultar_Medicamentos()
        { 
            DataTable Dt = cd_medicamentos.mtd_Consultar_Medicamentos();
            dgv_Medicamentos.DataSource = Dt;
        }

        private void frm_Medicamentos_Load(object sender, EventArgs e)
        {
            //Posiblemente coloque un label fecha aqui
            mtd_Consultar_Medicamentos();
        }

        private void mtd_Limpiar_Campos()
        {
            cbx_Tipo_Medicamento.Text = "";
            txt_Costo_Medicamentos.Text = "";
            dtp_Fecha_Vencimiento_Medicamentos.Text = "";
            cbx_Estado_Medicamentos.Text = "";
        }
        /*
        private void dgv_Medicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgv_Medicamentos.SelectedRows[0];

            if (FilaSeleccionada.Index == dgv_Medicamentos.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoMedicamento.Text = dgv_Medicamentos.SelectedCells[0].Value.ToString();
                cboxDecbxscripcion.Text = dgv_Medicamentos.SelectedCells[1].Value.ToString();
                cboxUnidadMedida.Text = dgv_Medicamentos.SelectedCells[2].Value.ToString();
                txtPrecio.Text = dgv_Medicamentos.SelectedCells[3].Value.ToString();
                txtStock.Text = dgv_Medicamentos.SelectedCells[4].Value.ToString();
                DtpFechaVencimiento.Text = dgv_Medicamentos.SelectedCells[5].Value.ToString();

                //cboxCodigoCategoria.Text = dgv_Medicamentos.SelectedCells[6].Value.ToString();
                int CodigoCategoria = (int)dgv_Medicamentos.SelectedCells[6].Value;
                foreach (var codigoCat in cboxCodigoCategoria.Items)
                {
                    if (((dynamic)codigoCat).Value == CodigoCategoria)
                    {
                        cboxCodigoCategoria.SelectedItem = codigoCat;
                        //break;
                    }
                }

                //cboxCodigoProveedor.Text = dgv_Medicamentos.SelectedCells[7].Value.ToString();
                int CodigoProveedor = (int)dgv_Medicamentos.SelectedCells[7].Value;
                foreach (var codigoProv in cboxCodigoProveedor.Items)
                {
                    if (((dynamic)codigoProv).Value == CodigoProveedor)
                    {
                        cboxCodigoProveedor.SelectedItem = codigoProv;
                        //break;
                    }
                }

                cboxEstado.Text = dgv_Medicamentos.SelectedCells[8].Value.ToString();

            }
        }
        */

        //MOVIMIENTO DEL FORM

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void frm_Medicamentos_MouseDown(object sender, MouseEventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbx_Tipo_Medicamento.Text) || string.IsNullOrEmpty(txt_Costo_Medicamentos.Text) ||
                string.IsNullOrEmpty(dtp_Fecha_Vencimiento_Medicamentos.Text)|| string.IsNullOrEmpty(cbx_Estado_Medicamentos.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Nombre = cbx_Tipo_Medicamento.Text;
                    string Tipo_Medicamento = cbx_Tipo_Medicamento.Text;
                    double Costo = cl_medicamentos.mtd_Costo_Medicamentos(Tipo_Medicamento);
                    double Stock = 10; //double.Parse(txtStock.Text);
                    DateTime FechaVencimiento = dtp_Fecha_Vencimiento_Medicamentos.Value;
                    string Estado = cbx_Estado_Medicamentos.Text;
                    DateTime FechaAuditoria = cl_medicamentos.mtd_Fecha_De_Hoy();
                    string UsuarioAuditoria = "Kevin_Monterroso";

                    cd_medicamentos.mtd_Agregar_Medicamentos(Nombre, Tipo_Medicamento, Costo, Stock, FechaVencimiento, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Medicamento agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_Consultar_Medicamentos();
                    mtd_Limpiar_Campos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //OTROS

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
