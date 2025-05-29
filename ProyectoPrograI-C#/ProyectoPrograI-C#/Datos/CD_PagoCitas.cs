using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Datos
{
    internal class CD_PagoCitas
    {
        CD_Conexion1 conexion = new CD_Conexion1();

        public DataTable Mtd_ConsultarPagoCitas()
        {
            string QueryConsultarPagoCitas = "select * from tbl_PagoCitas";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarPagoCitas, conexion.MtdCerrarConexion());
            DataTable DT = new DataTable();
            Adapter.Fill(DT);
            return DT;
        }

        public List<dynamic> Mtd_ConsultarCodigoCita()
        {
            List<dynamic> CodigoCita = new List<dynamic>();
            string QueryConsultarCodigoCita = "select CodigoCita, FechaIngreso, FechaEgreso from tbl_Citas";
            SqlCommand cmd = new SqlCommand(QueryConsultarCodigoCita, conexion.MtdAbrirConexion());
            SqlDataReader readaer = cmd.ExecuteReader();

            while(readaer.Read())
            {
                CodigoCita.Add(new
                {
                    Value = readaer["CodigoCita"],
                    Text = $"{readaer["CodigoCita"]} - {readaer["FechaIngreso"]} - {readaer["FechaEgreso"]}"
                });
            }

            conexion.MtdCerrarConexion();
            return CodigoCita;
        }

        public double Mtd_ConsultarCostoTratamiento(int CodigoCita)
        {
            double CostoTratamiento;
            string QueryConsultarCostoTratamiento = "select CostoTratamiento from tbl_Citas where CodigoCita=@CodigoCita";
            SqlCommand cmd = new SqlCommand(QueryConsultarCostoTratamiento, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            SqlDataReader readaer = cmd.ExecuteReader();

            if (readaer.Read())
            {
                CostoTratamiento = double.Parse(readaer["CostoTratamiento"].ToString());
            }
            else
            {
                CostoTratamiento = 0;
            }

            conexion.MtdCerrarConexion();
            return CostoTratamiento;
        }

        public double Mtd_ConsultarCostoHabitacion(int CodigoCita)
        {
            double CostoHabitacion;
            string QueryConsultarCostoHabitacion = "select CostoHabitacion from tbl_Citas where CodigoCita=@CodigoCita";
            SqlCommand cmd = new SqlCommand(QueryConsultarCostoHabitacion, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            SqlDataReader readaer = cmd.ExecuteReader();

            if (readaer.Read())
            {
                CostoHabitacion = double.Parse(readaer["CostoHabitacion"].ToString());
            }
            else
            {
                CostoHabitacion = 0;
            }

            conexion.MtdCerrarConexion();
            return CostoHabitacion;
        }

        public void Mtd_AgregarPagoCitas(int CodigoCita, double MontoCita, double Impuestos, double Descuento, double TotalPago, DateTime FechaPago, string TipoPago, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarPagoCitas = "insert into tbl_PagoCitas(CodigoCita,MontoCita,Impuestos,Descuento,TotalPago,FechaPago,TipoPago,UsuarioAuditoria,FechaAuditoria) values(@CodigoCita, @MontoCita, @Impuestos, @Descuento, @TotalPago, @FechaPago, @TipoPago, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarPagoCitas, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            cmd.Parameters.AddWithValue("@MontoCita", MontoCita);
            cmd.Parameters.AddWithValue("@Impuestos", Impuestos);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@TotalPago", TotalPago);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@TipoPago", TipoPago);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

        public void Mtd_ActualizarPagoCitas(int CodigoPagoCita, int CodigoCita, double MontoCita, double Impuestos, double Descuento, double TotalPago, DateTime FechaPago, string TipoPago)
        {
            string QueryActualizarPagoCitas = "update tbl_PagoCitas set CodigoCita=@CodigoCita, MontoCita=@MontoCita, Impuestos=@Impuestos, Descuento=@Descuento, TotalPago=@TotalPago, FechaPago=@FechaPago, TipoPago=@TipoPago where CodigoPagoCita=@CodigoPagoCita";
            SqlCommand cmd = new SqlCommand(QueryActualizarPagoCitas, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPagoCita", CodigoPagoCita);
            cmd.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            cmd.Parameters.AddWithValue("@MontoCita", MontoCita);
            cmd.Parameters.AddWithValue("@Impuestos", Impuestos);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@TotalPago", TotalPago);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@TipoPago", TipoPago);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

        public void Mtd_EliminarPagoCita(int CodigoPagoCita)
        {
            string QueryEliminarPagoCita = "delete tbl_PagoCitas where CodigoPagoCita=@CodigoPagoCita";
            SqlCommand cmd = new SqlCommand(QueryEliminarPagoCita, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPagoCita", CodigoPagoCita);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

    }
}
