using ProyectoProgra;
using ProyectoPrograI_C_.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograI_C_
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new frm_Citas());
=======
            Application.Run(new frm_Login());
>>>>>>> a2067711bfca14a58752b382d28bda0ba8626e5b
        }
    }
}
