
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

        public double mtd_Costo_Tratamiento(int CodigoMedicamento)
        {
            var ListaMedicamentos = cd_tratamientos.mtd_Lista_Medicamentos();

            foreach (double Costo in ListaMedicamentos)
            {
                if (Costo == CodigoMedicamento)
                {
                    return Costo;
                }
            }
            return 0.0;
        }
    }
}
