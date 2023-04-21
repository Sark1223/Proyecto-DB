namespace A.C.Mascotas_Vulnerables___DB
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
            this.panOpciones = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.panPantalla = new System.Windows.Forms.Panel();
            this.panEncabezado.SuspendLayout();
            this.panOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panEncabezado
            // 
            this.panEncabezado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panEncabezado.Controls.Add(this.bunifuImageButton1);
            this.panEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panEncabezado.Name = "panEncabezado";
            this.panEncabezado.Size = new System.Drawing.Size(840, 61);
            this.panEncabezado.TabIndex = 0;
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
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLogo.Location = new System.Drawing.Point(9, 110);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(212, 29);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.Text = "A.C. Mascotas Vulnerables";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
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
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.cerrar;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(770, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 38);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panEncabezado;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panPantalla
            // 
            this.panPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPantalla.Location = new System.Drawing.Point(225, 61);
            this.panPantalla.Name = "panPantalla";
            this.panPantalla.Size = new System.Drawing.Size(615, 582);
            this.panPantalla.TabIndex = 2;
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
            this.Text = "Form1";
            this.panEncabezado.ResumeLayout(false);
            this.panOpciones.ResumeLayout(false);
            this.panOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panEncabezado;
        private System.Windows.Forms.Panel panOpciones;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lblLogo;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panPantalla;
    }
}

