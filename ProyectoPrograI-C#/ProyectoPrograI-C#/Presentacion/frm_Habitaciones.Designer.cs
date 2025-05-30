namespace ProyectoPrograI_C_.Presentacion
{
    partial class frm_Habitaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CodigoHabitacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_TipoHabitacion = new System.Windows.Forms.ComboBox();
            this.cbox_Estado = new System.Windows.Forms.ComboBox();
            this.dgv_Habitaciones = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new FontAwesome.Sharp.IconButton();
            this.btn_Editar = new FontAwesome.Sharp.IconButton();
            this.btn_Cancelar = new FontAwesome.Sharp.IconButton();
            this.btn_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_Salir = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_NumeroHabitacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_Ubicacion = new System.Windows.Forms.ComboBox();
            this.lbl_Costo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 569);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Orange;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 152;
            this.iconPictureBox1.Location = new System.Drawing.Point(51, 186);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(152, 152);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(526, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Habitaciones";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(258, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Codigo Habitacion";
            // 
            // txt_CodigoHabitacion
            // 
            this.txt_CodigoHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CodigoHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_CodigoHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CodigoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoHabitacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_CodigoHabitacion.Location = new System.Drawing.Point(422, 65);
            this.txt_CodigoHabitacion.Name = "txt_CodigoHabitacion";
            this.txt_CodigoHabitacion.ReadOnly = true;
            this.txt_CodigoHabitacion.Size = new System.Drawing.Size(208, 15);
            this.txt_CodigoHabitacion.TabIndex = 54;
            this.txt_CodigoHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(256, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tipo de habitacion";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(258, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(258, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Estado";
            // 
            // cbox_TipoHabitacion
            // 
            this.cbox_TipoHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_TipoHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbox_TipoHabitacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbox_TipoHabitacion.FormattingEnabled = true;
            this.cbox_TipoHabitacion.Items.AddRange(new object[] {
            "General",
            "Maternidad",
            "Pediatria",
            "Aislamiento",
            "Observacion"});
            this.cbox_TipoHabitacion.Location = new System.Drawing.Point(422, 165);
            this.cbox_TipoHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_TipoHabitacion.Name = "cbox_TipoHabitacion";
            this.cbox_TipoHabitacion.Size = new System.Drawing.Size(210, 21);
            this.cbox_TipoHabitacion.TabIndex = 62;
            this.cbox_TipoHabitacion.SelectedIndexChanged += new System.EventHandler(this.cbox_TipoHabitacion_SelectedIndexChanged);
            // 
            // cbox_Estado
            // 
            this.cbox_Estado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_Estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbox_Estado.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbox_Estado.FormattingEnabled = true;
            this.cbox_Estado.Items.AddRange(new object[] {
            "Pendiente",
            "Progreso",
            "Completado",
            "Suspendido",
            "Cancelado"});
            this.cbox_Estado.Location = new System.Drawing.Point(420, 242);
            this.cbox_Estado.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_Estado.Name = "cbox_Estado";
            this.cbox_Estado.Size = new System.Drawing.Size(210, 21);
            this.cbox_Estado.TabIndex = 64;
            // 
            // dgv_Habitaciones
            // 
            this.dgv_Habitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Habitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Habitaciones.Location = new System.Drawing.Point(259, 291);
            this.dgv_Habitaciones.Name = "dgv_Habitaciones";
            this.dgv_Habitaciones.RowHeadersWidth = 62;
            this.dgv_Habitaciones.Size = new System.Drawing.Size(645, 116);
            this.dgv_Habitaciones.TabIndex = 65;
            this.dgv_Habitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Habitaciones_CellClick);
            this.dgv_Habitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Medicamentos_CellContentClick);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_Agregar.IconColor = System.Drawing.Color.Black;
            this.btn_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Agregar.IconSize = 35;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(785, 63);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(94, 32);
            this.btn_Agregar.TabIndex = 66;
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
            this.btn_Editar.IconSize = 35;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(785, 107);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(94, 32);
            this.btn_Editar.TabIndex = 67;
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
            this.btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_Cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cancelar.IconSize = 35;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(785, 158);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 32);
            this.btn_Cancelar.TabIndex = 68;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_Eliminar.IconColor = System.Drawing.Color.Black;
            this.btn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Eliminar.IconSize = 35;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(644, 422);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(94, 32);
            this.btn_Eliminar.TabIndex = 69;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btn_Salir.IconColor = System.Drawing.Color.Black;
            this.btn_Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Salir.IconSize = 35;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(768, 422);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(94, 32);
            this.btn_Salir.TabIndex = 70;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(256, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Numero Habitacion";
            // 
            // cbox_NumeroHabitacion
            // 
            this.cbox_NumeroHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_NumeroHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbox_NumeroHabitacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbox_NumeroHabitacion.FormattingEnabled = true;
            this.cbox_NumeroHabitacion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbox_NumeroHabitacion.Location = new System.Drawing.Point(420, 97);
            this.cbox_NumeroHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_NumeroHabitacion.Name = "cbox_NumeroHabitacion";
            this.cbox_NumeroHabitacion.Size = new System.Drawing.Size(210, 21);
            this.cbox_NumeroHabitacion.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(256, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "Ubicacion";
            // 
            // cbox_Ubicacion
            // 
            this.cbox_Ubicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_Ubicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbox_Ubicacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbox_Ubicacion.FormattingEnabled = true;
            this.cbox_Ubicacion.Items.AddRange(new object[] {
            "Primer Nivel",
            "Segundo Nivel",
            "Tercer Nivel"});
            this.cbox_Ubicacion.Location = new System.Drawing.Point(420, 132);
            this.cbox_Ubicacion.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_Ubicacion.Name = "cbox_Ubicacion";
            this.cbox_Ubicacion.Size = new System.Drawing.Size(210, 21);
            this.cbox_Ubicacion.TabIndex = 74;
            // 
            // lbl_Costo
            // 
            this.lbl_Costo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Costo.AutoSize = true;
            this.lbl_Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Costo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_Costo.Location = new System.Drawing.Point(417, 205);
            this.lbl_Costo.Name = "lbl_Costo";
            this.lbl_Costo.Size = new System.Drawing.Size(0, 17);
            this.lbl_Costo.TabIndex = 75;
            // 
            // frm_Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(930, 569);
            this.Controls.Add(this.lbl_Costo);
            this.Controls.Add(this.cbox_Ubicacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbox_NumeroHabitacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv_Habitaciones);
            this.Controls.Add(this.cbox_Estado);
            this.Controls.Add(this.cbox_TipoHabitacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CodigoHabitacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Habitaciones";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Habitaciones";
            this.Load += new System.EventHandler(this.frm_Habitaciones_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Habitaciones_MouseDown_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Habitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CodigoHabitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_TipoHabitacion;
        private System.Windows.Forms.ComboBox cbox_Estado;
        private System.Windows.Forms.DataGridView dgv_Habitaciones;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private FontAwesome.Sharp.IconButton btn_Editar;
        private FontAwesome.Sharp.IconButton btn_Cancelar;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton btn_Salir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox_NumeroHabitacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbox_Ubicacion;
        private System.Windows.Forms.Label lbl_Costo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}