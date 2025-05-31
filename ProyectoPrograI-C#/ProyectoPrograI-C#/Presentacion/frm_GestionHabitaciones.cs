using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograI_C_.Datos;
using ProyectoPrograI_C_.Seguridad;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_GestionHabitaciones : Form
    {
        CD_GestionHabitaciones conexion = new CD_GestionHabitaciones(); //instancia de la clase conexion
        public frm_GestionHabitaciones()
        {
            InitializeComponent();
        }

        private void frm_GestionHabitaciones_Load(object sender, EventArgs e)
        {
            mtd_MostrarEmpleados();
            mtd_MostrarHabitaciones();
            mtd_ConsultarGestiones();
        } //cuando el formulario carga llama a los metodos que llenan los combobox y el datagridview
        
        private void mtd_MostrarEmpleados()
        {
            var CodigoEmpleados = conexion.mtd_ListaEmpleados();
            foreach (var Empleado in CodigoEmpleados)
            {
                cbox_CodigoEmpleado.Items.Add(Empleado);
            }
            cbox_CodigoEmpleado.DisplayMember = "Text";
            cbox_CodigoEmpleado.ValueMember = "Value";
        } //llena el combobox de codigoempleado - empleado con la tabla empleados de la base de datos 

        private void mtd_MostrarHabitaciones()
        {
            var CodigoHabitaciones = conexion.mtd_ListaHabitaciones();
            foreach (var Habitacion in CodigoHabitaciones)
            {
                cbox_CodigoHabitacion.Items.Add(Habitacion);
            }
            cbox_CodigoHabitacion.DisplayMember = "Text";
            cbox_CodigoHabitacion.ValueMember = "Value";
        } //llena el combobox de habitacion - ubicacion habitacion con la tabla habitaciones de la base de datos

        private void mtd_ConsultarGestiones()
        {
            DataTable Dt = conexion.mtd_ConsultarGestiones();
            dgv_GestionHabitaciones.DataSource = Dt;
        } //llena el datagridview de con la tabla gestion habitaciones de la base de datos

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        } //cierra el formulario con el boton cerrar

        private void mtd_VaciarEspacios()
        {
            cbox_CodigoEmpleado.Text = "";
            cbox_CodigoHabitacion.Text = "";
            cbox_TipoGestion.Text = "";
            cbox_Estado.Text = "";
            dtp_FechaGestion.Value = DateTime.Today;
        } //limpia los espacios de texto y combobox   

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_CodigoEmpleado.Text) || string.IsNullOrEmpty(cbox_CodigoHabitacion.Text) || string.IsNullOrEmpty(cbox_TipoGestion.Text) || string.IsNullOrEmpty(cbox_Estado.Text))
            {
                MessageBox.Show("Por favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;
                    int CodigoHabitacion = (int)((dynamic)cbox_CodigoHabitacion.SelectedItem).Value;
                    string TipoGestion = cbox_TipoGestion.Text;
                    string Estado = cbox_Estado.Text;
                    DateTime FechaGestion = dtp_FechaGestion.Value.Date;
                    string UsuarioAuditoria = Cache_Usuario.Usuario;
                    DateTime FechaAuditoria = DateTime.Today.Date;
                    conexion.mtd_AgregarGestion(CodigoEmpleado, CodigoHabitacion, TipoGestion, Estado, FechaGestion, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Registro guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_ConsultarGestiones();
                    mtd_VaciarEspacios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } //agrega un nuevo registro a la tabla gestion habitaciones de la base de datos

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var FilaSeleccionada = dgv_GestionHabitaciones.SelectedRows[0];
            if (FilaSeleccionada.Index == dgv_GestionHabitaciones.RowCount - 1)
            {
                MessageBox.Show("Por favor seleccione el registro eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string CodigoGestion = dgv_GestionHabitaciones.SelectedCells[0].Value.ToString();
                    conexion.mtd_EliminarGestion(CodigoGestion);
                    MessageBox.Show("Registro eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_ConsultarGestiones();
                    mtd_VaciarEspacios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } //elimina el registro seleccionado de la tabla gestion habitaciones de la base de datos

        private void dgv_GestionHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgv_GestionHabitaciones.SelectedRows[0];

            if (FilaSeleccionada.Index == dgv_GestionHabitaciones.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cbox_CodigoEmpleado.Text = FilaSeleccionada.Cells[1].Value.ToString();
                string codigoTexto = cbox_CodigoEmpleado.Text;
                var item = cbox_CodigoEmpleado.Items.Cast<dynamic>().FirstOrDefault(x => x.Value.ToString() == codigoTexto);
                cbox_CodigoEmpleado.SelectedItem = item;
                cbox_CodigoHabitacion.Text = FilaSeleccionada.Cells[2].Value.ToString();
                string codigoTexto2 = cbox_CodigoHabitacion.Text;
                var item2 = cbox_CodigoHabitacion.Items.Cast<dynamic>().FirstOrDefault(x => x.Value.ToString() == codigoTexto2);
                cbox_CodigoHabitacion.SelectedItem = item2;
                cbox_TipoGestion.Text = FilaSeleccionada.Cells[3].Value.ToString();
                cbox_Estado.Text = FilaSeleccionada.Cells[5].Value.ToString();
                dtp_FechaGestion.Text = dgv_GestionHabitaciones.SelectedCells[4].Value.ToString();
            }
        } //llena los cambos de texto y combobox con los datos de la fila seleccionada del datagridview

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            mtd_VaciarEspacios();
        } //limpia los campos de texto y combobox con el boton cancelar

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_CodigoEmpleado.Text) || string.IsNullOrEmpty(cbox_CodigoHabitacion.Text) || string.IsNullOrEmpty(cbox_TipoGestion.Text) || string.IsNullOrEmpty(cbox_Estado.Text))
            {
                MessageBox.Show("Por favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string CodigoGestion = dgv_GestionHabitaciones.SelectedCells[0].Value.ToString();
                    int CodigoEmpleado = (int)((dynamic)cbox_CodigoEmpleado.SelectedItem).Value;
                    int CodigoHabitacion = (int)((dynamic)cbox_CodigoHabitacion.SelectedItem).Value;
                    string TipoGestion = cbox_TipoGestion.Text;
                    string Estado = cbox_Estado.Text;
                    DateTime FechaGestion = dtp_FechaGestion.Value.Date;
                    DateTime FechaAuditoria = DateTime.Today.Date;

                    conexion.mtd_ActualizarGestion(CodigoGestion, CodigoEmpleado, CodigoHabitacion, TipoGestion, Estado, FechaGestion, FechaAuditoria);
                    MessageBox.Show("Registro actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtd_ConsultarGestiones();
                    mtd_VaciarEspacios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } //actualiza el registro seleccionado en la tabla gestion habitacion con los datos ingresados
    }
}
