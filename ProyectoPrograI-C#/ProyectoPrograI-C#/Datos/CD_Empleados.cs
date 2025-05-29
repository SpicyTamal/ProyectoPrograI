using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograI_C_.Logica;

namespace ProyectoPrograI_C_.Datos
{
    internal class CD_Empleados
    {
        CD_Conexion1 cd_conexion = new CD_Conexion1();

        public DataTable mtd_ConsultarEmpleados() 
        {
            string QueryConsultarEmpleados = "Select * from tbl_Empleados";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarEmpleados, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void mtd_AgregarEmpleado(string Nombre, string TipoTrabajo, double Sueldo,string Especialidad, DateTime FechaAlta, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregarEmpleado = "Insert into tbl_Empleados(Nombres,TipoTrabajo, Especialidad, Sueldo, FechaAlta, Estado, FechaAuditoria, UsuarioAuditoria) values (@Nombres, @TipoTrabajo, @Especialidad, @Sueldo, @FechaAlta, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarEmpleado, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombres", Nombre);
            cmd.Parameters.AddWithValue("@TipoTrabajo", TipoTrabajo);
            cmd.Parameters.AddWithValue("@Especialidad", Especialidad);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@FechaAlta", FechaAlta);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        
        public void mtd_ActualizarEmpleado(string CodigoEmpleado, string Nombre, string TipoTrabajo, double Sueldo, string Especialidad, DateTime FechaAlta, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizarEmpleados = "Update tbl_Empleados set Nombres=@Nombres, TipoTrabajo=@TipoTrabajo, Especialidad=@Especialidad, Sueldo=@Sueldo, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoEmpleado=@CodigoEmpleado";
            
            SqlCommand cmd = new SqlCommand(QueryActualizarEmpleados, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@Nombres", Nombre);
            cmd.Parameters.AddWithValue("@TipoTrabajo", TipoTrabajo);
            cmd.Parameters.AddWithValue("@Especialidad", Especialidad);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@FechaAlta", FechaAlta);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void mtd_EliminarEmpleado(string CodigoEmpleado)
        {
            string QueryEliminarEmpleado = "Delete from tbl_Empleados where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryEliminarEmpleado, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
