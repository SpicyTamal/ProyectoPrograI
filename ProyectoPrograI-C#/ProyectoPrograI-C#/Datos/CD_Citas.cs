using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Datos
{
    internal class CD_Citas
    {
        CD_Conexion1 conexion = new CD_Conexion1();

        public DataTable Mtd_ConsultarCitas()
        {
            string QueryConsultarCitas = "select * from tbl_Citas";
            SqlDataAdapter adapter = new SqlDataAdapter(QueryConsultarCitas, conexion.MtdAbrirConexion());
            DataTable DT = new DataTable();
            adapter.Fill(DT);
            conexion.MtdCerrarConexion();
            return DT;
        }

        public List<dynamic> Mtd_ListaCodigoPacientes()
        {
            List<dynamic> CodigoPacientes = new List<dynamic>();
            string QueryListaCodigoPacientes = "select CodigoPaciente, Nombres from tbl_Pacientes";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoPacientes, conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CodigoPacientes.Add(new
                {
                    Value = reader["CodigoPaciente"],
                    Text = $"{reader["CodigoPaciente"]} - {reader["Nombres"]}"
                });
            }

            conexion.MtdCerrarConexion();
            return CodigoPacientes;
        }

        public List<dynamic> Mtd_ListaCodigoEmpleado()
        {
            List<dynamic> CodigoEmpleado = new List<dynamic>();
            string QueryListaCodigoEmpleados = "select CodigoEmpleado, Nombres from tbl_Empleados";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoEmpleados, conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CodigoEmpleado.Add(new
                {
                    Value = reader["CodigoEmpleado"],
                    Text = $"{reader["CodigoEmpleado"]} - {reader["Nombres"]}"
                });
            }

            conexion.MtdCerrarConexion();
            return CodigoEmpleado;
        }

        public double Mtd_ConsultarCostoTratamiento(int CodigoCita)
        {
            double CostoTratamiento;
            string QueryConsultarCostoTratamiento = "Select Costo from tbl_Tratamiento where CodigoCita=@CodigoCita";
            SqlCommand cmd = new SqlCommand(QueryConsultarCostoTratamiento, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CostoTratamiento = double.Parse(reader["Costo"].ToString());
            }
            else
            {
                CostoTratamiento = 0;
            }

            conexion.MtdCerrarConexion();
            return CostoTratamiento;
        }

        public int Mtd_ConsultarCodigoHabitacion(int CodigoPaciente)
        {
            int CodigoHabitacion = 0;
            string QueryConsultarCostoHabitacion = "select CodigoHabitacion from tbl_Pacientes where CodigoPaciente=@CodigoPaciente";
            SqlCommand cmd = new SqlCommand(QueryConsultarCostoHabitacion, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPaciente", CodigoPaciente);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CodigoHabitacion = int.Parse(reader["CodigoHabitacion"].ToString());
            }
            else
            {
                CodigoHabitacion = 0;
            }

            conexion.MtdCerrarConexion();
            return CodigoHabitacion;
        }

        public double Mtd_CostoHabitacion(int CodigoHabitacion)
        {
            double CostoHabitacion = 0;
            string QueryConsultarCostoHabitacion = "select Costo from tbl_Habitaciones where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryConsultarCostoHabitacion, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                CostoHabitacion = double.Parse(reader["Costo"].ToString());
            }
            else
            {
                CostoHabitacion = 0;
            }
            return CostoHabitacion;
        }

        public void Mtd_AgregarCita(int CodigoPaciente, int CodigoEmpleado, DateTime FechaIngreso, DateTime FechaEgreso, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarCitas = "insert into tbl_Citas(CodigoPaciente,CodigoEmpleado,FechaIngreso,FechaEgreso,UsuarioAuditoria,FechaAuditoria) values (@CodigoPaciente, @CodigoEmpleado, @FechaIngreso, @FechaEgreso, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarCitas, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPaciente", CodigoPaciente);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            cmd.Parameters.AddWithValue("@FechaEgreso", FechaEgreso);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

        public void Mtd_ActualizarCitas(int CodigoCita, int CodigoPaciente, int CodigoEmpleado, DateTime FechaIngreso, DateTime FechaEgreso, double CostoTratamiento, double CostoHabitacion)
        {
            string QueryActualizarCitas = "update tbl_Citas set CodigoPaciente=@CodigoPaciente, CodigoEmpleado=@CodigoEmpleado, FechaIngreso=@FechaIngreso, FechaEgreso=@FechaEgreso, CostoTratamiento=@CostoTratamiento, CostoHabitacion=@CostoHabitacion where CodigoCita=@CodigoCita";
            SqlCommand cmd = new SqlCommand(QueryActualizarCitas, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("CodigoCita", CodigoCita);
            cmd.Parameters.AddWithValue("@CodigoPaciente", CodigoPaciente);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            cmd.Parameters.AddWithValue("@FechaEgreso", FechaEgreso);
            cmd.Parameters.AddWithValue("@CostoTratamiento", CostoTratamiento);
            cmd.Parameters.AddWithValue("@CostoHabitacion", CostoHabitacion);
            cmd.ExecuteNonQuery();
            conexion.MtdAbrirConexion();
        }

        public void Mtd_EliminarCita(int CodigoCita)
        {
            string QueryEliminarCita = "Delete tbl_Citas where CodigoCita=@CodigoCita";
            SqlCommand cmd = new SqlCommand(QueryEliminarCita, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }
    }
}
