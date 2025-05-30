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
            //funciones que previenen un parpadeo en el menu
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //*********metodos para redimensionar el formulario*********//
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;        

        //***********metodos para redimensionar el formulario***********//
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.pnl_Principal.Region = region;
            this.Invalidate();
        }        
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(0, 0, 0));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }        

        private void btn_Cerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        } //cierra todo el programa con el boton cerrar

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } //minimiza el formulario en la barra de tareas

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
        } //maximiza el formulario al tamaño de la pantalla y guarda el tamaño compacto para restaurarlo con el boton restaurar

        private void pnl_Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        } //esta funcion permite mover el formulario desde la barra superior del menu

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            btn_Maximizar.Visible = true;
            btn_Restaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        } //restaura el formulario a su tamaño compacto despues de estar maximizado

        private void btn_Empleados_Click(object sender, EventArgs e) 
        {            
            AbrirFormulario<frm_Empleados>();
        } //abre el formulario de empleados

        private void iconButton8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Tratamientos>();
        } //abre el formulario de tratamientos

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Usuarios>();
        } //abre el formulario de usuarios

        private void btn_PagoPlantillas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_PagoPlanilla>();
        } //abre el formulario de pago planilla

        private void btn_Habitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Habitaciones>();
        } //abre el formulario de habitaciones

        private void btn_GestionHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_GestionHabitaciones>();
        } //abre el formulario de gestion habitaciones

        private void btn_Pacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Pacientes>();
        } //abre el formulario de pacientes

        private void btn_Citas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Citas>();
        } //abre el formulario de citas

        private void btn_Medicamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_Medicamentos>();
        } //abre el formulario de medicamentos

        private void btn_PagoCitas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_PagoCitas>();
        } //abre el formulario de pago citas

        //******metodos para mover el formulario desde la barra superior******//
        [DllImport("user32.dll")]    
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnl_Formularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                pnl_Formularios.Controls.Add(formulario);
                pnl_Formularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        } //abre el formulario dentro del panel de formularios del menu y lo pone hasta el frente si ya esta abierto

        private void frm_Menu_Load(object sender, EventArgs e) { }
    }
}
