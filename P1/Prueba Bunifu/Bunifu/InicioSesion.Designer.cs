namespace Bunifu
{
    partial class InicioSesion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.Logo = new System.Windows.Forms.PictureBox();
            this.lblNombreEmp = new System.Windows.Forms.Label();
            this.lblMensaje1 = new System.Windows.Forms.Label();
            this.txtId = new ns1.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.txtContra = new ns1.BunifuMaterialTextbox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCerrar = new ns1.BunifuImageButton();
            this.lblContra = new System.Windows.Forms.Label();
            this.btnIniciar = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(30, 34);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(90, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            // 
            // lblNombreEmp
            // 
            this.lblNombreEmp.AutoSize = true;
            this.lblNombreEmp.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmp.ForeColor = System.Drawing.Color.White;
            this.lblNombreEmp.Location = new System.Drawing.Point(137, 60);
            this.lblNombreEmp.Name = "lblNombreEmp";
            this.lblNombreEmp.Size = new System.Drawing.Size(212, 29);
            this.lblNombreEmp.TabIndex = 10;
            this.lblNombreEmp.Text = "A.C. Mascotas Vulnerables\r\n";
            this.lblNombreEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje1.ForeColor = System.Drawing.Color.White;
            this.lblMensaje1.Location = new System.Drawing.Point(163, 138);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(177, 58);
            this.lblMensaje1.TabIndex = 12;
            this.lblMensaje1.Text = "Bienvenido\r\nFavor de Identificarse\r\n";
            this.lblMensaje1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.HintForeColor = System.Drawing.Color.Transparent;
            this.txtId.HintText = "";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.Pink;
            this.txtId.LineIdleColor = System.Drawing.Color.White;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtId.LineThickness = 5;
            this.txtId.Location = new System.Drawing.Point(111, 261);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(263, 44);
            this.txtId.TabIndex = 14;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtContra
            // 
            this.txtContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.Color.Black;
            this.txtContra.HintForeColor = System.Drawing.Color.Empty;
            this.txtContra.HintText = "";
            this.txtContra.isPassword = true;
            this.txtContra.LineFocusedColor = System.Drawing.Color.Pink;
            this.txtContra.LineIdleColor = System.Drawing.Color.White;
            this.txtContra.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtContra.LineThickness = 5;
            this.txtContra.Location = new System.Drawing.Point(112, 376);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(263, 44);
            this.txtContra.TabIndex = 15;
            this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContra.OnValueChanged += new System.EventHandler(this.txtContra_OnValueChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(148, 239);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(201, 29);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Codigo de Identificacion\r\n";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageActive")));
            this.btnCerrar.Location = new System.Drawing.Point(427, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseHover += new System.EventHandler(this.bunifuImageButton1_MouseHover);
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.White;
            this.lblContra.Location = new System.Drawing.Point(195, 354);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(99, 29);
            this.lblContra.TabIndex = 18;
            this.lblContra.Text = "Contraseña";
            this.lblContra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            this.btnIniciar.ActiveBorderThickness = 1;
            this.btnIniciar.ActiveCornerRadius = 20;
            this.btnIniciar.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btnIniciar.ActiveForecolor = System.Drawing.Color.White;
            this.btnIniciar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnIniciar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciar.BackgroundImage")));
            this.btnIniciar.ButtonText = "Iniciar Sesion";
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnIniciar.IdleBorderThickness = 1;
            this.btnIniciar.IdleCornerRadius = 20;
            this.btnIniciar.IdleFillColor = System.Drawing.Color.White;
            this.btnIniciar.IdleForecolor = System.Drawing.Color.Black;
            this.btnIniciar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnIniciar.Location = new System.Drawing.Point(164, 449);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(171, 43);
            this.btnIniciar.TabIndex = 19;
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(489, 521);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblMensaje1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.lblNombreEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lblNombreEmp;
        private ns1.BunifuMaterialTextbox txtId;
        private System.Windows.Forms.Label lblMensaje1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuMaterialTextbox txtContra;
        private System.Windows.Forms.Label lblId;
        private ns1.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Label lblContra;
        private ns1.BunifuThinButton2 btnIniciar;
    }
}