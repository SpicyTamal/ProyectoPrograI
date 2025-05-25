using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Logica
{
    internal class CL_Empleados
    {
        public double mtd_Salarios(string puesto)
        {
            if (puesto == "Director") return 30000;
            else if (puesto == "Medico") return 20000;
            else if (puesto == "Enfermero") return 10000;
            else if (puesto == "Tecnico") return 7000;
            else return 6000;
        }
    }
}
