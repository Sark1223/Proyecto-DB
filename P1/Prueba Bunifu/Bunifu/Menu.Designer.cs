namespace Bunifu
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.PanArriba = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.PanIzquierdo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnMenu = new ns1.BunifuImageButton();
            this.f5 = new ns1.BunifuFlatButton();
            this.f4 = new ns1.BunifuFlatButton();
            this.f3 = new ns1.BunifuFlatButton();
            this.f2 = new ns1.BunifuFlatButton();
            this.f1 = new ns1.BunifuFlatButton();
            this.PanDerecho = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.PanIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanArriba
            // 
            this.PanArriba.BackColor = System.Drawing.Color.Black;
            this.PanArriba.Controls.Add(this.bunifuImageButton1);
            this.LogoTransition.SetDecoration(this.PanArriba, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.PanArriba, BunifuAnimatorNS.DecorationType.None);
            this.PanArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanArriba.Location = new System.Drawing.Point(0, 0);
            this.PanArriba.Name = "PanArriba";
            this.PanArriba.Size = new System.Drawing.Size(1050, 70);
            this.PanArriba.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoTransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(986, 15);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 39);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // PanIzquierdo
            // 
            this.PanIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.PanIzquierdo.Controls.Add(this.Logo);
            this.PanIzquierdo.Controls.Add(this.lblLogo);
            this.PanIzquierdo.Controls.Add(this.btnMenu);
            this.PanIzquierdo.Controls.Add(this.f5);
            this.PanIzquierdo.Controls.Add(this.f4);
            this.PanIzquierdo.Controls.Add(this.f3);
            this.PanIzquierdo.Controls.Add(this.f2);
            this.PanIzquierdo.Controls.Add(this.f1);
            this.LogoTransition.SetDecoration(this.PanIzquierdo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.PanIzquierdo, BunifuAnimatorNS.DecorationType.None);
            this.PanIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanIzquierdo.Location = new System.Drawing.Point(0, 70);
            this.PanIzquierdo.Name = "PanIzquierdo";
            this.PanIzquierdo.Size = new System.Drawing.Size(250, 530);
            this.PanIzquierdo.TabIndex = 1;
            this.PanIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanIzquierdo_Paint);
            // 
            // Logo
            // 
            this.PanelTransition.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(79, 70);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(90, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 9;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblLogo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblLogo, BunifuAnimatorNS.DecorationType.None);
            this.lblLogo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLogo.Location = new System.Drawing.Point(18, 168);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(212, 29);
            this.lblLogo.TabIndex = 8;
            this.lblLogo.Text = "A.C. Mascotas Vulnerables";
            this.lblLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.LogoTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(200, 19);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 40);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 7;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // f5
            // 
            this.f5.Activecolor = System.Drawing.Color.Red;
            this.f5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.f5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f5.BorderRadius = 0;
            this.f5.ButtonText = "bunifuFlatButton5";
            this.f5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.f5, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.f5, BunifuAnimatorNS.DecorationType.None);
            this.f5.DisabledColor = System.Drawing.Color.Gray;
            this.f5.Iconcolor = System.Drawing.Color.Transparent;
            this.f5.Iconimage = ((System.Drawing.Image)(resources.GetObject("f5.Iconimage")));
            this.f5.Iconimage_right = null;
            this.f5.Iconimage_right_Selected = null;
            this.f5.Iconimage_Selected = null;
            this.f5.IconMarginLeft = 0;
            this.f5.IconMarginRight = 0;
            this.f5.IconRightVisible = true;
            this.f5.IconRightZoom = 0D;
            this.f5.IconVisible = true;
            this.f5.IconZoom = 90D;
            this.f5.IsTab = false;
            this.f5.Location = new System.Drawing.Point(0, 431);
            this.f5.Name = "f5";
            this.f5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.f5.OnHovercolor = System.Drawing.Color.Red;
            this.f5.OnHoverTextColor = System.Drawing.Color.White;
            this.f5.selected = false;
            this.f5.Size = new System.Drawing.Size(250, 48);
            this.f5.TabIndex = 4;
            this.f5.Text = "bunifuFlatButton5";
            this.f5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.f5.Textcolor = System.Drawing.Color.White;
            this.f5.TextFont = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // f4
            // 
            this.f4.Activecolor = System.Drawing.Color.Red;
            this.f4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.f4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f4.BorderRadius = 0;
            this.f4.ButtonText = "bunifuFlatButton4";
            this.f4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.f4, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.f4, BunifuAnimatorNS.DecorationType.None);
            this.f4.DisabledColor = System.Drawing.Color.Gray;
            this.f4.Iconcolor = System.Drawing.Color.Transparent;
            this.f4.Iconimage = ((System.Drawing.Image)(resources.GetObject("f4.Iconimage")));
            this.f4.Iconimage_right = null;
            this.f4.Iconimage_right_Selected = null;
            this.f4.Iconimage_Selected = null;
            this.f4.IconMarginLeft = 0;
            this.f4.IconMarginRight = 0;
            this.f4.IconRightVisible = true;
            this.f4.IconRightZoom = 0D;
            this.f4.IconVisible = true;
            this.f4.IconZoom = 90D;
            this.f4.IsTab = false;
            this.f4.Location = new System.Drawing.Point(0, 377);
            this.f4.Name = "f4";
            this.f4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.f4.OnHovercolor = System.Drawing.Color.Red;
            this.f4.OnHoverTextColor = System.Drawing.Color.White;
            this.f4.selected = false;
            this.f4.Size = new System.Drawing.Size(250, 48);
            this.f4.TabIndex = 3;
            this.f4.Text = "bunifuFlatButton4";
            this.f4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.f4.Textcolor = System.Drawing.Color.White;
            this.f4.TextFont = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // f3
            // 
            this.f3.Activecolor = System.Drawing.Color.Red;
            this.f3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.f3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f3.BorderRadius = 0;
            this.f3.ButtonText = "Creacion de Aportacion";
            this.f3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.f3, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.f3, BunifuAnimatorNS.DecorationType.None);
            this.f3.DisabledColor = System.Drawing.Color.Gray;
            this.f3.Iconcolor = System.Drawing.Color.Transparent;
            this.f3.Iconimage = ((System.Drawing.Image)(resources.GetObject("f3.Iconimage")));
            this.f3.Iconimage_right = null;
            this.f3.Iconimage_right_Selected = null;
            this.f3.Iconimage_Selected = null;
            this.f3.IconMarginLeft = 0;
            this.f3.IconMarginRight = 0;
            this.f3.IconRightVisible = true;
            this.f3.IconRightZoom = 0D;
            this.f3.IconVisible = true;
            this.f3.IconZoom = 90D;
            this.f3.IsTab = false;
            this.f3.Location = new System.Drawing.Point(0, 323);
            this.f3.Name = "f3";
            this.f3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.f3.OnHovercolor = System.Drawing.Color.Red;
            this.f3.OnHoverTextColor = System.Drawing.Color.White;
            this.f3.selected = false;
            this.f3.Size = new System.Drawing.Size(250, 48);
            this.f3.TabIndex = 2;
            this.f3.Text = "Creacion de Aportacion";
            this.f3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.f3.Textcolor = System.Drawing.Color.White;
            this.f3.TextFont = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // f2
            // 
            this.f2.Activecolor = System.Drawing.Color.Red;
            this.f2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.f2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f2.BorderRadius = 0;
            this.f2.ButtonText = "Registro de Socios";
            this.f2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.f2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.f2, BunifuAnimatorNS.DecorationType.None);
            this.f2.DisabledColor = System.Drawing.Color.Gray;
            this.f2.Iconcolor = System.Drawing.Color.Transparent;
            this.f2.Iconimage = ((System.Drawing.Image)(resources.GetObject("f2.Iconimage")));
            this.f2.Iconimage_right = null;
            this.f2.Iconimage_right_Selected = null;
            this.f2.Iconimage_Selected = null;
            this.f2.IconMarginLeft = 0;
            this.f2.IconMarginRight = 0;
            this.f2.IconRightVisible = true;
            this.f2.IconRightZoom = 0D;
            this.f2.IconVisible = true;
            this.f2.IconZoom = 90D;
            this.f2.IsTab = false;
            this.f2.Location = new System.Drawing.Point(1, 270);
            this.f2.Name = "f2";
            this.f2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.f2.OnHovercolor = System.Drawing.Color.Red;
            this.f2.OnHoverTextColor = System.Drawing.Color.White;
            this.f2.selected = false;
            this.f2.Size = new System.Drawing.Size(249, 48);
            this.f2.TabIndex = 1;
            this.f2.Text = "Registro de Socios";
            this.f2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.f2.Textcolor = System.Drawing.Color.White;
            this.f2.TextFont = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // f1
            // 
            this.f1.Activecolor = System.Drawing.Color.Red;
            this.f1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.f1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f1.BorderRadius = 0;
            this.f1.ButtonText = "Gestion de Socios";
            this.f1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.f1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.f1, BunifuAnimatorNS.DecorationType.None);
            this.f1.DisabledColor = System.Drawing.Color.Gray;
            this.f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1.ForeColor = System.Drawing.Color.Black;
            this.f1.Iconcolor = System.Drawing.Color.Transparent;
            this.f1.Iconimage = ((System.Drawing.Image)(resources.GetObject("f1.Iconimage")));
            this.f1.Iconimage_right = null;
            this.f1.Iconimage_right_Selected = null;
            this.f1.Iconimage_Selected = null;
            this.f1.IconMarginLeft = 0;
            this.f1.IconMarginRight = 0;
            this.f1.IconRightVisible = true;
            this.f1.IconRightZoom = 0D;
            this.f1.IconVisible = true;
            this.f1.IconZoom = 90D;
            this.f1.IsTab = false;
            this.f1.Location = new System.Drawing.Point(0, 215);
            this.f1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.f1.Name = "f1";
            this.f1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.f1.OnHovercolor = System.Drawing.Color.Red;
            this.f1.OnHoverTextColor = System.Drawing.Color.White;
            this.f1.selected = false;
            this.f1.Size = new System.Drawing.Size(250, 48);
            this.f1.TabIndex = 0;
            this.f1.Text = "Gestion de Socios";
            this.f1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.f1.Textcolor = System.Drawing.Color.White;
            this.f1.TextFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1.Click += new System.EventHandler(this.f1_Click);
            // 
            // PanDerecho
            // 
            this.PanDerecho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogoTransition.SetDecoration(this.PanDerecho, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.PanDerecho, BunifuAnimatorNS.DecorationType.None);
            this.PanDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanDerecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanDerecho.Location = new System.Drawing.Point(250, 70);
            this.PanDerecho.Name = "PanDerecho";
            this.PanDerecho.Size = new System.Drawing.Size(800, 530);
            this.PanDerecho.TabIndex = 2;
            this.PanDerecho.Paint += new System.Windows.Forms.PaintEventHandler(this.x2_Paint);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanArriba;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.PanelTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.PanelTransition.DefaultAnimation = animation3;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.LogoTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.PanDerecho);
            this.Controls.Add(this.PanIzquierdo);
            this.Controls.Add(this.PanArriba);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.PanIzquierdo.ResumeLayout(false);
            this.PanIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PanDerecho;
        private System.Windows.Forms.Panel PanIzquierdo;
        private System.Windows.Forms.Panel PanArriba;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuImageButton btnMenu;
        private ns1.BunifuFlatButton f5;
        private ns1.BunifuFlatButton f4;
        private ns1.BunifuFlatButton f3;
        private ns1.BunifuFlatButton f2;
        private ns1.BunifuFlatButton f1;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lblLogo;
    }
}

