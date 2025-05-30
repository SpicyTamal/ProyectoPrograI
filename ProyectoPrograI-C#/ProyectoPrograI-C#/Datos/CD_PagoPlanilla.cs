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
        CD_Conexion1 conexion = new CD_Conexion1(); //instancia de la clase conexion
       
        public List<dynamic> mtd_ListaEmpleados()
        {
            List<dynamic> ListaEmpleados = new List<dynamic>();
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
        } //devuelve una lista de empleados con su codigo y nombre correspondientes

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
        } //devuelve el salario del empleado segun el codigo de empleado proporcionado

        public double mtd_ConsultarBono(int CodigoEmpleado)
        {
            return mtd_ConsultarSalario(CodigoEmpleado) * 0.12;
        } //devuelve el bono del empleado correspondiente al 12% de su salario

        public double mtd_ConsultarMontoTotal(int CodigoEmpleado, string HorasExtras)
        {
            HorasExtras = string.IsNullOrEmpty(HorasExtras) ? "0" : HorasExtras; 
            int horas = int.Parse(HorasExtras);
            double sueldo = mtd_ConsultarSalario(CodigoEmpleado);
            double bono = mtd_ConsultarBono(CodigoEmpleado);
            return sueldo + bono + (horas * 20);
        } //devuelve el monto total que se le pagará al empleado a partir de bonos, salario y horas extras

        public DataTable mtd_ConsultarPagos()
        {
            string QueryConsultarEmpleados = "Select * from tbl_PagoEmpleados";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarEmpleados, conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            conexion.MtdCerrarConexion();
            return Dt;
        } //devuelve una tabla de pago empleados de la base de datos para un datagridview

        public void mtd_AgregarPago(int CodigoEmpleado, DateTime FechaPago, double Sueldo, double Bono, double MontoHorasExtras, double TotalMonto, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria, int HorasExtras)
        {
            string QueryAgregarPago = "Insert into tbl_PagoEmpleados(CodigoEmpleado,FechaPago, Sueldo, Bono, MontoHorasExtra, TotalMonto, Estado, UsuarioAuditoria, FechaAuditora, HorasExtras) values (@CodigoEmpleado, @FechaPago, @Sueldo, @Bono, @MontoHorasExtras, @TotalMonto, @Estado, @UsuarioAuditoria, @FechaAuditoria, @HorasExtras)";
            SqlCommand cmd = new SqlCommand(QueryAgregarPago, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@Bono", Bono);
            cmd.Parameters.AddWithValue("@MontoHorasExtras", MontoHorasExtras);
            cmd.Parameters.AddWithValue("@TotalMonto", TotalMonto);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@HorasExtras", HorasExtras);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        } //agrega un pago a la base de datos con los datos proporcionados por el usuario

        public void mtd_ActualizarPago(string CodigoPago, int CodigoEmpleado, DateTime FechaPago, double Sueldo, double Bono, double MontoHorasExtras, double TotalMonto, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria, int HorasExtras)
        {
            string QueryActualizarPago = "Update tbl_PagoEmpleados set CodigoEmpleado=@CodigoEmpleado, FechaPago=@FechaPago, Sueldo=@Sueldo, Bono=@Bono, MontoHorasExtra=@MontoHorasExtras, TotalMonto=@TotalMonto, Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditora=@FechaAuditoria, HorasExtras=@HorasExtras where CodigoPago=@CodigoPago";
            SqlCommand cmd = new SqlCommand(QueryActualizarPago, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPago", CodigoPago);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@Bono", Bono);
            cmd.Parameters.AddWithValue("@MontoHorasExtras", MontoHorasExtras);
            cmd.Parameters.AddWithValue("@TotalMonto", TotalMonto);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@HorasExtras", HorasExtras);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        } //actualiza un pago en la base de datos con los datos proporcionados por el usuario

        public void mtd_EliminarPago(string CodigoPago)
        {
            string QueryEliminarEmpleado = "Delete from tbl_PagoEmpleados where CodigoPago=@CodigoPago";
            SqlCommand cmd = new SqlCommand(QueryEliminarEmpleado, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPago", CodigoPago);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        } //elimina un pago de la base de datos segun el codigo de pago seleccionado del datagridview


    }
}
