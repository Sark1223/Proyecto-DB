namespace A.C.Mascotas_Vulnerables___DB
{
    partial class frmMenu_Principal
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu_Principal));
            this.panEncabezado = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panOpciones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panPantalla = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdLocalizacion = new System.Windows.Forms.Button();
            this.rdForma = new ns1.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.rdLocation = new ns1.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdPeriodo = new System.Windows.Forms.Button();
            this.rdPeriodo = new ns1.BunifuElipse(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmdAdministra = new ns1.BunifuThinButton2();
            this.cmdSocios = new ns1.BunifuThinButton2();
            this.cmdIniciar = new ns1.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new ns1.BunifuImageButton();
            this.panEncabezado.SuspendLayout();
            this.panOpciones.SuspendLayout();
            this.panPantalla.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panEncabezado
            // 
            this.panEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(109)))));
            this.panEncabezado.Controls.Add(this.lblLogo);
            this.panEncabezado.Controls.Add(this.Logo);
            this.panEncabezado.Controls.Add(this.btnCerrar);
            this.panelTransition.SetDecoration(this.panEncabezado, BunifuAnimatorNS.DecorationType.None);
            this.panEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panEncabezado.Name = "panEncabezado";
            this.panEncabezado.Size = new System.Drawing.Size(771, 40);
            this.panEncabezado.TabIndex = 0;
            this.panEncabezado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.panelTransition.SetDecoration(this.lblLogo, BunifuAnimatorNS.DecorationType.None);
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLogo.Location = new System.Drawing.Point(43, 6);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(200, 20);
            this.lblLogo.TabIndex = 15;
            this.lblLogo.Text = "A.C. Mascotas Vulnerables";
            // 
            // panOpciones
            // 
            this.panOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.panOpciones.Controls.Add(this.button1);
            this.panOpciones.Controls.Add(this.label1);
            this.panOpciones.Controls.Add(this.txtPuesto);
            this.panOpciones.Controls.Add(this.pbUsuario);
            this.panOpciones.Controls.Add(this.txtUsuario);
            this.panelTransition.SetDecoration(this.panOpciones, BunifuAnimatorNS.DecorationType.None);
            this.panOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panOpciones.Location = new System.Drawing.Point(0, 40);
            this.panOpciones.Name = "panOpciones";
            this.panOpciones.Size = new System.Drawing.Size(104, 353);
            this.panOpciones.TabIndex = 1;
            // 
            // button1
            // 
            this.panelTransition.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.panelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cargo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPuesto
            // 
            this.txtPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelTransition.SetDecoration(this.txtPuesto, BunifuAnimatorNS.DecorationType.None);
            this.txtPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPuesto.ForeColor = System.Drawing.Color.White;
            this.txtPuesto.Location = new System.Drawing.Point(3, 125);
            this.txtPuesto.Multiline = true;
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.ReadOnly = true;
            this.txtPuesto.Size = new System.Drawing.Size(93, 52);
            this.txtPuesto.TabIndex = 23;
            this.txtPuesto.TabStop = false;
            this.txtPuesto.Text = "Asistente\r\nadministrativo";
            this.txtPuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelTransition.SetDecoration(this.txtUsuario, BunifuAnimatorNS.DecorationType.None);
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(1, 77);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(102, 14);
            this.txtUsuario.TabIndex = 22;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.Text = "Santos Karla";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panPantalla
            // 
            this.panPantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.panPantalla.Controls.Add(this.panel3);
            this.panPantalla.Controls.Add(this.pictureBox4);
            this.panPantalla.Controls.Add(this.cmdPeriodo);
            this.panPantalla.Controls.Add(this.panel2);
            this.panPantalla.Controls.Add(this.pictureBox3);
            this.panPantalla.Controls.Add(this.cmdAdministra);
            this.panPantalla.Controls.Add(this.cmdSocios);
            this.panPantalla.Controls.Add(this.cmdIniciar);
            this.panPantalla.Controls.Add(this.lblBienvenido);
            this.panPantalla.Controls.Add(this.pictureBox2);
            this.panPantalla.Controls.Add(this.pictureBox1);
            this.panPantalla.Controls.Add(this.pictureBox5);
            this.panPantalla.Controls.Add(this.label3);
            this.panPantalla.Controls.Add(this.label2);
            this.panPantalla.Controls.Add(this.label4);
            this.panPantalla.Controls.Add(this.cmdLocalizacion);
            this.panelTransition.SetDecoration(this.panPantalla, BunifuAnimatorNS.DecorationType.None);
            this.panPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPantalla.Location = new System.Drawing.Point(104, 40);
            this.panPantalla.Name = "panPantalla";
            this.panPantalla.Size = new System.Drawing.Size(667, 353);
            this.panPantalla.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.panelTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(601, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 48);
            this.panel2.TabIndex = 36;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.panelTransition.SetDecoration(this.lblBienvenido, BunifuAnimatorNS.DecorationType.None);
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.lblBienvenido.Location = new System.Drawing.Point(237, 22);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(200, 26);
            this.lblBienvenido.TabIndex = 30;
            this.lblBienvenido.Text = "MENÚ PRINCIPAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.panelTransition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(319, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Socios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.panelTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(64, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Aportaciones";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.panelTransition.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(512, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Administradores";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdLocalizacion
            // 
            this.cmdLocalizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.panelTransition.SetDecoration(this.cmdLocalizacion, BunifuAnimatorNS.DecorationType.None);
            this.cmdLocalizacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.cmdLocalizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmdLocalizacion.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdLocalizacion.Location = new System.Drawing.Point(476, 13);
            this.cmdLocalizacion.Name = "cmdLocalizacion";
            this.cmdLocalizacion.Size = new System.Drawing.Size(152, 49);
            this.cmdLocalizacion.TabIndex = 37;
            this.cmdLocalizacion.Text = "Nueva Ubicación";
            this.cmdLocalizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdLocalizacion.UseVisualStyleBackColor = false;
            this.cmdLocalizacion.Click += new System.EventHandler(this.cmdLugares_Click);
            // 
            // rdForma
            // 
            this.rdForma.ElipseRadius = 30;
            this.rdForma.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label5);
            this.panelTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 24);
            this.panel1.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.panelTransition.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(196, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(423, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "@Karla Santos, Edwin Villada, Manuel Davila y Erick (Equipo 6)";
            // 
            // panelTransition
            // 
            this.panelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.panelTransition.Cursor = null;
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
            this.panelTransition.DefaultAnimation = animation4;
            this.panelTransition.Interval = 5;
            // 
            // rdLocation
            // 
            this.rdLocation.ElipseRadius = 20;
            this.rdLocation.TargetControl = this.cmdLocalizacion;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.panelTransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(52, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 48);
            this.panel3.TabIndex = 39;
            // 
            // cmdPeriodo
            // 
            this.cmdPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.panelTransition.SetDecoration(this.cmdPeriodo, BunifuAnimatorNS.DecorationType.None);
            this.cmdPeriodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.cmdPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmdPeriodo.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdPeriodo.Location = new System.Drawing.Point(43, 13);
            this.cmdPeriodo.Name = "cmdPeriodo";
            this.cmdPeriodo.Size = new System.Drawing.Size(146, 49);
            this.cmdPeriodo.TabIndex = 40;
            this.cmdPeriodo.Text = "Nuevo Periodo";
            this.cmdPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPeriodo.UseVisualStyleBackColor = false;
            this.cmdPeriodo.Click += new System.EventHandler(this.cmdPeriodo_Click);
            // 
            // rdPeriodo
            // 
            this.rdPeriodo.ElipseRadius = 20;
            this.rdPeriodo.TargetControl = this.cmdPeriodo;
            // 
            // pictureBox4
            // 
            this.panelTransition.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.justicia_social;
            this.pictureBox4.Location = new System.Drawing.Point(3, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.panelTransition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.localizacion;
            this.pictureBox3.Location = new System.Drawing.Point(611, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // cmdAdministra
            // 
            this.cmdAdministra.ActiveBorderThickness = 1;
            this.cmdAdministra.ActiveCornerRadius = 20;
            this.cmdAdministra.ActiveFillColor = System.Drawing.Color.White;
            this.cmdAdministra.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(109)))));
            this.cmdAdministra.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(109)))));
            this.cmdAdministra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.cmdAdministra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAdministra.BackgroundImage")));
            this.cmdAdministra.ButtonText = "IR";
            this.cmdAdministra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.cmdAdministra, BunifuAnimatorNS.DecorationType.None);
            this.cmdAdministra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdministra.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdAdministra.IdleBorderThickness = 1;
            this.cmdAdministra.IdleCornerRadius = 20;
            this.cmdAdministra.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(109)))));
            this.cmdAdministra.IdleForecolor = System.Drawing.Color.White;
            this.cmdAdministra.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(109)))));
            this.cmdAdministra.Location = new System.Drawing.Point(500, 263);
            this.cmdAdministra.Margin = new System.Windows.Forms.Padding(5);
            this.cmdAdministra.Name = "cmdAdministra";
            this.cmdAdministra.Size = new System.Drawing.Size(145, 33);
            this.cmdAdministra.TabIndex = 33;
            this.cmdAdministra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdAdministra.Click += new System.EventHandler(this.cmdAdministra_Click);
            // 
            // cmdSocios
            // 
            this.cmdSocios.ActiveBorderThickness = 1;
            this.cmdSocios.ActiveCornerRadius = 20;
            this.cmdSocios.ActiveFillColor = System.Drawing.Color.White;
            this.cmdSocios.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.cmdSocios.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.cmdSocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.cmdSocios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdSocios.BackgroundImage")));
            this.cmdSocios.ButtonText = "IR";
            this.cmdSocios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.cmdSocios, BunifuAnimatorNS.DecorationType.None);
            this.cmdSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSocios.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdSocios.IdleBorderThickness = 1;
            this.cmdSocios.IdleCornerRadius = 20;
            this.cmdSocios.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.cmdSocios.IdleForecolor = System.Drawing.Color.White;
            this.cmdSocios.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.cmdSocios.Location = new System.Drawing.Point(273, 263);
            this.cmdSocios.Margin = new System.Windows.Forms.Padding(5);
            this.cmdSocios.Name = "cmdSocios";
            this.cmdSocios.Size = new System.Drawing.Size(145, 33);
            this.cmdSocios.TabIndex = 32;
            this.cmdSocios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdSocios.Click += new System.EventHandler(this.cmdSocio);
            // 
            // cmdIniciar
            // 
            this.cmdIniciar.ActiveBorderThickness = 1;
            this.cmdIniciar.ActiveCornerRadius = 20;
            this.cmdIniciar.ActiveFillColor = System.Drawing.Color.White;
            this.cmdIniciar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.cmdIniciar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.cmdIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.cmdIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdIniciar.BackgroundImage")));
            this.cmdIniciar.ButtonText = "IR";
            this.cmdIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.cmdIniciar, BunifuAnimatorNS.DecorationType.None);
            this.cmdIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciar.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdIniciar.IdleBorderThickness = 1;
            this.cmdIniciar.IdleCornerRadius = 20;
            this.cmdIniciar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.cmdIniciar.IdleForecolor = System.Drawing.Color.White;
            this.cmdIniciar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.cmdIniciar.Location = new System.Drawing.Point(43, 263);
            this.cmdIniciar.Margin = new System.Windows.Forms.Padding(5);
            this.cmdIniciar.Name = "cmdIniciar";
            this.cmdIniciar.Size = new System.Drawing.Size(145, 33);
            this.cmdIniciar.TabIndex = 31;
            this.cmdIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdIniciar.Click += new System.EventHandler(this.cmdIniciar_Click);
            // 
            // pictureBox2
            // 
            this.panelTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(490, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.panelTransition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.panelTransition.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.hucha;
            this.pictureBox5.Location = new System.Drawing.Point(263, 87);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(165, 148);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pbUsuario
            // 
            this.panelTransition.SetDecoration(this.pbUsuario, BunifuAnimatorNS.DecorationType.None);
            this.pbUsuario.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.mujer__1_;
            this.pbUsuario.Location = new System.Drawing.Point(10, 3);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(78, 75);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 15;
            this.pbUsuario.TabStop = false;
            // 
            // Logo
            // 
            this.panelTransition.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.perro;
            this.Logo.Location = new System.Drawing.Point(10, 6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(30, 27);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 14;
            this.Logo.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.panelTransition.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.Equis;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(729, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmMenu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 417);
            this.Controls.Add(this.panPantalla);
            this.Controls.Add(this.panOpciones);
            this.Controls.Add(this.panEncabezado);
            this.Controls.Add(this.panel1);
            this.panelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMenu_Principal_Load);
            this.panEncabezado.ResumeLayout(false);
            this.panEncabezado.PerformLayout();
            this.panOpciones.ResumeLayout(false);
            this.panOpciones.PerformLayout();
            this.panPantalla.ResumeLayout(false);
            this.panPantalla.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.BunifuImageButton btnCerrar;
        private ns1.BunifuElipse rdForma;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lblLogo;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuThinButton2 cmdIniciar;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuThinButton2 cmdAdministra;
        private ns1.BunifuThinButton2 cmdSocios;
        public BunifuAnimatorNS.BunifuTransition panelTransition;
        public System.Windows.Forms.Panel panEncabezado;
        public System.Windows.Forms.Panel panOpciones;
        public System.Windows.Forms.Panel panPantalla;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdLocalizacion;
        private ns1.BunifuElipse rdLocation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button cmdPeriodo;
        private ns1.BunifuElipse rdPeriodo;
    }
}

