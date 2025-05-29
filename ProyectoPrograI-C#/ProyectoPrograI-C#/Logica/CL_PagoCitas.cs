using ProyectoPrograI_C_.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Logica
{
    internal class CL_PagoCitas
    {
        CD_PagoCitas conexion = new CD_PagoCitas();

        public double Mtd_MontoCita(int CodigoCita)
        {
            double resultado;
            double CostoTratamiento = conexion.Mtd_ConsultarCostoTratamiento(CodigoCita);
            double CostoHabitacion = conexion.Mtd_ConsultarCostoHabitacion(CodigoCita);

            resultado = CostoTratamiento + CostoHabitacion;
            return resultado;
        }

        public double Mtd_Impuestos(double MontoCita)
        {
            double resultado = MontoCita * 0.12;
            return resultado;
        }

        public double Mtd_Descuento(double MontoCita)
        {
            if(MontoCita > 0 && MontoCita <= 500)
            {
                return MontoCita * 0.03;
            }
            else
            {
                if (MontoCita > 500 && MontoCita <= 5000)
                {
                    return MontoCita * 0.05;
                }
                else
                {
                    if( MontoCita > 5000)
                    {
                        return MontoCita * 0.07;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public double Mtd_TotalPago(double MontoCita, double Impuestos, double Descuento)
        {
            double resultado = MontoCita + Impuestos - Descuento;
            return resultado;
        }

    }
}
