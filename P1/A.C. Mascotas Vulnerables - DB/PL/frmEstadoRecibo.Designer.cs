namespace A.C.Mascotas_Vulnerables___DB.PL
{
    partial class frmEstadoRecibo
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
            this.encabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdCerrar = new ns1.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // encabezado
            // 
            this.encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(203)))));
            this.encabezado.Controls.Add(this.pictureBox1);
            this.encabezado.Controls.Add(this.cmdCerrar);
            this.encabezado.Controls.Add(this.label3);
            this.encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.encabezado.Location = new System.Drawing.Point(0, 0);
            this.encabezado.Name = "encabezado";
            this.encabezado.Size = new System.Drawing.Size(351, 39);
            this.encabezado.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.perro;
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.BackColor = System.Drawing.Color.Transparent;
            this.cmdCerrar.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.Equis;
            this.cmdCerrar.ImageActive = null;
            this.cmdCerrar.Location = new System.Drawing.Point(292, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(40, 29);
            this.cmdCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdCerrar.TabIndex = 0;
            this.cmdCerrar.TabStop = false;
            this.cmdCerrar.Zoom = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(98, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Estatus_Recibo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEstadoRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 232);
            this.Controls.Add(this.encabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstadoRecibo";
            this.Text = "frmEstadoRecibo";
            this.encabezado.ResumeLayout(false);
            this.encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel encabezado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuImageButton cmdCerrar;
        private System.Windows.Forms.Label label3;
    }
}