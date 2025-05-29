using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Datos
{
    class CD_Medicamentos
    {
        CD_Conexion1 cd_conexion = new CD_Conexion1();

        public DataTable mtd_Consultar_Medicamentos()
        {
            string QueryConsultarMedicamentos = "Select * from tbl_Medicamentos";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarMedicamentos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void mtd_Agregar_Medicamentos(string Nombre, string TipoMedicamento, double Costo, double Stock, DateTime FechaVencimiento, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregarMedicamentos = "Insert into tbl_Medicamentos(Nombre,TipoMedicamento,Costo, Stock, FechaVencimiento, Estado, FechaAuditoria, UsuarioAuditoria) values (@Nombre, @TipoMedicamento, @Costo, @Stock, @FechaVencimiento, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarMedicamentos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@TipoMedicamento", TipoMedicamento);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void mtd_Actualizar_Medicamentos(int CodigoMedicamento, string Nombre, string TipoMedicamento, double Costo, double Stock, DateTime FechaVencimiento, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizarMedicamentos = "Update tbl_Medicamentos set Nombre=@Nombre, TipoMedicamento=@TipoMedicamento, Costo=@Costo, Stock=@Stock, FechaVencimiento=@FechaVencimiento, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoMedicamento=@CodigoMedicamento";
            SqlCommand cmd = new SqlCommand(QueryActualizarMedicamentos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@TipoMedicamento", TipoMedicamento);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void mtd_Eliminar_Medicamentos(int CodigoMedicamento)
        {
            string QueryEliminarMedicamentos = "Delete tbl_Medicamentos where CodigoMedicamento=@CodigoMedicamento";
            SqlCommand cmd = new SqlCommand(QueryEliminarMedicamentos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}

