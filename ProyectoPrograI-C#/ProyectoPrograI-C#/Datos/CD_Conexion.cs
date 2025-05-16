using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoPrograI_C_.Datos
{
    internal class CD_Conexion
    {
        SqlConnection db_Conexion = new SqlConnection("Data Source=SQL1003.site4now.net;Initial Catalog=db_ab9111_hospital;User Id=db_ab9111_hospital_admin;Password=Alinktothepast1");

        public SqlConnection MtdAbrirConexion()
        {
            if (db_Conexion.State == ConnectionState.Closed)
            {
                db_Conexion.Open();
            }
            return db_Conexion;
        }

        public SqlConnection MtdCerrarConexion()
        {
            if (db_Conexion.State == ConnectionState.Open)
            {
                db_Conexion.Close();
            }
            return db_Conexion;
        }

    }
}
