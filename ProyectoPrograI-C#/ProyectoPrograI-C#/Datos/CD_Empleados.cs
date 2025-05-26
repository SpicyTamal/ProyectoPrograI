using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Datos
{
    internal class CD_Empleados
    {
        CD_Conexion1 cd_conexion = new CD_Conexion1();

        public DataTable mtd_ConsultarEmpleado() 
        {
            string QueryConsultarMedicamentos = "Select * from tbl_Empleados";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarMedicamentos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void mtd_Agregar_Medicamentos(string Nombre, string TipoTrabajo, double Sueldo,string Especialidad, DateTime FechaAlta, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregarEmpleado = "Insert into tbl_Empleados(Nombre,TipoMedicamento,Costo, Stock, FechaVencimiento, CodigoCategoria, CodigoProveedor, Estado, FechaAuditoria, UsuarioAuditoria) values (@Nombre, @TipoMedicamento, @Costo, @Stock, @FechaVencimiento, @CodigoCategoria, @CodigoProveedor, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarEmpleado, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombres", Nombre);
            cmd.Parameters.AddWithValue("@TipoTrabajo", TipoTrabajo);
            cmd.Parameters.AddWithValue("@Especialidad", Especialidad);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAlta);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void mtd_ActualizarEmpleados(string Nombre, string TipoTrabajo, double Sueldo, string Especialidad, DateTime FechaAlta, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizarEmpleados = "Update tbl_Empleados set Nombre=@Nombre, TipoTrabajo=@TipoTrabajo, Especialidad=@Especialidad, Sueldo=@Sueldo, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryActualizarEmpleados, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombres", Nombre);
            cmd.Parameters.AddWithValue("@TipoTrabajo", TipoTrabajo);
            cmd.Parameters.AddWithValue("@Especialidad", Especialidad);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAlta);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
