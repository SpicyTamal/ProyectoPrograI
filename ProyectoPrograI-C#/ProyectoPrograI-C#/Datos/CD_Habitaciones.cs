using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoPrograI_C_.Datos
{
    internal class CD_Habitaciones
    {
        CD_Conexion1 CD_Conexion1 = new CD_Conexion1();

        public DataTable Mtd_ConsultarHabitaciones()
        {
            string QueryConsultaHabitaciones = "Select * from tbl_Habitaciones";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultaHabitaciones, CD_Conexion1.MtdAbrirConexion());
            DataTable DT = new DataTable();
            Adapter.Fill(DT);
            CD_Conexion1.MtdCerrarConexion();
            return DT;
        }

        public void Mtd_AgregarHabitaciones(string Numero, string Ubicacion, string TipoHabitacion, double Costo, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarHabitaciones = "insert into tbl_Habitaciones(Numero,Ubicacion,TipoHabitaciones,Costo,Estado,UsuarioAuditoria,FechaAuditoria) values (@Numero,@Ubicacion,@TipoHabitaciones,@Costo,@Estado,@UsuarioAuditoria,@FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarHabitaciones, CD_Conexion1.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@TipoHabitaciones", TipoHabitacion);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            CD_Conexion1.MtdCerrarConexion();
        }

        public void Mtd_ActualizarHabitaciones(int CodigoHabitacion, string Numero, string Ubicacion, string TipoHabitacion, double Costo, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarHabitaciones = "update tbl_Habitaciones set Numero=@Numero, Ubicacion=@Ubicacion, TipoHabitaciones=@TipoHabitaciones, Costo=@Costo, Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria where CodigoHabitacion=@CodigoHabitacion";

            SqlCommand cmd = new SqlCommand(QueryActualizarHabitaciones, CD_Conexion1.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@TipoHabitaciones", TipoHabitacion);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            CD_Conexion1.MtdCerrarConexion();
        }

        public void Mtd_EliminarHabitaciones(int CodigoHabitacion)
        {
            string QueryEliminarHabitacion = "Delete tbl_Habitaciones where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryEliminarHabitacion, CD_Conexion1.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.ExecuteNonQuery();
            CD_Conexion1.MtdCerrarConexion();
        }

    }
}
