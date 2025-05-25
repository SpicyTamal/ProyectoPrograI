using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Seguridad
{
    public class DAO_Usuario : user_Conexion_a_SQL
    {
        public bool Login(string Usuario, string Clave)
        {
            using (var conexion = Obtener_Conexion())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select * from tbl_Usuarios where NombreUsuario=@NombreUsuario and Contrasenia=@Contrasenia";
                    command.Parameters.AddWithValue("@NombreUsuario", Usuario);
                    command.Parameters.AddWithValue("@Contrasenia", Clave);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cache_Usuario.CodigoUsuario = reader.GetInt32(0);
                            Cache_Usuario.CodigoEmpleado = reader.GetInt32(1);
                            Cache_Usuario.Usuario = reader.GetString(2);
                            Cache_Usuario.Clave = reader.GetString(3);
                            Cache_Usuario.TipoUsuario = reader.GetString(4);
                            Cache_Usuario.Estado = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
