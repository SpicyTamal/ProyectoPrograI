using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ProyectoPrograI_C_.Datos
{
    internal class CD_Pacientes
    {

        CD_Conexion1 conexion = new CD_Conexion1();

        public DataTable Mtd_ConsultarPacientes()
        {
            string QueryConsultarPacietnes = "SELECT * FROM tbl_Pacientes";
            SqlDataAdapter adapter = new SqlDataAdapter(QueryConsultarPacietnes, conexion.MtdAbrirConexion());
            DataTable dt  = new DataTable();
            adapter.Fill(dt);
            conexion.MtdCerrarConexion();
            return dt;
        }

        public List<dynamic> Mtd_ListaCodigoHabitacion()
        {
            List<dynamic> CodigoHabitacion = new List<dynamic>();
            string QueryListaCodigoHabitacion = "select CodigoHabitacion, Numero, Ubicacion, TipoHabitaciones from tbl_Habitaciones";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoHabitacion, conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CodigoHabitacion.Add(new
                {
                    Value = reader["CodigoHabitacion"],
                    Text = $"{reader["CodigoHabitacion"]} - {reader["Numero"]} - {reader["Ubicacion"]} - {reader["TipoHabitaciones"]}"
                });
            }

            conexion.MtdCerrarConexion();
            return CodigoHabitacion;
        }

        public void Mtd_AgregarPacientes(int CodigoHabitacion, string Nombre, string Nit, DateTime FechaN, string TipoPaciente, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarPacientes = "insert into tbl_Pacientes(CodigoHabitacion,Nombres,Nit,FechaNacimiento,TipoPaciente,Estado,UsuarioAuditoria,FechaAuditoria) values (@CodigoHabitacion, @Nombre, @Nit, @FechaNacimiento, @TipoPaciente, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarPacientes, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Nit", Nit);
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaN);
            cmd.Parameters.AddWithValue("@TipoPaciente", TipoPaciente);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

        public void Mtd_ActualizarPacientes(int CodigoPaciente, int CodigoHabitacion, string Nombre, string Nit, DateTime FechaN, string TipoPaciente, string Estado)
        {
            string QueryActualizarPacietnes = "update tbl_Pacientes set CodigoHabitacion=@CodigoHabitacion, Nombres=@Nombre, Nit=@Nit, FechaNacimiento=@FechaNacimiento, TipoPaciente=@TipoPaciente, Estado=@Estado where CodigoPaciente=@CodigoPaciente";
            SqlCommand cmd = new SqlCommand(QueryActualizarPacietnes, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPaciente", CodigoPaciente);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Nit", Nit);
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaN);
            cmd.Parameters.AddWithValue("@TipoPaciente", TipoPaciente);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

        public void Mtd_EliminarPacientes(int CodigoPaciente)
        {
            string QueryEliminarPacientes = "Delete tbl_Pacientes where CodigoPaciente=@CodigoPaciente";
            SqlCommand cmd = new SqlCommand(QueryEliminarPacientes, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPaciente", CodigoPaciente);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }
    }
}
