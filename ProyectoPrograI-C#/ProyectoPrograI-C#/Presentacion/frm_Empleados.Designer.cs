namespace ProyectoPrograI_C_.Presentacion
{
    partial class frm_Empleados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.dgv_Empleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Sueldo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbox_TipoTrabajo = new System.Windows.Forms.ComboBox();
            this.cbox_Estado = new System.Windows.Forms.ComboBox();
            this.txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.txt_Especialidad = new System.Windows.Forms.TextBox();
            this.dtp_FechaAlta = new System.Windows.Forms.DateTimePicker();
            this.btn_Cancelar = new FontAwesome.Sharp.IconButton();
            this.btn_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_Agregar = new FontAwesome.Sharp.IconButton();
            this.btn_Editar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 569);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Orange;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 196;
            this.iconPictureBox1.Location = new System.Drawing.Point(21, 194);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(196, 198);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
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
            this.btn_Cerrar.TabIndex = 22;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // dgv_Empleados
            // 
            this.dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleados.Location = new System.Drawing.Point(260, 270);
            this.dgv_Empleados.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Empleados.Name = "dgv_Empleados";
            this.dgv_Empleados.RowHeadersWidth = 51;
            this.dgv_Empleados.RowTemplate.Height = 24;
            this.dgv_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Empleados.Size = new System.Drawing.Size(660, 234);
            this.dgv_Empleados.TabIndex = 23;
            this.dgv_Empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Empleados_CellClick);
            this.dgv_Empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Empleados_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(504, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "EMPLEADOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(292, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(283, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo de Trabajo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(292, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Especialidad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(328, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sueldo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.AutoSize = true;
            this.lbl_Sueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sueldo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_Sueldo.Location = new System.Drawing.Point(397, 194);
            this.lbl_Sueldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Sueldo.Name = "lbl_Sueldo";
            this.lbl_Sueldo.Size = new System.Drawing.Size(66, 17);
            this.lbl_Sueldo.TabIndex = 29;
            this.lbl_Sueldo.Text = "<sueldo>";
            this.lbl_Sueldo.Click += new System.EventHandler(this.lbl_Sueldo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(608, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Fecha de Alta:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(646, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Estado:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbox_TipoTrabajo
            // 
            this.cbox_TipoTrabajo.FormattingEnabled = true;
            this.cbox_TipoTrabajo.Items.AddRange(new object[] {
            "Director",
            "Medico",
            "Enfermero",
            "Tecnico",
            "Farmaceutico"});
            this.cbox_TipoTrabajo.Location = new System.Drawing.Point(400, 109);
            this.cbox_TipoTrabajo.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_TipoTrabajo.Name = "cbox_TipoTrabajo";
            this.cbox_TipoTrabajo.Size = new System.Drawing.Size(160, 21);
            this.cbox_TipoTrabajo.TabIndex = 32;
            this.cbox_TipoTrabajo.SelectedIndexChanged += new System.EventHandler(this.cbox_TipoTrabajo_SelectedIndexChanged);
            // 
            // cbox_Estado
            // 
            this.cbox_Estado.FormattingEnabled = true;
            this.cbox_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Suspendido",
            "Despedido"});
            this.cbox_Estado.Location = new System.Drawing.Point(700, 118);
            this.cbox_Estado.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_Estado.Name = "cbox_Estado";
            this.cbox_Estado.Size = new System.Drawing.Size(143, 21);
            this.cbox_Estado.TabIndex = 33;
            this.cbox_Estado.SelectedIndexChanged += new System.EventHandler(this.cbox_Estado_SelectedIndexChanged);
            // 
            // txt_NombreEmpleado
            // 
            this.txt_NombreEmpleado.Location = new System.Drawing.Point(358, 69);
            this.txt_NombreEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NombreEmpleado.Name = "txt_NombreEmpleado";
            this.txt_NombreEmpleado.Size = new System.Drawing.Size(209, 20);
            this.txt_NombreEmpleado.TabIndex = 34;
            this.txt_NombreEmpleado.TextChanged += new System.EventHandler(this.txt_NombreEmpleado_TextChanged);
            // 
            // txt_Especialidad
            // 
            this.txt_Especialidad.Location = new System.Drawing.Point(400, 147);
            this.txt_Especialidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Especialidad.Name = "txt_Especialidad";
            this.txt_Especialidad.Size = new System.Drawing.Size(156, 20);
            this.txt_Especialidad.TabIndex = 35;
            this.txt_Especialidad.TextChanged += new System.EventHandler(this.txt_Especialidad_TextChanged);
            // 
            // dtp_FechaAlta
            // 
            this.dtp_FechaAlta.Location = new System.Drawing.Point(700, 67);
            this.dtp_FechaAlta.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_FechaAlta.Name = "dtp_FechaAlta";
            this.dtp_FechaAlta.Size = new System.Drawing.Size(204, 20);
            this.dtp_FechaAlta.TabIndex = 36;
            this.dtp_FechaAlta.ValueChanged += new System.EventHandler(this.dtp_FechaAlta_ValueChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_Cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cancelar.IconSize = 25;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(844, 508);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(76, 32);
            this.btn_Cancelar.TabIndex = 38;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_Eliminar.IconColor = System.Drawing.Color.Black;
            this.btn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Eliminar.IconSize = 25;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(763, 508);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(76, 32);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_Agregar.IconColor = System.Drawing.Color.Black;
            this.btn_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Agregar.IconSize = 25;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(753, 234);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(86, 32);
            this.btn_Agregar.TabIndex = 40;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btn_Editar.IconColor = System.Drawing.Color.Black;
            this.btn_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Editar.IconSize = 25;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(844, 234);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(76, 32);
            this.btn_Editar.TabIndex = 39;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(930, 569);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dtp_FechaAlta);
            this.Controls.Add(this.txt_Especialidad);
            this.Controls.Add(this.txt_NombreEmpleado);
            this.Controls.Add(this.cbox_Estado);
            this.Controls.Add(this.cbox_TipoTrabajo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Sueldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Empleados);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Empleados";
            this.Text = "frm_Empleados";
            this.Load += new System.EventHandler(this.frm_Empleados_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Empleados_MouseDown_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btn_Cerrar;
        private System.Windows.Forms.DataGridView dgv_Empleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Sueldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbox_TipoTrabajo;
        private System.Windows.Forms.ComboBox cbox_Estado;
        private System.Windows.Forms.TextBox txt_NombreEmpleado;
        private System.Windows.Forms.TextBox txt_Especialidad;
        private System.Windows.Forms.DateTimePicker dtp_FechaAlta;
        private FontAwesome.Sharp.IconButton btn_Cancelar;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private FontAwesome.Sharp.IconButton btn_Editar;
    }
}