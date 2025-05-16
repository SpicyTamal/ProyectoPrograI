using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoPrograI_C_.Logica;
using ProyectoPrograI_C_.Datos;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_Medicamentos: Form
    {
        CD_Medicamentos cd_medicamentos = new CD_Medicamentos();
        CL_Medicamentos cl_medicamentos = new CL_Medicamentos();

        public frm_Medicamentos()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void frm_Medicamentos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frm_Medicamentos_Load(object sender, EventArgs e)
        {

        }
    }
}
