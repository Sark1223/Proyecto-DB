namespace A.C.Mascotas_Vulnerables___DB.PL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAportacion));
            this.dgvProcedimiento = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnBusqueda = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.cmdIniciar = new ns1.BunifuThinButton2();
            this.btnCrearReporte = new ns1.BunifuThinButton2();
            this.btnNuevaAportacion = new ns1.BunifuThinButton2();
            this.btnModificarEstatus = new ns1.BunifuThinButton2();
            this.rdAportacion = new ns1.BunifuElipse(this.components);
            this.btnCerrar = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimiento)).BeginInit();
            this.pnBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcedimiento
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProcedimiento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcedimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProcedimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProcedimiento.BackgroundColor = System.Drawing.Color.White;
            this.dgvProcedimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcedimiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProcedimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcedimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProcedimiento.ColumnHeadersHeight = 30;
            this.dgvProcedimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcedimiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProcedimiento.EnableHeadersVisualStyles = false;
            this.dgvProcedimiento.Location = new System.Drawing.Point(15, 258);
            this.dgvProcedimiento.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dgvProcedimiento.Name = "dgvProcedimiento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(88)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcedimiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProcedimiento.RowHeadersVisible = false;
            this.dgvProcedimiento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProcedimiento.RowTemplate.Height = 30;
            this.dgvProcedimiento.Size = new System.Drawing.Size(744, 175);
            this.dgvProcedimiento.TabIndex = 16;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 23.51233F;
            this.Column3.HeaderText = "No_Paso";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 81;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 176.4876F;
            this.Column4.HeaderText = "Instruccion";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 95;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(51, 11);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(210, 25);
            this.txtUsuario.TabIndex = 34;
            this.txtUsuario.Text = "Santos Karla";
            // 
            // pnBusqueda
            // 
            this.pnBusqueda.Controls.Add(this.txtUsuario);
            this.pnBusqueda.Controls.Add(this.Logo);
            this.pnBusqueda.Controls.Add(this.cmdIniciar);
            this.pnBusqueda.Location = new System.Drawing.Point(12, 154);
            this.pnBusqueda.Name = "pnBusqueda";
            this.pnBusqueda.Size = new System.Drawing.Size(285, 49);
            this.pnBusqueda.TabIndex = 36;
            // 
            // Logo
            // 
            this.Logo.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.lupa__1_;
            this.Logo.Location = new System.Drawing.Point(15, 11);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(30, 27);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 33;
            this.Logo.TabStop = false;
            // 
            // cmdIniciar
            // 
            this.cmdIniciar.ActiveBorderThickness = 1;
            this.cmdIniciar.ActiveCornerRadius = 20;
            this.cmdIniciar.ActiveFillColor = System.Drawing.Color.White;
            this.cmdIniciar.ActiveForecolor = System.Drawing.Color.White;
            this.cmdIniciar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.cmdIniciar.BackColor = System.Drawing.Color.White;
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
            this.cmdIniciar.Location = new System.Drawing.Point(6, 3);
            this.cmdIniciar.Margin = new System.Windows.Forms.Padding(5);
            this.cmdIniciar.Name = "cmdIniciar";
            this.cmdIniciar.Size = new System.Drawing.Size(269, 42);
            this.cmdIniciar.TabIndex = 32;
            this.cmdIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrearReporte
            // 
            this.btnCrearReporte.ActiveBorderThickness = 1;
            this.btnCrearReporte.ActiveCornerRadius = 20;
            this.btnCrearReporte.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btnCrearReporte.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnCrearReporte.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnCrearReporte.BackColor = System.Drawing.Color.White;
            this.btnCrearReporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearReporte.BackgroundImage")));
            this.btnCrearReporte.ButtonText = "Crear Reporte";
            this.btnCrearReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReporte.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCrearReporte.IdleBorderThickness = 1;
            this.btnCrearReporte.IdleCornerRadius = 20;
            this.btnCrearReporte.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnCrearReporte.IdleForecolor = System.Drawing.Color.Black;
            this.btnCrearReporte.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnCrearReporte.Location = new System.Drawing.Point(410, 213);
            this.btnCrearReporte.Margin = new System.Windows.Forms.Padding(5);
            this.btnCrearReporte.Name = "btnCrearReporte";
            this.btnCrearReporte.Size = new System.Drawing.Size(172, 49);
            this.btnCrearReporte.TabIndex = 39;
            this.btnCrearReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevaAportacion
            // 
            this.btnNuevaAportacion.ActiveBorderThickness = 1;
            this.btnNuevaAportacion.ActiveCornerRadius = 20;
            this.btnNuevaAportacion.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btnNuevaAportacion.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnNuevaAportacion.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnNuevaAportacion.BackColor = System.Drawing.Color.White;
            this.btnNuevaAportacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevaAportacion.BackgroundImage")));
            this.btnNuevaAportacion.ButtonText = "Nueva Aportacion";
            this.btnNuevaAportacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaAportacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaAportacion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNuevaAportacion.IdleBorderThickness = 1;
            this.btnNuevaAportacion.IdleCornerRadius = 20;
            this.btnNuevaAportacion.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnNuevaAportacion.IdleForecolor = System.Drawing.Color.Black;
            this.btnNuevaAportacion.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnNuevaAportacion.Location = new System.Drawing.Point(500, 157);
            this.btnNuevaAportacion.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevaAportacion.Name = "btnNuevaAportacion";
            this.btnNuevaAportacion.Size = new System.Drawing.Size(172, 49);
            this.btnNuevaAportacion.TabIndex = 38;
            this.btnNuevaAportacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevaAportacion.Click += new System.EventHandler(this.cmdAportacion);
            // 
            // btnModificarEstatus
            // 
            this.btnModificarEstatus.ActiveBorderThickness = 1;
            this.btnModificarEstatus.ActiveCornerRadius = 20;
            this.btnModificarEstatus.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btnModificarEstatus.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnModificarEstatus.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnModificarEstatus.BackColor = System.Drawing.Color.White;
            this.btnModificarEstatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarEstatus.BackgroundImage")));
            this.btnModificarEstatus.ButtonText = "Modificar (estatus)";
            this.btnModificarEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEstatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModificarEstatus.IdleBorderThickness = 1;
            this.btnModificarEstatus.IdleCornerRadius = 20;
            this.btnModificarEstatus.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnModificarEstatus.IdleForecolor = System.Drawing.Color.Black;
            this.btnModificarEstatus.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(175)))), ((int)(((byte)(107)))));
            this.btnModificarEstatus.Location = new System.Drawing.Point(318, 154);
            this.btnModificarEstatus.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificarEstatus.Name = "btnModificarEstatus";
            this.btnModificarEstatus.Size = new System.Drawing.Size(172, 49);
            this.btnModificarEstatus.TabIndex = 37;
            this.btnModificarEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdAportacion
            // 
            this.rdAportacion.ElipseRadius = 30;
            this.rdAportacion.TargetControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::A.C.Mascotas_Vulnerables___DB.Properties.Resources.Equis;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(759, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 35;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmAportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearReporte);
            this.Controls.Add(this.btnNuevaAportacion);
            this.Controls.Add(this.btnModificarEstatus);
            this.Controls.Add(this.pnBusqueda);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvProcedimiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAportacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAportacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimiento)).EndInit();
            this.pnBusqueda.ResumeLayout(false);
            this.pnBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvProcedimiento;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private ns1.BunifuThinButton2 cmdIniciar;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnBusqueda;
        private ns1.BunifuThinButton2 btnModificarEstatus;
        private ns1.BunifuThinButton2 btnNuevaAportacion;
        private ns1.BunifuThinButton2 btnCrearReporte;
        private ns1.BunifuElipse rdAportacion;
        private ns1.BunifuImageButton btnCerrar;
    }
}