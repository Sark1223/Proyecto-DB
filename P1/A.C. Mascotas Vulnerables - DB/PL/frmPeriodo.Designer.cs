namespace A.C.Mascotas_Vulnerables___DB.PL
{
    partial class frmPeriodo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeriodo));
            this.encabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdCerrar = new ns1.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPeriodo = new System.Windows.Forms.DataGridView();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.bunifuSeparator5 = new ns1.BunifuSeparator();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtFechaFin = new ns1.BunifuDatepicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtFechaInicio = new ns1.BunifuDatepicker();
            this.rdForma = new ns1.BunifuElipse(this.components);
            this.cmdModificar = new ns1.BunifuThinButton2();
            this.cmdAgregar = new ns1.BunifuThinButton2();
            this.encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).BeginInit();
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
            this.encabezado.Size = new System.Drawing.Size(318, 39);
            this.encabezado.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.perro;
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.BackColor = System.Drawing.Color.Transparent;
            this.cmdCerrar.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.Equis;
            this.cmdCerrar.ImageActive = null;
            this.cmdCerrar.Location = new System.Drawing.Point(274, 4);
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
            this.label3.Location = new System.Drawing.Point(105, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "PERIODO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPeriodo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPeriodo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeriodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPeriodo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.dgvPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPeriodo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeriodo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeriodo.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeriodo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeriodo.EnableHeadersVisualStyles = false;
            this.dgvPeriodo.GridColor = System.Drawing.Color.Chocolate;
            this.dgvPeriodo.Location = new System.Drawing.Point(20, 221);
            this.dgvPeriodo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dgvPeriodo.Name = "dgvPeriodo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(88)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeriodo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeriodo.RowHeadersVisible = false;
            this.dgvPeriodo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPeriodo.RowTemplate.Height = 30;
            this.dgvPeriodo.Size = new System.Drawing.Size(276, 135);
            this.dgvPeriodo.TabIndex = 49;
            this.dgvPeriodo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPeriodo_CellMouseDoubleClick);
            // 
            // txtAño
            // 
            this.txtAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.txtAño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAño.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAño.Location = new System.Drawing.Point(21, 73);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(63, 19);
            this.txtAño.TabIndex = 52;
            this.txtAño.Text = "2023";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.lblPeriodo.Location = new System.Drawing.Point(18, 50);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(38, 18);
            this.lblPeriodo.TabIndex = 51;
            this.lblPeriodo.Text = "Año:";
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(21, 84);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(62, 18);
            this.bunifuSeparator5.TabIndex = 55;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.lblNumero.Location = new System.Drawing.Point(18, 114);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(66, 18);
            this.lblNumero.TabIndex = 53;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumero.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNumero.Location = new System.Drawing.Point(21, 135);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 19);
            this.txtNumero.TabIndex = 56;
            this.txtNumero.Text = "1";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(223)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(22, 147);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(62, 18);
            this.bunifuSeparator1.TabIndex = 57;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.lblFechaFinal.Location = new System.Drawing.Point(116, 113);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(152, 18);
            this.lblFechaFinal.TabIndex = 61;
            this.lblFechaFinal.Text = "Fecha de culminación";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.dtFechaFin.BorderRadius = 0;
            this.dtFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFin.ForeColor = System.Drawing.Color.White;
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.FormatCustom = null;
            this.dtFechaFin.Location = new System.Drawing.Point(119, 133);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(177, 30);
            this.dtFechaFin.TabIndex = 59;
            this.dtFechaFin.Value = new System.DateTime(2023, 4, 30, 22, 40, 42, 977);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(116, 50);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(107, 18);
            this.lblFechaInicio.TabIndex = 60;
            this.lblFechaInicio.Text = "Fecha de inicio";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.dtFechaInicio.BorderRadius = 0;
            this.dtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.ForeColor = System.Drawing.Color.White;
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.FormatCustom = null;
            this.dtFechaInicio.Location = new System.Drawing.Point(119, 69);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(178, 30);
            this.dtFechaInicio.TabIndex = 58;
            this.dtFechaInicio.Value = new System.DateTime(2023, 4, 30, 22, 40, 42, 977);
            // 
            // rdForma
            // 
            this.rdForma.ElipseRadius = 20;
            this.rdForma.TargetControl = this;
            // 
            // cmdModificar
            // 
            this.cmdModificar.ActiveBorderThickness = 1;
            this.cmdModificar.ActiveCornerRadius = 20;
            this.cmdModificar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.cmdModificar.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.cmdModificar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.cmdModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.cmdModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdModificar.BackgroundImage")));
            this.cmdModificar.ButtonText = "Modificar";
            this.cmdModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdModificar.IdleBorderThickness = 1;
            this.cmdModificar.IdleCornerRadius = 20;
            this.cmdModificar.IdleFillColor = System.Drawing.Color.Purple;
            this.cmdModificar.IdleForecolor = System.Drawing.Color.White;
            this.cmdModificar.IdleLineColor = System.Drawing.Color.Purple;
            this.cmdModificar.Location = new System.Drawing.Point(176, 174);
            this.cmdModificar.Margin = new System.Windows.Forms.Padding(5);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(105, 37);
            this.cmdModificar.TabIndex = 63;
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.ActiveBorderThickness = 1;
            this.cmdAgregar.ActiveCornerRadius = 20;
            this.cmdAgregar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.cmdAgregar.ActiveForecolor = System.Drawing.SystemColors.InfoText;
            this.cmdAgregar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.cmdAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.cmdAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.BackgroundImage")));
            this.cmdAgregar.ButtonText = "Agregar";
            this.cmdAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdAgregar.IdleBorderThickness = 1;
            this.cmdAgregar.IdleCornerRadius = 20;
            this.cmdAgregar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(45)))));
            this.cmdAgregar.IdleForecolor = System.Drawing.Color.Black;
            this.cmdAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(223)))), ((int)(((byte)(45)))));
            this.cmdAgregar.Location = new System.Drawing.Point(38, 174);
            this.cmdAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(105, 37);
            this.cmdAgregar.TabIndex = 62;
            this.cmdAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // frmPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(126)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(318, 377);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.bunifuSeparator5);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.dgvPeriodo);
            this.Controls.Add(this.encabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPeriodo";
            this.Text = "frmPeriodo";
            this.Load += new System.EventHandler(this.frmPeriodo_Load);
            this.encabezado.ResumeLayout(false);
            this.encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel encabezado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuImageButton cmdCerrar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvPeriodo;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblPeriodo;
        private ns1.BunifuSeparator bunifuSeparator5;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private ns1.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.Label lblFechaFinal;
        public ns1.BunifuDatepicker dtFechaFin;
        public System.Windows.Forms.Label lblFechaInicio;
        public ns1.BunifuDatepicker dtFechaInicio;
        private ns1.BunifuElipse rdForma;
        private ns1.BunifuThinButton2 cmdModificar;
        private ns1.BunifuThinButton2 cmdAgregar;
    }
}