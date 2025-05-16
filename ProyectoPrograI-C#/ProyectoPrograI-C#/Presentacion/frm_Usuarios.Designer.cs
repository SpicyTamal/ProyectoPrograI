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
            this.txt_Codigo_Empleado = new System.Windows.Forms.TextBox();
            this.cbx_Tipo_Usuario = new System.Windows.Forms.ComboBox();
            this.cbx_Estado_Usuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label3.Location = new System.Drawing.Point(608, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 31);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 500);
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
            this.iconPictureBox3.IconSize = 244;
            this.iconPictureBox3.Location = new System.Drawing.Point(37, 125);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(261, 244);
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
            this.dgv_Usuarios.Location = new System.Drawing.Point(346, 239);
            this.dgv_Usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.RowHeadersWidth = 51;
            this.dgv_Usuarios.RowTemplate.Height = 24;
            this.dgv_Usuarios.Size = new System.Drawing.Size(682, 250);
            this.dgv_Usuarios.TabIndex = 14;
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
            this.btn_Cerrar.Location = new System.Drawing.Point(999, 14);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(28, 121);
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
            this.btn_Minimizar.Location = new System.Drawing.Point(963, 14);
            this.btn_Minimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(28, 120);
            this.btn_Minimizar.TabIndex = 15;
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // txt_Codigo_Empleado
            // 
            this.txt_Codigo_Empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Codigo_Empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Codigo_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Empleado.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Codigo_Empleado.Location = new System.Drawing.Point(544, 76);
            this.txt_Codigo_Empleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Codigo_Empleado.Multiline = true;
            this.txt_Codigo_Empleado.Name = "txt_Codigo_Empleado";
            this.txt_Codigo_Empleado.Size = new System.Drawing.Size(400, 20);
            this.txt_Codigo_Empleado.TabIndex = 7;
            this.txt_Codigo_Empleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Codigo_Empleado.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
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
            this.cbx_Tipo_Usuario.Location = new System.Drawing.Point(544, 116);
            this.cbx_Tipo_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Tipo_Usuario.Name = "cbx_Tipo_Usuario";
            this.cbx_Tipo_Usuario.Size = new System.Drawing.Size(399, 24);
            this.cbx_Tipo_Usuario.TabIndex = 9;
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
            this.cbx_Estado_Usuarios.Location = new System.Drawing.Point(544, 160);
            this.cbx_Estado_Usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Estado_Usuarios.Name = "cbx_Estado_Usuarios";
            this.cbx_Estado_Usuarios.Size = new System.Drawing.Size(399, 24);
            this.cbx_Estado_Usuarios.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(360, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "TIPO DE USUARIO:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(438, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "ESTADO:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(341, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "CODIGO EMPLEADO:\r\n";
            // 
            // frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1040, 500);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Minimizar);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Estado_Usuarios);
            this.Controls.Add(this.cbx_Tipo_Usuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Codigo_Empleado);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txt_Codigo_Empleado;
        private System.Windows.Forms.ComboBox cbx_Tipo_Usuario;
        private System.Windows.Forms.ComboBox cbx_Estado_Usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}