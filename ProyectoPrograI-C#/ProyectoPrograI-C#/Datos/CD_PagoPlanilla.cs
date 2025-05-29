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
    internal class CD_PagoPlanilla
    {
        CD_Conexion1 conexion = new CD_Conexion1();
        //metodo para llenar el cbox de codigo empleado
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

        public double mtd_ConsultarSalario(int CodigoEmpleado)
        {
            double Salario = 0;

            string QueryConsultarSueldoEmpleado = "Select Sueldo from tbl_Empleados where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand CommandSueldo = new SqlCommand(QueryConsultarSueldoEmpleado, conexion.MtdAbrirConexion());
            CommandSueldo.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            SqlDataReader reader = CommandSueldo.ExecuteReader();

            if (reader.Read())
            {
                Salario = double.Parse(reader["Sueldo"].ToString());
            }
            else
            {
                Salario = 0;
            }

            conexion.MtdCerrarConexion();
            return Salario;
        }

        public double mtd_ConsultarBono(int CodigoEmpleado)
        {
            return mtd_ConsultarSalario(CodigoEmpleado) * 0.12;
        }

        public double mtd_ConsultarMontoTotal(int CodigoEmpleado, string HorasExtras)
        {
            HorasExtras = string.IsNullOrEmpty(HorasExtras) ? "0" : HorasExtras; 
            int horas = int.Parse(HorasExtras);
            double sueldo = mtd_ConsultarSalario(CodigoEmpleado);
            double bono = mtd_ConsultarBono(CodigoEmpleado);
            return sueldo + bono + (horas * 20);
        }

        public DataTable mtd_ConsultarPagos()
        {
            string QueryConsultarEmpleados = "Select * from tbl_PagoEmpleados";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarEmpleados, conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            conexion.MtdCerrarConexion();
            return Dt;
        }
       
        public void mtd_AgregarPago(int CodigoEmpleado, DateTime FechaPago, double Sueldo, double Bono, double MontoHorasExtras, double TotalMonto, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarEmpleado = "Insert into tbl_PagoEmpleados(CodigoEmpleado,FechaPago, Sueldo, Bono, MontoHorasExtra, TotalMonto, Estado, UsuarioAuditoria, FechaAuditora) values (@CodigoEmpleado, @FechaPago, @Sueldo, @Bono, @MontoHorasExtras, @TotalMonto, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarEmpleado, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@Bono", Bono);
            cmd.Parameters.AddWithValue("@MontoHorasExtras", MontoHorasExtras);
            cmd.Parameters.AddWithValue("@TotalMonto", TotalMonto);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

        public void mtd_ActualizarPago(string CodigoEmpleado, string Nombre, string TipoTrabajo, double Sueldo, string Especialidad, DateTime FechaAlta, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizarEmpleados = "Update tbl_Empleados set Nombres=@Nombres, TipoTrabajo=@TipoTrabajo, Especialidad=@Especialidad, Sueldo=@Sueldo, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoEmpleado=@CodigoEmpleado";

            SqlCommand cmd = new SqlCommand(QueryActualizarEmpleados, conexion.MtdAbrirConexion());
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
            conexion.MtdCerrarConexion();
        }

        public void mtd_EliminarPago(string CodigoEmpleado)
        {
            string QueryEliminarEmpleado = "Delete from tbl_Empleados where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryEliminarEmpleado, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }
        

    }
}
