using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Seguridad
{
    public abstract class user_Conexion_a_SQL
    {
        private readonly string string_Conexion;
        public user_Conexion_a_SQL()
        {
            string_Conexion = "Data Source=SQL1003.site4now.net;Initial Catalog=db_ab9111_hospital;User Id=db_ab9111_hospital_admin;Password=Alinktothepast1";
        }
        protected SqlConnection Obtener_Conexion()
        {
            return new SqlConnection(string_Conexion);
        }
    }
}

