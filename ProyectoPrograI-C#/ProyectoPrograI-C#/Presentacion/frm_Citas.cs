using ProyectoPrograI_C_.Datos;
using ProyectoPrograI_C_.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_Citas : Form
    {
        CD_Citas conexion = new CD_Citas();
        CL_Citas logicaCitas = new CL_Citas();

        public frm_Citas()
        {
            InitializeComponent();
        }

        private void Mtd_ConsultarCitas()
        {
            DataTable dt = conexion.Mtd_ConsultarCitas();
            dgv_Citas.DataSource = dt;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mtd_MostrarCodigoPacientes()
        {
            var CodigoPacientes = conexion.Mtd_ListaCodigoPacientes();

            foreach (var Pacientes in CodigoPacientes)
            {
                cbox_CodigoPacientes.Items.Add(Pacientes);
            }

            cbox_CodigoPacientes.DisplayMember = "Text";
            cbox_CodigoPacientes.ValueMember = "Value";
        }

        private void Mtd_MostrarCodigoEmpleado()
        {
            var CodigoEmpleado = conexion.Mtd_ListaCodigoEmpleado();

            foreach (var Empleados in CodigoEmpleado)
            {
                cbox_CodigoEmpleado.Items.Add(Empleados);
            }

            cbox_CodigoEmpleado.DisplayMember = "Text";
            cbox_CodigoEmpleado.ValueMember = "Value";
        }

        private void frm_Citas_Load(object sender, EventArgs e)
        {
            Mtd_ConsultarCitas();
            Mtd_MostrarCodigoPacientes();
            Mtd_MostrarCodigoEmpleado();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_CodigoPacientes.Text) || string.IsNullOrEmpty(cbox_CodigoEmpleado.Text) || string.IsNullOrEmpty(dt_FechaIngreso.Text) || string.IsNullOrEmpty(dt_FechaEgreso.Text))
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoPaciente = (int)((dynamic)cbox_CodigoPacientes.SelectedItem).Value;
                    int CodigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;
                    DateTime FechaIngreso = dt_FechaIngreso.Value;
                    DateTime FechaEgreso = dt_FechaEgreso.Value;
                    string UsuarioAuditoria = "Dylan";
                    DateTime FechaAuditoria = logicaCitas.Mtd_FechaHoy();


                    conexion.Mtd_AgregarCita(CodigoPaciente, CodigoEmpleado, FechaIngreso, FechaEgreso, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Cita Agregada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtd_ConsultarCitas();
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
            cbox_CodigoEmpleado.Text = "";
            cbox_CodigoPacientes.Text = "";
            dt_FechaIngreso.Text = "";
            dt_FechaEgreso.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_Citas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectFila = dgv_Citas.SelectedRows[0];

            if(SelectFila.Index == dgv_Citas.RowCount -1)
            {
                MessageBox.Show("Debe Seleccionar una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_CodigoCita.Text = dgv_Citas.SelectedCells[0].Value.ToString();
                cbox_CodigoPacientes.Text = dgv_Citas.SelectedCells[1].Value.ToString();
                cbox_CodigoEmpleado.Text = dgv_Citas.SelectedCells[2].Value.ToString();
                dt_FechaIngreso.Text = dgv_Citas.SelectedCells[3].Value.ToString();
                dt_FechaEgreso.Text = dgv_Citas.SelectedCells[4].Value.ToString();
                lbl_CostoTratamiento.Text = dgv_Citas.SelectedCells[5].Value.ToString();
                lbl_CostoHabitacion.Text = dgv_Citas.SelectedCells[6].Value.ToString();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_CodigoPacientes.Text) || string.IsNullOrEmpty(cbox_CodigoEmpleado.Text) || string.IsNullOrEmpty(dt_FechaIngreso.Text) || string.IsNullOrEmpty(dt_FechaEgreso.Text))
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoCitas = int.Parse(txt_CodigoCita.Text);
                    int CodigoPaciente = (int)((dynamic)cbox_CodigoPacientes.SelectedItem).Value;
                    int CodigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;
                    DateTime FechaIngreso = dt_FechaIngreso.Value;
                    DateTime FechaEgreso = dt_FechaEgreso.Value;
                    double CostoTratamiento = logicaCitas.Mtd_CostoTratamiento(CodigoCitas);
                    double CostoHabitacion = logicaCitas.Mtd_CostoHabitacion(CodigoPaciente);

                    conexion.Mtd_ActualizarCitas(CodigoCitas, CodigoPaciente, CodigoEmpleado, FechaIngreso, FechaEgreso, CostoTratamiento, CostoHabitacion);
                    MessageBox.Show("Cita Actualizada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mtd_ConsultarCitas();
                    Mtd_LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aqui esta el error "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Mtd_LimpiarCampos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CodigoCita.Text))
            {
                MessageBox.Show("Favor ingrese todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoCita = int.Parse(txt_CodigoCita.Text);

                conexion.Mtd_EliminarCita(CodigoCita);
                MessageBox.Show("Cita Eliminada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mtd_ConsultarCitas();
                Mtd_LimpiarCampos();
            }
        }
    }
}
