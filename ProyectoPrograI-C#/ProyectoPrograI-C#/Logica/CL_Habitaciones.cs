using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Logica
{
    internal class CL_Habitaciones
    {

        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }

        public int MtdCostoHabitaciones(string tipoHabitacion)
        {
            if (tipoHabitacion == "General") return 300;
            if (tipoHabitacion == "Maternidad") return 1000;
            if (tipoHabitacion == "Pediatria") return 500;
            if (tipoHabitacion == "Aislamiento") return 3000;
            if (tipoHabitacion == "Observacion") return 100;
            else
            {
                return 0;
            }
        }

    }
}
