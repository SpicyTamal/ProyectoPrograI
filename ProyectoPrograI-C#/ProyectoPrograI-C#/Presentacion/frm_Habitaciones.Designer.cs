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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CodigoMedicamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_TipoHabitacion = new System.Windows.Forms.ComboBox();
            this.txt_Costo = new System.Windows.Forms.TextBox();
            this.btn_Estado = new System.Windows.Forms.ComboBox();
            this.dgv_Medicamentos = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new FontAwesome.Sharp.IconButton();
            this.btn_Editar = new FontAwesome.Sharp.IconButton();
            this.btn_Cancelar = new FontAwesome.Sharp.IconButton();
            this.btn_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_Salir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 569);
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Medicamentos";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(256, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Codigo Habitacion";
            // 
            // txt_CodigoMedicamento
            // 
            this.txt_CodigoMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CodigoMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_CodigoMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CodigoMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoMedicamento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_CodigoMedicamento.Location = new System.Drawing.Point(420, 71);
            this.txt_CodigoMedicamento.Name = "txt_CodigoMedicamento";
            this.txt_CodigoMedicamento.Size = new System.Drawing.Size(208, 15);
            this.txt_CodigoMedicamento.TabIndex = 54;
            this.txt_CodigoMedicamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(256, 107);
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
            this.label3.Location = new System.Drawing.Point(256, 146);
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
            this.label4.Location = new System.Drawing.Point(256, 182);
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
            "Pendiente",
            "Progreso",
            "Completado",
            "Suspendido",
            "Cancelado"});
            this.cbox_TipoHabitacion.Location = new System.Drawing.Point(420, 107);
            this.cbox_TipoHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_TipoHabitacion.Name = "cbox_TipoHabitacion";
            this.cbox_TipoHabitacion.Size = new System.Drawing.Size(209, 21);
            this.cbox_TipoHabitacion.TabIndex = 62;
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
            this.txt_Costo.Location = new System.Drawing.Point(420, 148);
            this.txt_Costo.Name = "txt_Costo";
            this.txt_Costo.Size = new System.Drawing.Size(208, 15);
            this.txt_Costo.TabIndex = 63;
            this.txt_Costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Estado
            // 
            this.btn_Estado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_Estado.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_Estado.FormattingEnabled = true;
            this.btn_Estado.Items.AddRange(new object[] {
            "Pendiente",
            "Progreso",
            "Completado",
            "Suspendido",
            "Cancelado"});
            this.btn_Estado.Location = new System.Drawing.Point(420, 182);
            this.btn_Estado.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Estado.Name = "btn_Estado";
            this.btn_Estado.Size = new System.Drawing.Size(209, 21);
            this.btn_Estado.TabIndex = 64;
            // 
            // dgv_Medicamentos
            // 
            this.dgv_Medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medicamentos.Location = new System.Drawing.Point(259, 242);
            this.dgv_Medicamentos.Name = "dgv_Medicamentos";
            this.dgv_Medicamentos.Size = new System.Drawing.Size(645, 150);
            this.dgv_Medicamentos.TabIndex = 65;
            // 
            // btn_Agregar
            // 
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
            // 
            // btn_Editar
            // 
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
            // 
            // btn_Cancelar
            // 
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
            // 
            // btn_Eliminar
            // 
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
            // frm_Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(930, 569);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv_Medicamentos);
            this.Controls.Add(this.btn_Estado);
            this.Controls.Add(this.txt_Costo);
            this.Controls.Add(this.cbox_TipoHabitacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CodigoMedicamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Habitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Habitaciones";
            this.Load += new System.EventHandler(this.frm_Habitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CodigoMedicamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_TipoHabitacion;
        private System.Windows.Forms.TextBox txt_Costo;
        private System.Windows.Forms.ComboBox btn_Estado;
        private System.Windows.Forms.DataGridView dgv_Medicamentos;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private FontAwesome.Sharp.IconButton btn_Editar;
        private FontAwesome.Sharp.IconButton btn_Cancelar;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton btn_Salir;
    }
}