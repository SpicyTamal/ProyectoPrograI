using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Datos
{
    internal class CD_GestionHabitaciones
    {
        CD_Conexion1 conexion = new CD_Conexion1(); //instancia de la clase de conexión a la base de datos
        public List<dynamic> mtd_ListaEmpleados()
        {
            List<dynamic> ListaEmpleados = new List<dynamic>();
            string QueryListaEmpleados = "SELECT CodigoEmpleado, Nombres FROM tbl_Empleados";
            SqlCommand cmd = new SqlCommand(QueryListaEmpleados, conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListaEmpleados.Add(new
                {
                    Value = reader["CodigoEmpleado"],
                    Text = $"{reader["CodigoEmpleado"]} - {reader["Nombres"]}"
                });
            }
            conexion.MtdCerrarConexion();
            return ListaEmpleados;
        } //se usa para llenar el combobox de codigoempleado - empleado en el formulario de gestion habitaciones
        
        public List<dynamic> mtd_ListaHabitaciones()
        {
            List<dynamic> ListaHabitaciones = new List<dynamic>();
            string QueryListaHabitaciones = "SELECT CodigoHabitacion, Ubicacion FROM tbl_Habitaciones";
            SqlCommand cmd = new SqlCommand(QueryListaHabitaciones, conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListaHabitaciones.Add(new
                {
                    Value = reader["CodigoHabitacion"],
                    Text = $"{reader["CodigoHabitacion"]} - {reader["Ubicacion"]}"
                });
            }
            conexion.MtdCerrarConexion();
            return ListaHabitaciones;
        } //se usa para llenar el combobox de codigohabitacion - habitacion en el formulario de gestion habitaciones de la base de datos
        
        public DataTable mtd_ConsultarGestiones()
        {
            string QueryConsultarGestiones = "Select * from tbl_GestionHabitaciones";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarGestiones, conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            conexion.MtdCerrarConexion();
            return Dt;
        } //se usa para llenar el datagridview del form de gestion habitaciones desde la base de datos

        public void mtd_AgregarGestion(int CodigoEmpleado, int CodigoHabitacion, string TipoGestion, string Estado, DateTime FechaGestion, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarGestion = "Insert into tbl_GestionHabitaciones(CodigoEmpleado,CodigoHabitacion, TipoGestion, Estado, FechaGestion, UsuarioAuditoria, FechaAuditoria) values (@CodigoEmpleado, @CodigoHabitacion, @TipoGestion, @Estado, @FechaGestion, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarGestion, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@TipoGestion", TipoGestion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaGestion", FechaGestion);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);    
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        } //aqui se crea una nueva gestion de habitaciones en la base de datos
        
        public void mtd_EliminarGestion(string CodigoGestion)
        {
            string QueryEliminarGestion = "Delete from tbl_GestionHabitaciones where CodigoGestion=@CodigoGestion";
            SqlCommand cmd = new SqlCommand(QueryEliminarGestion, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoGestion", CodigoGestion);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        } //elimina la gestion de habitaciones seleccionada de la base de datos
        
        public void mtd_ActualizarGestion(string CodigoGestion, int CodigoEmpleado, int CodigoHabitacion, string TipoGestion, string Estado, DateTime FechaGestion, String UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarEmpleados = "Update tbl_GestionHabitaciones set CodigoEmpleado=@CodigoEmpleado, CodigoHabitacion=@CodigoHabitacion, TipoGestion=@TipoGestion, Estado=@Estado, FechaGestion=@FechaGestion, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria where CodigoGestion=@CodigoGestion";
            SqlCommand cmd = new SqlCommand(QueryActualizarEmpleados, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoGestion", CodigoGestion);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@TipoGestion", TipoGestion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaGestion", FechaGestion);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        } //actualiza una gestion de habitaciones seleccionada en la base de datos con los datos enviados desde el formulario
    }
}
