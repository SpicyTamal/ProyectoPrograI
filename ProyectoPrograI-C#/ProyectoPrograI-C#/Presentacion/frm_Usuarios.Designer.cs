namespace ProyectoPrograI_C_.Presentacion
{
    partial class frm_Usuarios
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.btn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.btn_Minimizar = new FontAwesome.Sharp.IconButton();
            this.cbx_Tipo_Usuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_Agregar = new FontAwesome.Sharp.IconButton();
            this.btn_Editar = new FontAwesome.Sharp.IconButton();
            this.btn_Cancelar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Codigo_Usuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_Fecha_Auditoria = new System.Windows.Forms.TextBox();
            this.txt_Usuario_Auditoria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Estado_Usuarios = new System.Windows.Forms.ComboBox();
            this.cbx_foreign_Codigo_Empleado = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(520, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "USUARIOS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.iconPictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 569);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Orange;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 196;
            this.iconPictureBox3.Location = new System.Drawing.Point(21, 194);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(196, 198);
            this.iconPictureBox3.TabIndex = 10;
            this.iconPictureBox3.TabStop = false;
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Usuarios.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Location = new System.Drawing.Point(260, 289);
            this.dgv_Usuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.RowHeadersWidth = 51;
            this.dgv_Usuarios.RowTemplate.Height = 24;
            this.dgv_Usuarios.Size = new System.Drawing.Size(662, 234);
            this.dgv_Usuarios.TabIndex = 14;
            this.dgv_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Usuarios_CellClick);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Cerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btn_Cerrar.IconColor = System.Drawing.SystemColors.GrayText;
            this.btn_Cerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_Cerrar.IconSize = 25;
            this.btn_Cerrar.Location = new System.Drawing.Point(899, 11);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(21, 25);
            this.btn_Cerrar.TabIndex = 16;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Minimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_Minimizar.IconColor = System.Drawing.SystemColors.GrayText;
            this.btn_Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimizar.IconSize = 25;
            this.btn_Minimizar.Location = new System.Drawing.Point(872, 11);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(21, 25);
            this.btn_Minimizar.TabIndex = 15;
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // cbx_Tipo_Usuario
            // 
            this.cbx_Tipo_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Tipo_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbx_Tipo_Usuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_Tipo_Usuario.FormattingEnabled = true;
            this.cbx_Tipo_Usuario.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Asistente",
            "Digitador"});
            this.cbx_Tipo_Usuario.Location = new System.Drawing.Point(410, 205);
            this.cbx_Tipo_Usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Tipo_Usuario.Name = "cbx_Tipo_Usuario";
            this.cbx_Tipo_Usuario.Size = new System.Drawing.Size(210, 21);
            this.cbx_Tipo_Usuario.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(274, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo Usuario:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(274, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Codigo Empleado:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_Eliminar.IconColor = System.Drawing.Color.Black;
            this.btn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Eliminar.IconSize = 25;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(764, 527);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(76, 32);
            this.btn_Eliminar.TabIndex = 49;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_Agregar.IconColor = System.Drawing.Color.Black;
            this.btn_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Agregar.IconSize = 25;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(763, 254);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(76, 32);
            this.btn_Agregar.TabIndex = 54;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Editar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btn_Editar.IconColor = System.Drawing.Color.Black;
            this.btn_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Editar.IconSize = 25;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(844, 254);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(76, 32);
            this.btn_Editar.TabIndex = 53;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btn_Cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cancelar.IconSize = 25;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(844, 527);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(76, 32);
            this.btn_Cancelar.TabIndex = 52;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(409, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 2);
            this.panel3.TabIndex = 57;
            // 
            // txt_Codigo_Usuario
            // 
            this.txt_Codigo_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Codigo_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Codigo_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Codigo_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Usuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Codigo_Usuario.Location = new System.Drawing.Point(409, 44);
            this.txt_Codigo_Usuario.Name = "txt_Codigo_Usuario";
            this.txt_Codigo_Usuario.Size = new System.Drawing.Size(208, 15);
            this.txt_Codigo_Usuario.TabIndex = 56;
            this.txt_Codigo_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(274, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Codigo Usuario:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(410, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 2);
            this.panel4.TabIndex = 62;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Usuario.Location = new System.Drawing.Point(410, 119);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(208, 15);
            this.txt_Usuario.TabIndex = 61;
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(274, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Usuario:";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(410, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 2);
            this.panel5.TabIndex = 65;
            // 
            // txt_Clave
            // 
            this.txt_Clave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Clave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Clave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Clave.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Clave.Location = new System.Drawing.Point(410, 158);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(208, 15);
            this.txt_Clave.TabIndex = 64;
            this.txt_Clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(274, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "Clave:";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(685, 215);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(208, 2);
            this.panel7.TabIndex = 73;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(685, 138);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(208, 2);
            this.panel6.TabIndex = 70;
            // 
            // txt_Fecha_Auditoria
            // 
            this.txt_Fecha_Auditoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Fecha_Auditoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Fecha_Auditoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Fecha_Auditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha_Auditoria.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Fecha_Auditoria.Location = new System.Drawing.Point(685, 196);
            this.txt_Fecha_Auditoria.Name = "txt_Fecha_Auditoria";
            this.txt_Fecha_Auditoria.Size = new System.Drawing.Size(208, 15);
            this.txt_Fecha_Auditoria.TabIndex = 72;
            this.txt_Fecha_Auditoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Usuario_Auditoria
            // 
            this.txt_Usuario_Auditoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Usuario_Auditoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Usuario_Auditoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Usuario_Auditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario_Auditoria.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Usuario_Auditoria.Location = new System.Drawing.Point(685, 119);
            this.txt_Usuario_Auditoria.Name = "txt_Usuario_Auditoria";
            this.txt_Usuario_Auditoria.Size = new System.Drawing.Size(208, 15);
            this.txt_Usuario_Auditoria.TabIndex = 69;
            this.txt_Usuario_Auditoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(630, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 71;
            this.label10.Text = "Fecha Auditoria:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(630, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "Usuario Auditoria:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(630, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Estado:";
            // 
            // cbx_Estado_Usuarios
            // 
            this.cbx_Estado_Usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Estado_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbx_Estado_Usuarios.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_Estado_Usuarios.FormattingEnabled = true;
            this.cbx_Estado_Usuarios.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_Estado_Usuarios.Location = new System.Drawing.Point(685, 48);
            this.cbx_Estado_Usuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Estado_Usuarios.Name = "cbx_Estado_Usuarios";
            this.cbx_Estado_Usuarios.Size = new System.Drawing.Size(209, 21);
            this.cbx_Estado_Usuarios.TabIndex = 66;
            // 
            // cbx_foreign_Codigo_Empleado
            // 
            this.cbx_foreign_Codigo_Empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_foreign_Codigo_Empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbx_foreign_Codigo_Empleado.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_foreign_Codigo_Empleado.FormattingEnabled = true;
            this.cbx_foreign_Codigo_Empleado.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Asistente",
            "Digitador"});
            this.cbx_foreign_Codigo_Empleado.Location = new System.Drawing.Point(409, 81);
            this.cbx_foreign_Codigo_Empleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_foreign_Codigo_Empleado.Name = "cbx_foreign_Codigo_Empleado";
            this.cbx_foreign_Codigo_Empleado.Size = new System.Drawing.Size(210, 21);
            this.cbx_foreign_Codigo_Empleado.TabIndex = 74;
            this.cbx_foreign_Codigo_Empleado.SelectedIndexChanged += new System.EventHandler(this.cbx_foreign_Codigo_Empleado_SelectedIndexChanged);
            // 
            // frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(930, 569);
            this.Controls.Add(this.cbx_foreign_Codigo_Empleado);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_Fecha_Auditoria);
            this.Controls.Add(this.txt_Usuario_Auditoria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_Estado_Usuarios);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_Clave);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_Codigo_Usuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Minimizar);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Tipo_Usuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_Usuarios";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Usuarios";
            this.Load += new System.EventHandler(this.frm_Usuarios_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Usuarios_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private FontAwesome.Sharp.IconButton btn_Cerrar;
        private FontAwesome.Sharp.IconButton btn_Minimizar;
        private System.Windows.Forms.ComboBox cbx_Tipo_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private FontAwesome.Sharp.IconButton btn_Editar;
        private FontAwesome.Sharp.IconButton btn_Cancelar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_Codigo_Usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_Fecha_Auditoria;
        private System.Windows.Forms.TextBox txt_Usuario_Auditoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Estado_Usuarios;
        private System.Windows.Forms.ComboBox cbx_foreign_Codigo_Empleado;
    }
}