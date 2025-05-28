using ProyectoPrograI_C_.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Logica
{
    internal class CL_Citas
    {
        CD_Citas conexion = new CD_Citas();

        public double Mtd_CostoTratamiento(int CodigoCitas)
        {
            return conexion.Mtd_ConsultarCostoTratamiento(CodigoCitas);
        }

        public double Mtd_CostoHabitacion(int CodigoPaciente)
        {
            int CodigoHabitacion = conexion.Mtd_ConsultarCodigoHabitacion(CodigoPaciente);
            double CostoHabitacion = conexion.Mtd_CostoHabitacion(CodigoHabitacion);
            return CostoHabitacion;
        }

        public DateTime Mtd_FechaHoy()
        {
            return DateTime.Now;
        }

    }
}
