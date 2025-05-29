using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograI_C_.Presentacion
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.pnl_Principal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(0, 0, 0));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int lx, ly, sw, sh;

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void pnl_Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            btn_Maximizar.Visible = true;
            btn_Restaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btn_Empleados_Click(object sender, EventArgs e) 
        {
            
            AbrirFormulario<frm_Empleados>();            
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Tratamientos>();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Usuarios>();
        }

        private void btn_PagoPlantillas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_PagoPlanilla>();
        }

        private void btn_Habitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Habitaciones>();
        }

        private void btn_GestionHabitaciones_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<frm_GestionHabitaciones>();
        }

        private void btn_Pacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Pacientes>();
        }

        private void btn_Citas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Citas>();
        }

        private void btn_Medicamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Medicamentos>();
        }

        private void btn_PagoCitas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_PagoCitas>();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO
        [DllImport("user32.dll")]    
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //INICIO DE VENTANAS EN EL MENU
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnl_Formularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                pnl_Formularios.Controls.Add(formulario);
                pnl_Formularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }





        //FIN VENTANAS EN EL MENU

    }
}
