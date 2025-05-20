
using ProyectoPrograI_C_.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Logica
{
    class CL_Tratamientos
    {
        CD_Conexion1 cd_conexion = new CD_Conexion1();

        public DateTime mtd_Fecha_De_Hoy()
        {
            return DateTime.Now;
        }

        public double mtd_Costo_Tratamiento(string Tipo_Tratamiento)
        {
            //Aún no resuelvo este método
            return 0;
        }
    }
}
