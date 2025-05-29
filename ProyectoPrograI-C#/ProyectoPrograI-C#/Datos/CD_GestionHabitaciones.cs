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
        CD_Conexion1 conexion = new CD_Conexion1();
        public List<dynamic> mtd_ListaEmpleados()
        {
            List<dynamic> ListaEmpleados = new List<dynamic>();
            // Consulta modificada para obtener CodigoEmpleado y NombreEmpleado
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
        }
        public List<dynamic> mtd_ListaHabitaciones()
        {
            List<dynamic> ListaHabitaciones = new List<dynamic>();
            // Consulta modificada para obtener CodigoEmpleado y NombreEmpleado
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
        }
        public DataTable mtd_ConsultarGestiones()
        {
            string QueryConsultarGestiones = "Select * from tbl_GestionHabitaciones";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarGestiones, conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            conexion.MtdCerrarConexion();
            return Dt;
        }
    }
}
