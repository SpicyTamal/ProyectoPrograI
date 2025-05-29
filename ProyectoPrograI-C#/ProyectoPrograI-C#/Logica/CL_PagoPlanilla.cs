using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograI_C_.Datos;

namespace ProyectoPrograI_C_.Logica
{
    internal class CL_PagoPlanilla
    {
        CD_Conexion1 cd_conexion = new CD_Conexion1();

        /*
        public string mtd_SueldoPlanilla(string x)
        {
            double sueldo, bono, montototal;

            return sueldo, bono, montototal; 
        } */

        public double mtd_SueldoEmpleado(int CodigoEmpleado)
        {
            double Sueldo = 0;

            string QueryConsultaSueldo = "Select Sueldo from tbl_Empleados where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand CommandSueldo = new SqlCommand(QueryConsultaSueldo, cd_conexion.MtdAbrirConexion());
            CommandSueldo.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            SqlDataReader reader = CommandSueldo.ExecuteReader();

            if (reader.Read())
            {
                Sueldo = double.Parse(reader["Sueldo"].ToString());
            }
            else
            {
                Sueldo = 0;
            }

            cd_conexion.MtdCerrarConexion();
            return Sueldo;
        }

        public List<dynamic> Mtd_ListaCodigoEmpleado()
        {
            List<dynamic> CodigoEmpleado = new List<dynamic>();
            string QueryListaCodigoEmpleados = "select CodigoEmpleado, Nombres from tbl_Empleados";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoEmpleados, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CodigoEmpleado.Add(new
                {
                    Value = reader["CodigoPaciente"],
                    Text = $"{reader["CodigoPaciente"]} - {reader["Nombres"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return CodigoEmpleado;
        }



    }
}
