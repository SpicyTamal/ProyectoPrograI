using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Datos
{
    class CD_Tratamientos
    {
        CD_Conexion1 cd_conexion = new CD_Conexion1();

        public List<dynamic> mtd_Lista_Citas()
        {
            List<dynamic> Lista_Citas = new List<dynamic>();
            string QueryListaCitas = "Select CodigoCita, FechaIngreso from tbl_Citas";
            SqlCommand cmd = new SqlCommand(QueryListaCitas, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Lista_Citas.Add(new
                {
                    Value = reader["CodigoCita"],
                    Text = $"{reader["CodigoCitas"]} - {reader["FechaIngreso"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return Lista_Citas;
        }

        public List<dynamic> mtd_Lista_Medicamentos()
        {
            List<dynamic> Lista_Medicamentos = new List<dynamic>();
            string QueryLista_Medicamentos = "Select CodigoMedicamento, Nombre from tbl_Medicamentos";
            SqlCommand cmd = new SqlCommand(QueryLista_Medicamentos, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Lista_Medicamentos.Add(new
                {
                    Value = reader["CodigoMedicamento"],
                    Text = $"{reader["CodigoMedicamento"]} - {reader["Nombre"]}"
                });
            }
            cd_conexion.MtdCerrarConexion();
            return Lista_Medicamentos;
        }

        public DataTable mtd_Consultar_Tratamientos()
        {
            string QueryConsultarTratamientos = "Select * from tbl_Tratamiento";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarTratamientos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void mtd_Agregar_Tratamientos(int CodigoCita, int CodigoMedicamento, double Costo, DateTime FechaTratamiento, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregarTratamientos = "Insert into tbl_Tratamientos(CodigoCita,CodigoMedicamento,Costo, FechaTratamiento, Estado, FechaAuditoria, UsuarioAuditoria) values (@CodigoCita, @CodigoMedicamento, @Costo, @Stock, @FechaTratamiento, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarTratamientos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@FechaTratamiento", FechaTratamiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void mtd_Actualizar_Tratamientos(int CodigoTratamiento, int CodigoCita, int CodigoMedicamento, double Costo, DateTime FechaTratamiento, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizarTratamientos = "Update tbl_Tratamientos set CodigoCita=@CodigoCita, CodigoMedicamento=@CodigoMedicamento, Costo=@Costo, FechaTratamiento=@FechaTratamiento, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoTratamiento=@CodigoTratamiento";
            SqlCommand cmd = new SqlCommand(QueryActualizarTratamientos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoTratamiento", CodigoTratamiento);
            cmd.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            cmd.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@FechaTratamiento", FechaTratamiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void mtd_Eliminar_Tratamientos(int CodigoTratamiento)
        {
            string QueryEliminarTratamientos = "Delete tbl_Tratamientos where CodigoTratamiento=@CodigoTratamiento";
            SqlCommand cmd = new SqlCommand(QueryEliminarTratamientos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoTratamiento", CodigoTratamiento);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();

        }
    }
}
