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
            this.pnl_Principal = new System.Windows.Forms.Panel();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_Formularios = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.btn_Minimizar = new FontAwesome.Sharp.IconButton();
            this.btn_Maximizar = new FontAwesome.Sharp.IconButton();
            this.btn_Restaurar = new FontAwesome.Sharp.IconButton();
            this.pnl_Principal.SuspendLayout();
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
            this.pnl_Principal.Size = new System.Drawing.Size(1240, 700);
            this.pnl_Principal.TabIndex = 2;
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
            this.pnl_Titulo.Size = new System.Drawing.Size(1240, 40);
            this.pnl_Titulo.TabIndex = 0;
            this.pnl_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Titulo_MouseMove);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.Orange;
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 40);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(200, 660);
            this.pnl_Menu.TabIndex = 1;
            // 
            // pnl_Formularios
            // 
            this.pnl_Formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Formularios.Location = new System.Drawing.Point(200, 40);
            this.pnl_Formularios.Name = "pnl_Formularios";
            this.pnl_Formularios.Size = new System.Drawing.Size(1040, 660);
            this.pnl_Formularios.TabIndex = 2;
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
            this.btn_Cerrar.Location = new System.Drawing.Point(1207, 9);
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
            this.btn_Minimizar.Location = new System.Drawing.Point(1153, 9);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(21, 25);
            this.btn_Minimizar.TabIndex = 21;
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
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
            this.btn_Maximizar.Location = new System.Drawing.Point(1180, 9);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(21, 25);
            this.btn_Maximizar.TabIndex = 23;
            this.btn_Maximizar.UseVisualStyleBackColor = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
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
            this.btn_Restaurar.Location = new System.Drawing.Point(1180, 9);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(21, 25);
            this.btn_Restaurar.TabIndex = 24;
            this.btn_Restaurar.UseVisualStyleBackColor = false;
            this.btn_Restaurar.Visible = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1240, 700);
            this.Controls.Add(this.pnl_Principal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.pnl_Principal.ResumeLayout(false);
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
    }
}