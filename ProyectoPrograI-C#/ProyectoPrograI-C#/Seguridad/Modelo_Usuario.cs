using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Seguridad
{
    public class Modelo_Usuario
    {
        DAO_Usuario daoUser = new DAO_Usuario();

        public bool LoginUsuario(string usuario, string clave)
        {
           return daoUser.Login(usuario, clave);
        }
    }
}
