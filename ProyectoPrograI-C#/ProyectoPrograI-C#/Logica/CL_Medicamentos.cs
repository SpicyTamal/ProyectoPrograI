﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograI_C_.Logica
{
    public class CL_Medicamentos
    {
        public DateTime mtd_Fecha_De_Hoy()
        {
            return DateTime.Now;
        }

        public double mtd_Costo_Medicamentos(string Tipo_Medicamento)
        {
            if (Tipo_Medicamento == "Jarabe") return 150;
            else if (Tipo_Medicamento == "Suero") return 25;
            else if (Tipo_Medicamento == "Crema") return 75;
            else if (Tipo_Medicamento == "Tableta") return 25;
            else if (Tipo_Medicamento == "Inyeccion") return 125;
            else return 0;
        }
    }
}
