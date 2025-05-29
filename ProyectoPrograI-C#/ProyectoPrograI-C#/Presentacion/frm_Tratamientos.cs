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
using ProyectoPrograI_C_.Datos;
using ProyectoPrograI_C_.Logica;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_Tratamientos : Form
    {
        CD_Tratamientos cd_tratamientos = new CD_Tratamientos();
        CL_Tratamientos cl_tratamientos = new CL_Tratamientos();

        public frm_Tratamientos()
        {
            InitializeComponent();
        }

        //METODOS Y LOGICA DEL FORM

        private void cbx_foreign_Codigo_Medicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            var medicamentoSeleccionado = (dynamic)cbx_foreign_Codigo_Medicamento.SelectedItem;
            int codigoMedicamento = (int)medicamentoSeleccionado.Value;
            txt_Costo.Text = cl_tratamientos.mtd_Costo_Medicamento(codigoMedicamento).ToString();
        }

        private void frm_Tratamientos_Load(object sender, EventArgs e)
        {
            mtd_Mostrar_Lista_Medicamentos();
            mtd_Mostrar_Lista_Citas();
            mtd_Consultar_Tratamientos();
        }

        private void mtd_Mostrar_Lista_Citas()
        {
            var ListaCitas = cd_tratamientos.mtd_Lista_Citas();

            foreach (var cita in ListaCitas)
            {
                cbx_foreign_Codigo_Cita.Items.Add(cita);
            }
            cbx_foreign_Codigo_Cita.DisplayMember = "Text";
            cbx_foreign_Codigo_Cita.ValueMember = "Value";
        }

        private void mtd_Mostrar_Lista_Medicamentos()
        {
            var ListaMedicamentos = cd_tratamientos.mtd_Lista_Medicamentos();

            foreach (var medicamento in ListaMedicamentos)
            {
                cbx_foreign_Codigo_Medicamento.Items.Add(medicamento);
            }

            cbx_foreign_Codigo_Medicamento.DisplayMember = "Text";
            cbx_foreign_Codigo_Medicamento.ValueMember = "Value";
        }

        private void mtd_Consultar_Tratamientos()
        {
            DataTable Dt = cd_tratamientos.mtd_Consultar_Tratamientos();
            dgv_Tratamientos.DataSource = Dt;
        }

        private void mtd_Limpiar_Campos()
        {
            txt_Codigo_Tratamiento.Text = "";
            cbx_foreign_Codigo_Cita.Text = "";
            cbx_foreign_Codigo_Medicamento.Text = "";
            txt_Costo.Text = "";
            dtp_Fecha_Vencimiento_Tratamientos.Text = "";
            cbx_Estado_Tratamientos.Text = "";
            txt_Usuario_Auditoria.Text = "";
            txt_Fecha_Auditoria.Text = "";
        }

        private void dgv_Tratamientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgv_Tratamientos.SelectedRows[0];

            if (FilaSeleccionada.Index == dgv_Tratamientos.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_Codigo_Tratamiento.Text = dgv_Tratamientos.SelectedCells[0].Value.ToString();
                int CodigoCita = (int)dgv_Tratamientos.SelectedCells[1].Value;
                foreach (var codigoci in cbx_foreign_Codigo_Cita.Items)
                {
                    if (((dynamic)codigoci).Value == CodigoCita)
                    {
                        cbx_foreign_Codigo_Cita.SelectedItem = codigoci;
                        break;
                    }
                }
                int CodigoMedicamento = (int)dgv_Tratamientos.SelectedCells[2].Value;
                foreach(var codigomed in cbx_foreign_Codigo_Medicamento.Items)
                {
                    if (((dynamic)codigomed).Value == CodigoMedicamento)
                    {
                        cbx_foreign_Codigo_Medicamento.SelectedItem = codigomed;
                        break;
                    }
                }
                txt_Costo.Text = dgv_Tratamientos.SelectedCells[3].Value.ToString();
                dtp_Fecha_Vencimiento_Tratamientos.Text = dgv_Tratamientos.SelectedCells[4].Value.ToString();
                cbx_Estado_Tratamientos.Text = dgv_Tratamientos.SelectedCells[5].Value.ToString();
                txt_Usuario_Auditoria.Text = dgv_Tratamientos.SelectedCells[6].Value.ToString();
                txt_Fecha_Auditoria.Text = dgv_Tratamientos.SelectedCells[7].Value.ToString();
            }
        }

        //MOVIMIENTO DEL FORM

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void frm_Tratamientos_MouseDown(object sender, MouseEventArgs e)
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbx_foreign_Codigo_Cita.Text) || string.IsNullOrEmpty(cbx_foreign_Codigo_Medicamento.Text) || string.IsNullOrEmpty(txt_Costo.Text) ||
                string.IsNullOrEmpty(dtp_Fecha_Vencimiento_Tratamientos.Text) || string.IsNullOrEmpty(cbx_Estado_Tratamientos.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoCita = (int)((dynamic)cbx_foreign_Codigo_Cita.SelectedItem).Value;
                    int CodigoMedicamento = (int)((dynamic)cbx_foreign_Codigo_Medicamento.SelectedItem).Value;
                    double Costo = cl_tratamientos.mtd_Costo_Medicamento(CodigoMedicamento);
                    DateTime FechaVencimiento = dtp_Fecha_Vencimiento_Tratamientos.Value;
                    string Estado = cbx_Estado_Tratamientos.Text;
                    DateTime FechaAuditoria = cl_tratamientos.mtd_Fecha_De_Hoy();
                    string UsuarioAuditoria = "Kevin_Monterroso";

                    cd_tratamientos.mtd_Agregar_Tratamientos(CodigoCita, CodigoMedicamento, Costo, FechaVencimiento, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Tratamiento agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_Consultar_Tratamientos();
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
            if (string.IsNullOrEmpty(cbx_foreign_Codigo_Cita.Text) || string.IsNullOrEmpty(cbx_foreign_Codigo_Medicamento.Text) || string.IsNullOrEmpty(txt_Costo.Text) ||
                string.IsNullOrEmpty(dtp_Fecha_Vencimiento_Tratamientos.Text) || string.IsNullOrEmpty(cbx_Estado_Tratamientos.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoTratamiento = (int.Parse(txt_Codigo_Tratamiento.Text));
                    var CitaSeleccionada = (dynamic)cbx_foreign_Codigo_Cita.SelectedItem;
                    int CodigoCita = (int)CitaSeleccionada.Value;
                    var MedicamentoSeleccionado = (dynamic)cbx_foreign_Codigo_Medicamento.SelectedItem;
                    int CodigoMedicamento = (int)MedicamentoSeleccionado.Value;
                    double Costo = cl_tratamientos.mtd_Costo_Medicamento(CodigoMedicamento);
                    DateTime FechaVencimiento = dtp_Fecha_Vencimiento_Tratamientos.Value;
                    string Estado = cbx_Estado_Tratamientos.Text;
                    DateTime FechaAuditoria = cl_tratamientos.mtd_Fecha_De_Hoy();
                    string UsuarioAuditoria = "Kevin_Monterroso";

                    cd_tratamientos.mtd_Actualizar_Tratamientos(CodigoTratamiento, CodigoCita, CodigoMedicamento, Costo, FechaVencimiento, Estado, FechaAuditoria, UsuarioAuditoria); 
                    MessageBox.Show("Tratamiento actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_Consultar_Tratamientos();
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
            if (string.IsNullOrEmpty(txt_Codigo_Tratamiento.Text))
            {
                MessageBox.Show("Favor seleccionar tratamiento a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoTratamiento = (int.Parse(txt_Codigo_Tratamiento.Text));

                    cd_tratamientos.mtd_Eliminar_Tratamientos(CodigoTratamiento);
                    MessageBox.Show("Tratamiento eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_Consultar_Tratamientos();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbx_foreign_Codigo_Cita_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
