using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Logica
{
    class CL_Tratamientos
    {
        public double mtd_Costo_Tratamiento(string Tipo_Tratamiento)
        {
            if (Tipo_Tratamiento == "Consulta") return 150;
            else if (Tipo_Tratamiento == "Examen") return 200;
            else if (Tipo_Tratamiento == "Radiografia") return 300;
            else if (Tipo_Tratamiento == "Ultrasonido") return 400;
            else if (Tipo_Tratamiento == "Tomografia") return 500;
            else return 0;
        }
    }
}
