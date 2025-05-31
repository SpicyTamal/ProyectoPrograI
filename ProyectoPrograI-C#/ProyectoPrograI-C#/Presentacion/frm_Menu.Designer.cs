namespace ProyectoPrograI_C_.Presentacion
{
    partial class frm_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.pnl_Principal = new System.Windows.Forms.Panel();
            this.pnl_Formularios = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_UsuarioAuditoria = new System.Windows.Forms.Label();
            this.btn_PagoCitas = new FontAwesome.Sharp.IconButton();
            this.btn_Tratamientos = new FontAwesome.Sharp.IconButton();
            this.btn_Medicamentos = new FontAwesome.Sharp.IconButton();
            this.btn_Citas = new FontAwesome.Sharp.IconButton();
            this.btn_Pacientes = new FontAwesome.Sharp.IconButton();
            this.btn_GestionHabitaciones = new FontAwesome.Sharp.IconButton();
            this.btn_Habitaciones = new FontAwesome.Sharp.IconButton();
            this.btn_PagoPlantillas = new FontAwesome.Sharp.IconButton();
            this.btn_Usuarios = new FontAwesome.Sharp.IconButton();
            this.btn_Empleados = new FontAwesome.Sharp.IconButton();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.btn_Restaurar = new FontAwesome.Sharp.IconButton();
            this.btn_Maximizar = new FontAwesome.Sharp.IconButton();
            this.btn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.btn_Minimizar = new FontAwesome.Sharp.IconButton();
            this.pnl_Principal.SuspendLayout();
            this.pnl_Formularios.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.Controls.Add(this.pnl_Formularios);
            this.pnl_Principal.Controls.Add(this.pnl_Menu);
            this.pnl_Principal.Controls.Add(this.pnl_Titulo);
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(1040, 640);
            this.pnl_Principal.TabIndex = 2;
            // 
            // pnl_Formularios
            // 
            this.pnl_Formularios.BackColor = System.Drawing.Color.DimGray;
            this.pnl_Formularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Formularios.Controls.Add(this.iconButton1);
            this.pnl_Formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Formularios.Location = new System.Drawing.Point(200, 40);
            this.pnl_Formularios.Name = "pnl_Formularios";
            this.pnl_Formularios.Size = new System.Drawing.Size(840, 600);
            this.pnl_Formularios.TabIndex = 2;
            this.pnl_Formularios.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Formularios_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DimGray;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Beige;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.HospitalWide;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 300;
            this.iconButton1.Location = new System.Drawing.Point(379, 152);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(502, 329);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.Orange;
            this.pnl_Menu.Controls.Add(this.label1);
            this.pnl_Menu.Controls.Add(this.lbl_UsuarioAuditoria);
            this.pnl_Menu.Controls.Add(this.btn_PagoCitas);
            this.pnl_Menu.Controls.Add(this.btn_Tratamientos);
            this.pnl_Menu.Controls.Add(this.btn_Medicamentos);
            this.pnl_Menu.Controls.Add(this.btn_Citas);
            this.pnl_Menu.Controls.Add(this.btn_Pacientes);
            this.pnl_Menu.Controls.Add(this.btn_GestionHabitaciones);
            this.pnl_Menu.Controls.Add(this.btn_Habitaciones);
            this.pnl_Menu.Controls.Add(this.btn_PagoPlantillas);
            this.pnl_Menu.Controls.Add(this.btn_Usuarios);
            this.pnl_Menu.Controls.Add(this.btn_Empleados);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 40);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(200, 600);
            this.pnl_Menu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Usuario:";
            // 
            // lbl_UsuarioAuditoria
            // 
            this.lbl_UsuarioAuditoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_UsuarioAuditoria.AutoSize = true;
            this.lbl_UsuarioAuditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsuarioAuditoria.ForeColor = System.Drawing.Color.Black;
            this.lbl_UsuarioAuditoria.Location = new System.Drawing.Point(62, 557);
            this.lbl_UsuarioAuditoria.Name = "lbl_UsuarioAuditoria";
            this.lbl_UsuarioAuditoria.Size = new System.Drawing.Size(0, 17);
            this.lbl_UsuarioAuditoria.TabIndex = 54;
            // 
            // btn_PagoCitas
            // 
            this.btn_PagoCitas.BackColor = System.Drawing.Color.Orange;
            this.btn_PagoCitas.FlatAppearance.BorderSize = 0;
            this.btn_PagoCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PagoCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PagoCitas.ForeColor = System.Drawing.Color.Black;
            this.btn_PagoCitas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btn_PagoCitas.IconColor = System.Drawing.Color.Black;
            this.btn_PagoCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_PagoCitas.Location = new System.Drawing.Point(13, 472);
            this.btn_PagoCitas.Name = "btn_PagoCitas";
            this.btn_PagoCitas.Size = new System.Drawing.Size(141, 54);
            this.btn_PagoCitas.TabIndex = 9;
            this.btn_PagoCitas.Text = "Pago de Citas";
            this.btn_PagoCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PagoCitas.UseVisualStyleBackColor = false;
            this.btn_PagoCitas.Click += new System.EventHandler(this.btn_PagoCitas_Click);
            // 
            // btn_Tratamientos
            // 
            this.btn_Tratamientos.BackColor = System.Drawing.Color.Orange;
            this.btn_Tratamientos.FlatAppearance.BorderSize = 0;
            this.btn_Tratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tratamientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tratamientos.ForeColor = System.Drawing.Color.Black;
            this.btn_Tratamientos.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btn_Tratamientos.IconColor = System.Drawing.Color.Black;
            this.btn_Tratamientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Tratamientos.Location = new System.Drawing.Point(14, 423);
            this.btn_Tratamientos.Name = "btn_Tratamientos";
            this.btn_Tratamientos.Size = new System.Drawing.Size(155, 54);
            this.btn_Tratamientos.TabIndex = 8;
            this.btn_Tratamientos.Text = "Tratamientos";
            this.btn_Tratamientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Tratamientos.UseVisualStyleBackColor = false;
            this.btn_Tratamientos.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // btn_Medicamentos
            // 
            this.btn_Medicamentos.BackColor = System.Drawing.Color.Orange;
            this.btn_Medicamentos.FlatAppearance.BorderSize = 0;
            this.btn_Medicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Medicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Medicamentos.ForeColor = System.Drawing.Color.Black;
            this.btn_Medicamentos.IconChar = FontAwesome.Sharp.IconChar.Pills;
            this.btn_Medicamentos.IconColor = System.Drawing.Color.Black;
            this.btn_Medicamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Medicamentos.Location = new System.Drawing.Point(18, 375);
            this.btn_Medicamentos.Name = "btn_Medicamentos";
            this.btn_Medicamentos.Size = new System.Drawing.Size(155, 54);
            this.btn_Medicamentos.TabIndex = 7;
            this.btn_Medicamentos.Text = "Medicamentos";
            this.btn_Medicamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Medicamentos.UseVisualStyleBackColor = false;
            this.btn_Medicamentos.Click += new System.EventHandler(this.btn_Medicamentos_Click);
            // 
            // btn_Citas
            // 
            this.btn_Citas.BackColor = System.Drawing.Color.Orange;
            this.btn_Citas.FlatAppearance.BorderSize = 0;
            this.btn_Citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Citas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Citas.ForeColor = System.Drawing.Color.Black;
            this.btn_Citas.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.btn_Citas.IconColor = System.Drawing.Color.Black;
            this.btn_Citas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Citas.Location = new System.Drawing.Point(8, 326);
            this.btn_Citas.Name = "btn_Citas";
            this.btn_Citas.Size = new System.Drawing.Size(141, 54);
            this.btn_Citas.TabIndex = 6;
            this.btn_Citas.Text = "Citas";
            this.btn_Citas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Citas.UseVisualStyleBackColor = false;
            this.btn_Citas.Click += new System.EventHandler(this.btn_Citas_Click);
            // 
            // btn_Pacientes
            // 
            this.btn_Pacientes.BackColor = System.Drawing.Color.Orange;
            this.btn_Pacientes.FlatAppearance.BorderSize = 0;
            this.btn_Pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pacientes.ForeColor = System.Drawing.Color.Black;
            this.btn_Pacientes.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.btn_Pacientes.IconColor = System.Drawing.Color.Black;
            this.btn_Pacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Pacientes.Location = new System.Drawing.Point(14, 277);
            this.btn_Pacientes.Name = "btn_Pacientes";
            this.btn_Pacientes.Size = new System.Drawing.Size(141, 54);
            this.btn_Pacientes.TabIndex = 5;
            this.btn_Pacientes.Text = "Pacientes";
            this.btn_Pacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Pacientes.UseVisualStyleBackColor = false;
            this.btn_Pacientes.Click += new System.EventHandler(this.btn_Pacientes_Click);
            // 
            // btn_GestionHabitaciones
            // 
            this.btn_GestionHabitaciones.BackColor = System.Drawing.Color.Orange;
            this.btn_GestionHabitaciones.FlatAppearance.BorderSize = 0;
            this.btn_GestionHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestionHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestionHabitaciones.ForeColor = System.Drawing.Color.Black;
            this.btn_GestionHabitaciones.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btn_GestionHabitaciones.IconColor = System.Drawing.Color.Black;
            this.btn_GestionHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_GestionHabitaciones.Location = new System.Drawing.Point(18, 228);
            this.btn_GestionHabitaciones.Name = "btn_GestionHabitaciones";
            this.btn_GestionHabitaciones.Size = new System.Drawing.Size(141, 54);
            this.btn_GestionHabitaciones.TabIndex = 4;
            this.btn_GestionHabitaciones.Text = "Gestion de Habitaciones";
            this.btn_GestionHabitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GestionHabitaciones.UseVisualStyleBackColor = false;
            this.btn_GestionHabitaciones.Click += new System.EventHandler(this.btn_GestionHabitaciones_Click);
            // 
            // btn_Habitaciones
            // 
            this.btn_Habitaciones.BackColor = System.Drawing.Color.Orange;
            this.btn_Habitaciones.FlatAppearance.BorderSize = 0;
            this.btn_Habitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Habitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Habitaciones.ForeColor = System.Drawing.Color.Black;
            this.btn_Habitaciones.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btn_Habitaciones.IconColor = System.Drawing.Color.Black;
            this.btn_Habitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Habitaciones.Location = new System.Drawing.Point(17, 180);
            this.btn_Habitaciones.Name = "btn_Habitaciones";
            this.btn_Habitaciones.Size = new System.Drawing.Size(155, 54);
            this.btn_Habitaciones.TabIndex = 3;
            this.btn_Habitaciones.Text = "Habitaciones";
            this.btn_Habitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Habitaciones.UseVisualStyleBackColor = false;
            this.btn_Habitaciones.Click += new System.EventHandler(this.btn_Habitaciones_Click);
            // 
            // btn_PagoPlantillas
            // 
            this.btn_PagoPlantillas.BackColor = System.Drawing.Color.Orange;
            this.btn_PagoPlantillas.FlatAppearance.BorderSize = 0;
            this.btn_PagoPlantillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PagoPlantillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PagoPlantillas.ForeColor = System.Drawing.Color.Black;
            this.btn_PagoPlantillas.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btn_PagoPlantillas.IconColor = System.Drawing.Color.Black;
            this.btn_PagoPlantillas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_PagoPlantillas.Location = new System.Drawing.Point(15, 131);
            this.btn_PagoPlantillas.Name = "btn_PagoPlantillas";
            this.btn_PagoPlantillas.Size = new System.Drawing.Size(141, 54);
            this.btn_PagoPlantillas.TabIndex = 2;
            this.btn_PagoPlantillas.Text = "Pago de Planillas";
            this.btn_PagoPlantillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PagoPlantillas.UseVisualStyleBackColor = false;
            this.btn_PagoPlantillas.Click += new System.EventHandler(this.btn_PagoPlantillas_Click);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.BackColor = System.Drawing.Color.Orange;
            this.btn_Usuarios.FlatAppearance.BorderSize = 0;
            this.btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Usuarios.ForeColor = System.Drawing.Color.Black;
            this.btn_Usuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btn_Usuarios.IconColor = System.Drawing.Color.Black;
            this.btn_Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Usuarios.Location = new System.Drawing.Point(14, 82);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(141, 54);
            this.btn_Usuarios.TabIndex = 1;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Usuarios.UseVisualStyleBackColor = false;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click);
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.BackColor = System.Drawing.Color.Orange;
            this.btn_Empleados.FlatAppearance.BorderSize = 0;
            this.btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleados.ForeColor = System.Drawing.Color.Black;
            this.btn_Empleados.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btn_Empleados.IconColor = System.Drawing.Color.Black;
            this.btn_Empleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Empleados.Location = new System.Drawing.Point(19, 38);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Size = new System.Drawing.Size(141, 48);
            this.btn_Empleados.TabIndex = 0;
            this.btn_Empleados.Text = "Empleados";
            this.btn_Empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Empleados.UseVisualStyleBackColor = false;
            this.btn_Empleados.Click += new System.EventHandler(this.btn_Empleados_Click);
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnl_Titulo.Controls.Add(this.btn_Restaurar);
            this.pnl_Titulo.Controls.Add(this.btn_Maximizar);
            this.pnl_Titulo.Controls.Add(this.btn_Cerrar);
            this.pnl_Titulo.Controls.Add(this.btn_Minimizar);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(1040, 40);
            this.pnl_Titulo.TabIndex = 0;
            this.pnl_Titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Titulo_Paint);
            this.pnl_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Titulo_MouseMove);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restaurar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Restaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btn_Restaurar.IconColor = System.Drawing.Color.Black;
            this.btn_Restaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Restaurar.IconSize = 25;
            this.btn_Restaurar.Location = new System.Drawing.Point(980, 9);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(21, 25);
            this.btn_Restaurar.TabIndex = 24;
            this.btn_Restaurar.UseVisualStyleBackColor = false;
            this.btn_Restaurar.Visible = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximizar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Maximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_Maximizar.IconColor = System.Drawing.Color.Black;
            this.btn_Maximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Maximizar.IconSize = 25;
            this.btn_Maximizar.Location = new System.Drawing.Point(980, 9);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(21, 25);
            this.btn_Maximizar.TabIndex = 23;
            this.btn_Maximizar.UseVisualStyleBackColor = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Cerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btn_Cerrar.IconColor = System.Drawing.Color.Black;
            this.btn_Cerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_Cerrar.IconSize = 25;
            this.btn_Cerrar.Location = new System.Drawing.Point(1007, 9);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(21, 25);
            this.btn_Cerrar.TabIndex = 22;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click_1);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Minimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_Minimizar.IconColor = System.Drawing.Color.Black;
            this.btn_Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimizar.IconSize = 25;
            this.btn_Minimizar.Location = new System.Drawing.Point(953, 9);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(21, 25);
            this.btn_Minimizar.TabIndex = 21;
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.pnl_Principal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 583);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.pnl_Principal.ResumeLayout(false);
            this.pnl_Formularios.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.pnl_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Principal;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_Formularios;
        private FontAwesome.Sharp.IconButton btn_Cerrar;
        private FontAwesome.Sharp.IconButton btn_Minimizar;
        private FontAwesome.Sharp.IconButton btn_Maximizar;
        private FontAwesome.Sharp.IconButton btn_Restaurar;
        private FontAwesome.Sharp.IconButton btn_Empleados;
        private FontAwesome.Sharp.IconButton btn_Tratamientos;
        private FontAwesome.Sharp.IconButton btn_Medicamentos;
        private FontAwesome.Sharp.IconButton btn_Citas;
        private FontAwesome.Sharp.IconButton btn_Pacientes;
        private FontAwesome.Sharp.IconButton btn_GestionHabitaciones;
        private FontAwesome.Sharp.IconButton btn_Habitaciones;
        private FontAwesome.Sharp.IconButton btn_PagoPlantillas;
        private FontAwesome.Sharp.IconButton btn_Usuarios;
        private FontAwesome.Sharp.IconButton btn_PagoCitas;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lbl_UsuarioAuditoria;
        private System.Windows.Forms.Label label1;
    }
}