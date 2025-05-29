namespace ProyectoPrograI_C_.Presentacion
{
    partial class frm_Tratamientos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Fecha_Vencimiento_Tratamientos = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.dgv_Tratamientos = new System.Windows.Forms.DataGridView();
            this.btn_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_Cancelar = new FontAwesome.Sharp.IconButton();
            this.btn_Editar = new FontAwesome.Sharp.IconButton();
            this.btn_Agregar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Codigo_Tratamiento = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_Costo = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_Fecha_Auditoria = new System.Windows.Forms.TextBox();
            this.txt_Usuario_Auditoria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_Estado_Tratamientos = new System.Windows.Forms.ComboBox();
            this.cbx_foreign_Codigo_Cita = new System.Windows.Forms.ComboBox();
            this.cbx_foreign_Codigo_Medicamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(274, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fecha Tratamiento";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(274, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Costo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(274, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Codigo Cita:";
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
            this.btn_Cerrar.Location = new System.Drawing.Point(904, 11);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(21, 25);
            this.btn_Cerrar.TabIndex = 33;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(520, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "TRATAMIENTOS";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(274, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Codigo Medicamento:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_Fecha_Vencimiento_Tratamientos
            // 
            this.dtp_Fecha_Vencimiento_Tratamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Fecha_Vencimiento_Tratamientos.Location = new System.Drawing.Point(409, 199);
            this.dtp_Fecha_Vencimiento_Tratamientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_Fecha_Vencimiento_Tratamientos.Name = "dtp_Fecha_Vencimiento_Tratamientos";
            this.dtp_Fecha_Vencimiento_Tratamientos.Size = new System.Drawing.Size(209, 20);
            this.dtp_Fecha_Vencimiento_Tratamientos.TabIndex = 39;
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
            this.panel1.TabIndex = 47;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Orange;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 196;
            this.iconPictureBox3.Location = new System.Drawing.Point(21, 194);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(196, 198);
            this.iconPictureBox3.TabIndex = 10;
            this.iconPictureBox3.TabStop = false;
            // 
            // dgv_Tratamientos
            // 
            this.dgv_Tratamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Tratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_Tratamientos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Tratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tratamientos.Location = new System.Drawing.Point(260, 289);
            this.dgv_Tratamientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Tratamientos.Name = "dgv_Tratamientos";
            this.dgv_Tratamientos.ReadOnly = true;
            this.dgv_Tratamientos.RowHeadersWidth = 51;
            this.dgv_Tratamientos.RowTemplate.Height = 24;
            this.dgv_Tratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Tratamientos.Size = new System.Drawing.Size(662, 234);
            this.dgv_Tratamientos.TabIndex = 30;
            this.dgv_Tratamientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tratamientos_CellClick);
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
            this.btn_Eliminar.TabIndex = 48;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_Cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cancelar.IconSize = 25;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(844, 527);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(76, 32);
            this.btn_Cancelar.TabIndex = 49;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
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
            this.btn_Editar.TabIndex = 50;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
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
            this.btn_Agregar.Location = new System.Drawing.Point(764, 254);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(76, 32);
            this.btn_Agregar.TabIndex = 51;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
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
            this.panel3.TabIndex = 54;
            // 
            // txt_Codigo_Tratamiento
            // 
            this.txt_Codigo_Tratamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Codigo_Tratamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Codigo_Tratamiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Codigo_Tratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Tratamiento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Codigo_Tratamiento.Location = new System.Drawing.Point(409, 44);
            this.txt_Codigo_Tratamiento.Name = "txt_Codigo_Tratamiento";
            this.txt_Codigo_Tratamiento.Size = new System.Drawing.Size(208, 15);
            this.txt_Codigo_Tratamiento.TabIndex = 53;
            this.txt_Codigo_Tratamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(409, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 2);
            this.panel5.TabIndex = 60;
            // 
            // txt_Costo
            // 
            this.txt_Costo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Costo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Costo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Costo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Costo.Location = new System.Drawing.Point(409, 156);
            this.txt_Costo.Name = "txt_Costo";
            this.txt_Costo.Size = new System.Drawing.Size(208, 15);
            this.txt_Costo.TabIndex = 59;
            this.txt_Costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(689, 215);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(208, 2);
            this.panel7.TabIndex = 55;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(689, 138);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(208, 2);
            this.panel6.TabIndex = 52;
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
            this.txt_Fecha_Auditoria.Location = new System.Drawing.Point(689, 196);
            this.txt_Fecha_Auditoria.Name = "txt_Fecha_Auditoria";
            this.txt_Fecha_Auditoria.Size = new System.Drawing.Size(208, 15);
            this.txt_Fecha_Auditoria.TabIndex = 54;
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
            this.txt_Usuario_Auditoria.Location = new System.Drawing.Point(689, 119);
            this.txt_Usuario_Auditoria.Name = "txt_Usuario_Auditoria";
            this.txt_Usuario_Auditoria.Size = new System.Drawing.Size(208, 15);
            this.txt_Usuario_Auditoria.TabIndex = 51;
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
            this.label10.Location = new System.Drawing.Point(634, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 53;
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
            this.label8.Location = new System.Drawing.Point(634, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Usuario Auditoria:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(634, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Estado:";
            // 
            // cbx_Estado_Tratamientos
            // 
            this.cbx_Estado_Tratamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Estado_Tratamientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbx_Estado_Tratamientos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_Estado_Tratamientos.FormattingEnabled = true;
            this.cbx_Estado_Tratamientos.Items.AddRange(new object[] {
            "Pendiente",
            "Progreso",
            "Completado",
            "Suspendido",
            "Cancelado"});
            this.cbx_Estado_Tratamientos.Location = new System.Drawing.Point(689, 48);
            this.cbx_Estado_Tratamientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Estado_Tratamientos.Name = "cbx_Estado_Tratamientos";
            this.cbx_Estado_Tratamientos.Size = new System.Drawing.Size(209, 21);
            this.cbx_Estado_Tratamientos.TabIndex = 48;
            // 
            // cbx_foreign_Codigo_Cita
            // 
            this.cbx_foreign_Codigo_Cita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_foreign_Codigo_Cita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbx_foreign_Codigo_Cita.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_foreign_Codigo_Cita.FormattingEnabled = true;
            this.cbx_foreign_Codigo_Cita.Location = new System.Drawing.Point(409, 81);
            this.cbx_foreign_Codigo_Cita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_foreign_Codigo_Cita.Name = "cbx_foreign_Codigo_Cita";
            this.cbx_foreign_Codigo_Cita.Size = new System.Drawing.Size(209, 21);
            this.cbx_foreign_Codigo_Cita.TabIndex = 61;
            this.cbx_foreign_Codigo_Cita.SelectedIndexChanged += new System.EventHandler(this.cbx_foreign_Codigo_Cita_SelectedIndexChanged);
            // 
            // cbx_foreign_Codigo_Medicamento
            // 
            this.cbx_foreign_Codigo_Medicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_foreign_Codigo_Medicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbx_foreign_Codigo_Medicamento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_foreign_Codigo_Medicamento.FormattingEnabled = true;
            this.cbx_foreign_Codigo_Medicamento.Location = new System.Drawing.Point(409, 120);
            this.cbx_foreign_Codigo_Medicamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_foreign_Codigo_Medicamento.Name = "cbx_foreign_Codigo_Medicamento";
            this.cbx_foreign_Codigo_Medicamento.Size = new System.Drawing.Size(209, 21);
            this.cbx_foreign_Codigo_Medicamento.TabIndex = 62;
            this.cbx_foreign_Codigo_Medicamento.SelectedIndexChanged += new System.EventHandler(this.cbx_foreign_Codigo_Medicamento_SelectedIndexChanged);
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
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Codigo Tratamiento:";
            // 
            // frm_Tratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(930, 569);
            this.Controls.Add(this.cbx_foreign_Codigo_Medicamento);
            this.Controls.Add(this.cbx_foreign_Codigo_Cita);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_Fecha_Auditoria);
            this.Controls.Add(this.txt_Costo);
            this.Controls.Add(this.txt_Usuario_Auditoria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_Estado_Tratamientos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_Codigo_Tratamiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dgv_Tratamientos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_Fecha_Vencimiento_Tratamientos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_Tratamientos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Tratamientos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Tratamientos_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Vencimiento_Tratamientos;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.DataGridView dgv_Tratamientos;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton btn_Cancelar;
        private FontAwesome.Sharp.IconButton btn_Editar;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_Codigo_Tratamiento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_Costo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_Fecha_Auditoria;
        private System.Windows.Forms.TextBox txt_Usuario_Auditoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_Estado_Tratamientos;
        private System.Windows.Forms.ComboBox cbx_foreign_Codigo_Cita;
        private System.Windows.Forms.ComboBox cbx_foreign_Codigo_Medicamento;
        private System.Windows.Forms.Label label7;
    }
}