﻿namespace ProyectoPrograI_C_.Presentacion
{
    partial class frm_Medicamentos
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
            this.btn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.btn_Disminuir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Tipo_Medicamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Costo_Medicamentos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Fecha_Vencimiento_Medicamentos = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_Estado_Medicamentos = new System.Windows.Forms.ComboBox();
            this.dgv_Medicamentos = new System.Windows.Forms.DataGridView();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_Cancelar = new FontAwesome.Sharp.IconButton();
            this.btn_Editar = new FontAwesome.Sharp.IconButton();
            this.btn_Agregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_Cerrar.Location = new System.Drawing.Point(1006, 13);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(28, 31);
            this.btn_Cerrar.TabIndex = 20;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.btn_Disminuir.Location = new System.Drawing.Point(970, 13);
            this.btn_Disminuir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Disminuir.Name = "btn_Disminuir";
            this.btn_Disminuir.Size = new System.Drawing.Size(28, 31);
            this.btn_Disminuir.TabIndex = 19;
            this.btn_Disminuir.UseVisualStyleBackColor = false;
            this.btn_Disminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(586, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "MEDICAMENTOS";
            // 
            // cbx_Tipo_Medicamento
            // 
            this.cbx_Tipo_Medicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Tipo_Medicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbx_Tipo_Medicamento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_Tipo_Medicamento.FormattingEnabled = true;
            this.cbx_Tipo_Medicamento.Items.AddRange(new object[] {
            "Jarabe",
            "Suero",
            "Crema",
            "Tableta",
            "Aerosol",
            "Inyeccion"});
            this.cbx_Tipo_Medicamento.Location = new System.Drawing.Point(592, 66);
            this.cbx_Tipo_Medicamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Tipo_Medicamento.Name = "cbx_Tipo_Medicamento";
            this.cbx_Tipo_Medicamento.Size = new System.Drawing.Size(399, 24);
            this.cbx_Tipo_Medicamento.TabIndex = 21;
            this.cbx_Tipo_Medicamento.SelectedIndexChanged += new System.EventHandler(this.cbx_Tipo_Medicamento_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(387, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "TIPO MEDICAMENTO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(387, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "COSTO:";
            // 
            // txt_Costo_Medicamentos
            // 
            this.txt_Costo_Medicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Costo_Medicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Costo_Medicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Costo_Medicamentos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Costo_Medicamentos.Location = new System.Drawing.Point(592, 105);
            this.txt_Costo_Medicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Costo_Medicamentos.Name = "txt_Costo_Medicamentos";
            this.txt_Costo_Medicamentos.Size = new System.Drawing.Size(399, 26);
            this.txt_Costo_Medicamentos.TabIndex = 24;
            this.txt_Costo_Medicamentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(387, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "FECHA VENCIMIENTO:";
            // 
            // dtp_Fecha_Vencimiento_Medicamentos
            // 
            this.dtp_Fecha_Vencimiento_Medicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Fecha_Vencimiento_Medicamentos.Location = new System.Drawing.Point(592, 146);
            this.dtp_Fecha_Vencimiento_Medicamentos.Name = "dtp_Fecha_Vencimiento_Medicamentos";
            this.dtp_Fecha_Vencimiento_Medicamentos.Size = new System.Drawing.Size(399, 22);
            this.dtp_Fecha_Vencimiento_Medicamentos.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(387, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "ESTADO:";
            // 
            // cbx_Estado_Medicamentos
            // 
            this.cbx_Estado_Medicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Estado_Medicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cbx_Estado_Medicamentos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_Estado_Medicamentos.FormattingEnabled = true;
            this.cbx_Estado_Medicamentos.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_Estado_Medicamentos.Location = new System.Drawing.Point(592, 184);
            this.cbx_Estado_Medicamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Estado_Medicamentos.Name = "cbx_Estado_Medicamentos";
            this.cbx_Estado_Medicamentos.Size = new System.Drawing.Size(399, 24);
            this.cbx_Estado_Medicamentos.TabIndex = 27;
            // 
            // dgv_Medicamentos
            // 
            this.dgv_Medicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Medicamentos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medicamentos.Location = new System.Drawing.Point(346, 268);
            this.dgv_Medicamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Medicamentos.Name = "dgv_Medicamentos";
            this.dgv_Medicamentos.RowHeadersWidth = 51;
            this.dgv_Medicamentos.RowTemplate.Height = 24;
            this.dgv_Medicamentos.Size = new System.Drawing.Size(682, 365);
            this.dgv_Medicamentos.TabIndex = 29;
            this.dgv_Medicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Medicamentos_CellClick);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Orange;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Pills;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 244;
            this.iconPictureBox3.Location = new System.Drawing.Point(28, 239);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(261, 244);
            this.iconPictureBox3.TabIndex = 10;
            this.iconPictureBox3.TabStop = false;
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
            this.panel1.Size = new System.Drawing.Size(333, 700);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_Eliminar.IconColor = System.Drawing.Color.Black;
            this.btn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Eliminar.IconSize = 35;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(926, 649);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(102, 39);
            this.btn_Eliminar.TabIndex = 30;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btn_Cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cancelar.IconSize = 35;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(926, 224);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(102, 39);
            this.btn_Cancelar.TabIndex = 31;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btn_Editar.IconColor = System.Drawing.Color.Black;
            this.btn_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Editar.IconSize = 35;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(818, 224);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(102, 39);
            this.btn_Editar.TabIndex = 32;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_Agregar.IconColor = System.Drawing.Color.Black;
            this.btn_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Agregar.IconSize = 35;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(710, 224);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(102, 39);
            this.btn_Agregar.TabIndex = 33;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // frm_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1040, 700);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dgv_Medicamentos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_Estado_Medicamentos);
            this.Controls.Add(this.dtp_Fecha_Vencimiento_Medicamentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Costo_Medicamentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_Tipo_Medicamento);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Disminuir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Medicamentos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Medicamentos";
            this.Load += new System.EventHandler(this.frm_Medicamentos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Medicamentos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_Cerrar;
        private FontAwesome.Sharp.IconButton btn_Disminuir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Tipo_Medicamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Costo_Medicamentos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Vencimiento_Medicamentos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_Estado_Medicamentos;
        private System.Windows.Forms.DataGridView dgv_Medicamentos;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton btn_Cancelar;
        private FontAwesome.Sharp.IconButton btn_Editar;
        private FontAwesome.Sharp.IconButton btn_Agregar;
    }
}