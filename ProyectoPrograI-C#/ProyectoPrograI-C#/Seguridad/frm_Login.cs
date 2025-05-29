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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ProyectoPrograI_C_.Seguridad;
using ProyectoPrograI_C_.Presentacion;

namespace ProyectoProgra
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        //METODOS Y LOGICA DEL FORM

        private void msgError(string msg)
        {
            lbl_Error.Text = "    " + msg;
            lbl_Error.Visible = true;
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Error.Visible = false;
        }

        private void btn_Acceder_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text != "USUARIO" && txt_Usuario.TextLength > 2)
            {
                if (txt_Contrasena.Text != "CONTRASEÑA")
                {
                    Modelo_Usuario user = new Modelo_Usuario();
                    var validLogin = user.LoginUsuario(txt_Usuario.Text, txt_Contrasena.Text);
                    if (validLogin == true)
                    {
                        frm_Menu menu = new frm_Menu();
                        MessageBox.Show("Bienvenido " + Cache_Usuario.Usuario + ", " + Cache_Usuario.TipoUsuario);
                        menu.Show();
                        menu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrecta.");
                        txt_Contrasena.Text = "CONTRASEÑA";
                        txt_Contrasena.UseSystemPasswordChar = false;
                        txt_Usuario.Focus();
                    }
                }
                else msgError("Por favor ingerese la constraseña correcta.");
            }
            else msgError("Por favor ingrese un usuario correcto.");
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txt_Contrasena.Text = "CONTRASEÑA";
            txt_Contrasena.UseSystemPasswordChar = false;
            txt_Usuario.Text = "USUARIO";
            lbl_Error.Visible = false;
            this.Show();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "USUARIO")
            {
                txt_Usuario.Text = "";
                txt_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                txt_Usuario.Text = "USUARIO";
                txt_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txt_Contrasena.Text == "CONTRASEÑA")
            {
                txt_Contrasena.Text = "";
                txt_Contrasena.ForeColor = Color.DimGray;
                txt_Contrasena.UseSystemPasswordChar = true;
            }

        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txt_Contrasena.Text == "")
            {
                txt_Contrasena.Text = "CONTRASEÑA";
                txt_Contrasena.ForeColor = Color.DimGray;
                txt_Contrasena.UseSystemPasswordChar = false;
            }
        }

        //MOVIMIENTOS DEL FORM

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //BOTONES


        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //OTROS

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
