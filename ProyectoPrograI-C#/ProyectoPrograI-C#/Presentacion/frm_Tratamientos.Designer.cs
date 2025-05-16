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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.btn_Disminuir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Costo_Tratamientos = new System.Windows.Forms.TextBox();
            this.dtp_Fecha_Vencimiento_Tratamientos = new System.Windows.Forms.DateTimePicker();
            this.cbx_Estado_Tratamientos = new System.Windows.Forms.ComboBox();
            this.txt_Codigo_Cita = new System.Windows.Forms.TextBox();
            this.txt_Codigo_Medicamento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.dgv_Tratamientos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(387, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "ESTADO:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(387, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "FECHA VENCIMIENTO:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(387, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "COSTO:";
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
            this.label2.Location = new System.Drawing.Point(387, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "CODIGO CITA:";
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
            this.btn_Cerrar.Location = new System.Drawing.Point(1006, 15);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(28, 31);
            this.btn_Cerrar.TabIndex = 33;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Disminuir
            // 
            this.btn_Disminuir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Disminuir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Disminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Disminuir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Disminuir.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_Disminuir.IconColor = System.Drawing.SystemColors.GrayText;
            this.btn_Disminuir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Disminuir.IconSize = 25;
            this.btn_Disminuir.Location = new System.Drawing.Point(970, 15);
            this.btn_Disminuir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Disminuir.Name = "btn_Disminuir";
            this.btn_Disminuir.Size = new System.Drawing.Size(28, 31);
            this.btn_Disminuir.TabIndex = 32;
            this.btn_Disminuir.UseVisualStyleBackColor = false;
            this.btn_Disminuir.Click += new System.EventHandler(this.btn_Disminuir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(586, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
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
            this.label6.Location = new System.Drawing.Point(387, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "CODIGO MEDICAMENTO:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Costo_Tratamientos
            // 
            this.txt_Costo_Tratamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Costo_Tratamientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Costo_Tratamientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Costo_Tratamientos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Costo_Tratamientos.Location = new System.Drawing.Point(609, 127);
            this.txt_Costo_Tratamientos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Costo_Tratamientos.Name = "txt_Costo_Tratamientos";
            this.txt_Costo_Tratamientos.Size = new System.Drawing.Size(399, 26);
            this.txt_Costo_Tratamientos.TabIndex = 37;
            this.txt_Costo_Tratamientos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_Fecha_Vencimiento_Tratamientos
            // 
            this.dtp_Fecha_Vencimiento_Tratamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Fecha_Vencimiento_Tratamientos.Location = new System.Drawing.Point(609, 168);
            this.dtp_Fecha_Vencimiento_Tratamientos.Name = "dtp_Fecha_Vencimiento_Tratamientos";
            this.dtp_Fecha_Vencimiento_Tratamientos.Size = new System.Drawing.Size(399, 22);
            this.dtp_Fecha_Vencimiento_Tratamientos.TabIndex = 39;
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
            "Activo",
            "Inactivo"});
            this.cbx_Estado_Tratamientos.Location = new System.Drawing.Point(609, 206);
            this.cbx_Estado_Tratamientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Estado_Tratamientos.Name = "cbx_Estado_Tratamientos";
            this.cbx_Estado_Tratamientos.Size = new System.Drawing.Size(399, 24);
            this.cbx_Estado_Tratamientos.TabIndex = 40;
            // 
            // txt_Codigo_Cita
            // 
            this.txt_Codigo_Cita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Codigo_Cita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Codigo_Cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Cita.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Codigo_Cita.Location = new System.Drawing.Point(609, 56);
            this.txt_Codigo_Cita.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Codigo_Cita.Name = "txt_Codigo_Cita";
            this.txt_Codigo_Cita.Size = new System.Drawing.Size(399, 26);
            this.txt_Codigo_Cita.TabIndex = 45;
            this.txt_Codigo_Cita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Codigo_Medicamento
            // 
            this.txt_Codigo_Medicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Codigo_Medicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Codigo_Medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Medicamento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Codigo_Medicamento.Location = new System.Drawing.Point(609, 92);
            this.txt_Codigo_Medicamento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Codigo_Medicamento.Name = "txt_Codigo_Medicamento";
            this.txt_Codigo_Medicamento.Size = new System.Drawing.Size(399, 26);
            this.txt_Codigo_Medicamento.TabIndex = 46;
            this.txt_Codigo_Medicamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.iconPictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 500);
            this.panel1.TabIndex = 47;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Orange;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 244;
            this.iconPictureBox3.Location = new System.Drawing.Point(37, 125);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(261, 244);
            this.iconPictureBox3.TabIndex = 10;
            this.iconPictureBox3.TabStop = false;
            // 
            // dgv_Tratamientos
            // 
            this.dgv_Tratamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Tratamientos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Tratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tratamientos.Location = new System.Drawing.Point(346, 239);
            this.dgv_Tratamientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Tratamientos.Name = "dgv_Tratamientos";
            this.dgv_Tratamientos.RowHeadersWidth = 51;
            this.dgv_Tratamientos.RowTemplate.Height = 24;
            this.dgv_Tratamientos.Size = new System.Drawing.Size(682, 250);
            this.dgv_Tratamientos.TabIndex = 30;
            // 
            // frm_Tratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1040, 500);
            this.Controls.Add(this.dgv_Tratamientos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Codigo_Medicamento);
            this.Controls.Add(this.txt_Codigo_Cita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_Estado_Tratamientos);
            this.Controls.Add(this.dtp_Fecha_Vencimiento_Tratamientos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Costo_Tratamientos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Disminuir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Tratamientos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Tratamientos_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_Cerrar;
        private FontAwesome.Sharp.IconButton btn_Disminuir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Costo_Tratamientos;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Vencimiento_Tratamientos;
        private System.Windows.Forms.ComboBox cbx_Estado_Tratamientos;
        private System.Windows.Forms.TextBox txt_Codigo_Cita;
        private System.Windows.Forms.TextBox txt_Codigo_Medicamento;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.DataGridView dgv_Tratamientos;
    }
}