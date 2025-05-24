
using ProyectoPrograI_C_.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Logica
{
    class CL_Tratamientos
    {
        CD_Conexion1 cd_conexion = new CD_Conexion1();
        CD_Tratamientos cd_tratamientos = new CD_Tratamientos();

        public DateTime mtd_Fecha_De_Hoy()
        {
            return DateTime.Now;
        }

        public double mtd_Costo_Medicamento(int CodigoMedicamento)
        {
            double CostoMedica = 0;

            string QueryConsultarCostoMedicamento = "Select Costo from tbl_Medicamentos where CodigoMedicamento=@CodigoMedicamento";
            SqlCommand CommandCostoMedicamento = new SqlCommand(QueryConsultarCostoMedicamento, cd_conexion.MtdAbrirConexion());
            CommandCostoMedicamento.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            SqlDataReader reader = CommandCostoMedicamento.ExecuteReader();

            if (reader.Read())
            {
                CostoMedica = double.Parse(reader["Costo"].ToString());
            }
            else
            {
                CostoMedica = 0;
            }

            cd_conexion.MtdCerrarConexion();
            return CostoMedica;
        }
    }
}
