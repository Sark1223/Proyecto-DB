﻿namespace A.C.Mascotas_Vulnerables___DB.PL
{
    partial class frmAportacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAportacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rdAportacion = new ns1.BunifuElipse(this.components);
            this.rdpnBusSocio = new ns1.BunifuElipse(this.components);
            this.pnBusfolio = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBusqueda = new System.Windows.Forms.Panel();
            this.cmdIniciar = new ns1.BunifuThinButton2();
            this.rdpnBusFolio = new ns1.BunifuElipse(this.components);
            this.encabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdCerrar = new ns1.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.btnCrearReporte = new ns1.BunifuThinButton2();
            this.btnNuevaAportacion = new ns1.BunifuThinButton2();
            this.btnModificarEstatus = new ns1.BunifuThinButton2();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.imprimirRec = new System.Drawing.Printing.PrintDocument();
            this.pnBusfolio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.pnBusqueda.SuspendLayout();
            this.encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // rdAportacion
            // 
            this.rdAportacion.ElipseRadius = 30;
            this.rdAportacion.TargetControl = this;
            // 
            // rdpnBusSocio
            // 
            this.rdpnBusSocio.ElipseRadius = 20;
            this.rdpnBusSocio.TargetControl = this;
            // 
            // pnBusfolio
            // 
            this.pnBusfolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.pnBusfolio.Controls.Add(this.panel2);
            this.pnBusfolio.Controls.Add(this.Logo);
            this.pnBusfolio.Location = new System.Drawing.Point(7, 29);
            this.pnBusfolio.Name = "pnBusfolio";
            this.pnBusfolio.Size = new System.Drawing.Size(54, 32);
            this.pnBusfolio.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(44, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 32);
            this.panel2.TabIndex = 34;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.lupa__1_;
            this.Logo.Location = new System.Drawing.Point(8, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(30, 27);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 33;
            this.Logo.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(53, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(256, 25);
            this.txtUsuario.TabIndex = 34;
            this.txtUsuario.Text = "1139";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ingrese dato a Buscar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBusqueda
            // 
            this.pnBusqueda.Controls.Add(this.label1);
            this.pnBusqueda.Controls.Add(this.txtUsuario);
            this.pnBusqueda.Controls.Add(this.pnBusfolio);
            this.pnBusqueda.Controls.Add(this.cmdIniciar);
            this.pnBusqueda.Location = new System.Drawing.Point(234, 39);
            this.pnBusqueda.Name = "pnBusqueda";
            this.pnBusqueda.Size = new System.Drawing.Size(352, 73);
            this.pnBusqueda.TabIndex = 36;
            // 
            // cmdIniciar
            // 
            this.cmdIniciar.ActiveBorderThickness = 1;
            this.cmdIniciar.ActiveCornerRadius = 20;
            this.cmdIniciar.ActiveFillColor = System.Drawing.Color.White;
            this.cmdIniciar.ActiveForecolor = System.Drawing.Color.White;
            this.cmdIniciar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.cmdIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.cmdIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdIniciar.BackgroundImage")));
            this.cmdIniciar.ButtonText = "IR";
            this.cmdIniciar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmdIniciar.Enabled = false;
            this.cmdIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciar.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdIniciar.IdleBorderThickness = 1;
            this.cmdIniciar.IdleCornerRadius = 20;
            this.cmdIniciar.IdleFillColor = System.Drawing.Color.White;
            this.cmdIniciar.IdleForecolor = System.Drawing.Color.White;
            this.cmdIniciar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.cmdIniciar.Location = new System.Drawing.Point(6, 23);
            this.cmdIniciar.Margin = new System.Windows.Forms.Padding(5);
            this.cmdIniciar.Name = "cmdIniciar";
            this.cmdIniciar.Size = new System.Drawing.Size(328, 42);
            this.cmdIniciar.TabIndex = 32;
            this.cmdIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdpnBusFolio
            // 
            this.rdpnBusFolio.ElipseRadius = 20;
            this.rdpnBusFolio.TargetControl = this.pnBusfolio;
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
            this.encabezado.Size = new System.Drawing.Size(800, 39);
            this.encabezado.TabIndex = 47;
            this.encabezado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.perro;
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.BackColor = System.Drawing.Color.Transparent;
            this.cmdCerrar.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.Equis;
            this.cmdCerrar.ImageActive = null;
            this.cmdCerrar.Location = new System.Drawing.Point(748, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(40, 29);
            this.cmdCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdCerrar.TabIndex = 0;
            this.cmdCerrar.TabStop = false;
            this.cmdCerrar.Zoom = 10;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(366, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "RECIBOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 25;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Imprimir";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 25;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(407, 121);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(141, 38);
            this.bunifuThinButton21.TabIndex = 48;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnCrearReporte
            // 
            this.btnCrearReporte.ActiveBorderThickness = 1;
            this.btnCrearReporte.ActiveCornerRadius = 25;
            this.btnCrearReporte.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.btnCrearReporte.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(200)))), ((int)(((byte)(72)))));
            this.btnCrearReporte.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(200)))), ((int)(((byte)(72)))));
            this.btnCrearReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.btnCrearReporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearReporte.BackgroundImage")));
            this.btnCrearReporte.ButtonText = "Crear Reporte";
            this.btnCrearReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReporte.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCrearReporte.IdleBorderThickness = 1;
            this.btnCrearReporte.IdleCornerRadius = 25;
            this.btnCrearReporte.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(109)))));
            this.btnCrearReporte.IdleForecolor = System.Drawing.Color.Black;
            this.btnCrearReporte.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(109)))));
            this.btnCrearReporte.Location = new System.Drawing.Point(32, 121);
            this.btnCrearReporte.Margin = new System.Windows.Forms.Padding(5);
            this.btnCrearReporte.Name = "btnCrearReporte";
            this.btnCrearReporte.Size = new System.Drawing.Size(141, 38);
            this.btnCrearReporte.TabIndex = 39;
            this.btnCrearReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevaAportacion
            // 
            this.btnNuevaAportacion.ActiveBorderThickness = 1;
            this.btnNuevaAportacion.ActiveCornerRadius = 25;
            this.btnNuevaAportacion.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.btnNuevaAportacion.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.btnNuevaAportacion.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.btnNuevaAportacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.btnNuevaAportacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevaAportacion.BackgroundImage")));
            this.btnNuevaAportacion.ButtonText = "Nueva Aportacion";
            this.btnNuevaAportacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaAportacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaAportacion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNuevaAportacion.IdleBorderThickness = 1;
            this.btnNuevaAportacion.IdleCornerRadius = 25;
            this.btnNuevaAportacion.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.btnNuevaAportacion.IdleForecolor = System.Drawing.Color.White;
            this.btnNuevaAportacion.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.btnNuevaAportacion.Location = new System.Drawing.Point(212, 121);
            this.btnNuevaAportacion.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevaAportacion.Name = "btnNuevaAportacion";
            this.btnNuevaAportacion.Size = new System.Drawing.Size(157, 38);
            this.btnNuevaAportacion.TabIndex = 38;
            this.btnNuevaAportacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevaAportacion.Click += new System.EventHandler(this.cmdAportacion);
            // 
            // btnModificarEstatus
            // 
            this.btnModificarEstatus.ActiveBorderThickness = 1;
            this.btnModificarEstatus.ActiveCornerRadius = 25;
            this.btnModificarEstatus.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.btnModificarEstatus.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnModificarEstatus.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnModificarEstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.btnModificarEstatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarEstatus.BackgroundImage")));
            this.btnModificarEstatus.ButtonText = "Modificar (estatus)";
            this.btnModificarEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEstatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModificarEstatus.IdleBorderThickness = 1;
            this.btnModificarEstatus.IdleCornerRadius = 25;
            this.btnModificarEstatus.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnModificarEstatus.IdleForecolor = System.Drawing.Color.Black;
            this.btnModificarEstatus.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnModificarEstatus.Location = new System.Drawing.Point(592, 121);
            this.btnModificarEstatus.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificarEstatus.Name = "btnModificarEstatus";
            this.btnModificarEstatus.Size = new System.Drawing.Size(172, 38);
            this.btnModificarEstatus.TabIndex = 37;
            this.btnModificarEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificarEstatus.Click += new System.EventHandler(this.btnModificarEstatus_Click);
            // 
            // dgvRecibos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRecibos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecibos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRecibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRecibos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.dgvRecibos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecibos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRecibos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecibos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecibos.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecibos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecibos.EnableHeadersVisualStyles = false;
            this.dgvRecibos.Location = new System.Drawing.Point(26, 167);
            this.dgvRecibos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dgvRecibos.Name = "dgvRecibos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(88)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecibos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecibos.RowHeadersVisible = false;
            this.dgvRecibos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRecibos.RowTemplate.Height = 30;
            this.dgvRecibos.Size = new System.Drawing.Size(744, 255);
            this.dgvRecibos.TabIndex = 51;
            this.dgvRecibos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecibos_CellMouseClick);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(18, 77);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(761, 10);
            this.bunifuSeparator1.TabIndex = 52;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // frmAportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.dgvRecibos);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.encabezado);
            this.Controls.Add(this.btnCrearReporte);
            this.Controls.Add(this.btnNuevaAportacion);
            this.Controls.Add(this.btnModificarEstatus);
            this.Controls.Add(this.pnBusqueda);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAportacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAportacion";
            this.Load += new System.EventHandler(this.frmAportacion_Load);
            this.pnBusfolio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.pnBusqueda.ResumeLayout(false);
            this.pnBusqueda.PerformLayout();
            this.encabezado.ResumeLayout(false);
            this.encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.BunifuThinButton2 btnModificarEstatus;
        private ns1.BunifuThinButton2 btnNuevaAportacion;
        private ns1.BunifuThinButton2 btnCrearReporte;
        private ns1.BunifuElipse rdAportacion;
        private ns1.BunifuElipse rdpnBusSocio;
        private System.Windows.Forms.Panel pnBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnBusfolio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Logo;
        private ns1.BunifuThinButton2 cmdIniciar;
        private ns1.BunifuElipse rdpnBusFolio;
        private System.Windows.Forms.Panel encabezado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuImageButton cmdCerrar;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        public System.Windows.Forms.DataGridView dgvRecibos;
        private ns1.BunifuSeparator bunifuSeparator1;
        private System.Drawing.Printing.PrintDocument imprimirRec;
    }
}