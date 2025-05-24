using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoPrograI_C_.Datos
{
    internal class CD_Habitaciones
    {
        CD_Conexion1 CD_Conexion1 = new CD_Conexion1();

        public DataTable Mtd_ConsultarHabitaciones()
        {
            string QueryConsultaHabitaciones = "Select * from tbl_Habitaciones";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultaHabitaciones, CD_Conexion1.MtdAbrirConexion());
            DataTable DT = new DataTable();
            Adapter.Fill(DT);
            CD_Conexion1.MtdCerrarConexion();
            return DT;
        }

    }
}
