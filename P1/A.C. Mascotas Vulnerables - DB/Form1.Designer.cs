﻿namespace A.C.Mascotas_Vulnerables___DB
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panEncabezado = new System.Windows.Forms.Panel();
            this.btnCerrar = new ns1.BunifuImageButton();
            this.panOpciones = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.arrastrarForma1 = new ns1.BunifuDragControl(this.components);
            this.panPantalla = new System.Windows.Forms.Panel();
            this.rdForma = new ns1.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuDropdown1 = new ns1.BunifuDropdown();
            this.panEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panPantalla.SuspendLayout();
            this.SuspendLayout();
            // 
            // panEncabezado
            // 
            this.panEncabezado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panEncabezado.Controls.Add(this.btnCerrar);
            this.panEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panEncabezado.Name = "panEncabezado";
            this.panEncabezado.Size = new System.Drawing.Size(840, 61);
            this.panEncabezado.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.Equis;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(770, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(58, 38);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panOpciones
            // 
            this.panOpciones.BackColor = System.Drawing.Color.Salmon;
            this.panOpciones.Controls.Add(this.Logo);
            this.panOpciones.Controls.Add(this.lblLogo);
            this.panOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panOpciones.Location = new System.Drawing.Point(0, 61);
            this.panOpciones.Name = "panOpciones";
            this.panOpciones.Size = new System.Drawing.Size(225, 582);
            this.panOpciones.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.mascota;
            this.Logo.Location = new System.Drawing.Point(69, 20);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(90, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLogo.Location = new System.Drawing.Point(19, 110);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(191, 22);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.Text = "A.C. Mascotas Vulnerables";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // arrastrarForma1
            // 
            this.arrastrarForma1.Fixed = true;
            this.arrastrarForma1.Horizontal = true;
            this.arrastrarForma1.TargetControl = this.panEncabezado;
            this.arrastrarForma1.Vertical = true;
            // 
            // panPantalla
            // 
            this.panPantalla.Controls.Add(this.bunifuDropdown1);
            this.panPantalla.Controls.Add(this.bunifuCustomLabel1);
            this.panPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPantalla.Location = new System.Drawing.Point(225, 61);
            this.panPantalla.Name = "panPantalla";
            this.panPantalla.Size = new System.Drawing.Size(615, 582);
            this.panPantalla.TabIndex = 2;
            // 
            // rdForma
            // 
            this.rdForma.ElipseRadius = 35;
            this.rdForma.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(322, 116);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "bunifuCustomLabel1";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(325, 263);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown1.TabIndex = 1;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 643);
            this.Controls.Add(this.panPantalla);
            this.Controls.Add(this.panOpciones);
            this.Controls.Add(this.panEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panOpciones.ResumeLayout(false);
            this.panOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panPantalla.ResumeLayout(false);
            this.panPantalla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panEncabezado;
        private System.Windows.Forms.Panel panOpciones;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lblLogo;
        private ns1.BunifuImageButton btnCerrar;
        private ns1.BunifuDragControl arrastrarForma1;
        private System.Windows.Forms.Panel panPantalla;
        private ns1.BunifuElipse rdForma;
        private ns1.BunifuDropdown bunifuDropdown1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
    }
}

