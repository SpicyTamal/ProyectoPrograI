using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Datos
{
    class CD_Usuarios
    {
        CD_Conexion1 cd_conexion = new CD_Conexion1();

        public List<dynamic> mtd_Lista_Empleados()
        {
            List<dynamic> Lista_Empleados = new List<dynamic>();
            string QueryListaEmpleados = "Select CodigoEmpleado, Usuario from tbl_Empleados";
            SqlCommand cmd = new SqlCommand(QueryListaEmpleados, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Lista_Empleados.Add(new
                {
                    Value = reader["CodigoEmpleado"],
                    Text = $"{reader["CodigoEmpleado"]} - {reader["Usuario"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return Lista_Empleados;
        }

        public DataTable mtd_Consultar_Usuarios()
        {
            string QueryConsultarMedicamentos = "Select * from tbl_Usuarios";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarMedicamentos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void mtd_Agregar_Usuarios(int CodigoEmpleado, string Usuario, string Clave, string TipoUsuario, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregarMedicamentos = "Insert into tbl_Usuarios (Usuario,Clave,TipoUsuario, Estado, FechaAuditoria, UsuarioAuditoria) values (@Usuario, @Clave, @TipoUsuario, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarMedicamentos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            cmd.Parameters.AddWithValue("@TipoUsuario", TipoUsuario);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void mtd_Actualizar_Usuarios(int CodigoUsuario, int CodigoEmpleado, string Usuario, string Clave, string TipoUsuario, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizarMedicamentos = "Update tbl_Usuarios set CodigoEmpleado=@CidigoEmpleado, Usuario=@Usuario, Clave=@Clave, TipoUsuario=@TipoUsuario, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoUsuario=@CodigoUsuario";
            SqlCommand cmd = new SqlCommand(QueryActualizarMedicamentos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@TipoMedicamento", Clave);
            cmd.Parameters.AddWithValue("@TipoUsuario", TipoUsuario);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void mtd_Eliminar_Usuarios(int CodigoUsuario)
        {
            string QueryEliminarUsuarios = "Delete tbl_Usuarios where CodigoUsuario=@CodigoUsuario";
            SqlCommand cmd = new SqlCommand(QueryEliminarUsuarios, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
