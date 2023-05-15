﻿using A.C.Mascotas_Vulnerables___DB.BLL;
using A.C.Mascotas_Vulnerables___DB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.C.Mascotas_Vulnerables___DB.PL
{
    public partial class frmNuevaAportacion : Form
    {
        public frmNuevaAportacion()
        {
            InitializeComponent();
            
        }

        ReciboDAL recibo = new ReciboDAL();
        frmBuscador buscador = new frmBuscador();
        BuscadorDAL bus  =  new BuscadorDAL();
        //frmAportacion aportacion = new frmAportacion();

        private void cmdCerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNuevaAportacion_Load(object sender, EventArgs e)
        {
            recibo.LlenarCBEncargado2(cbEncargado2);
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuscarSOcio(object sender, EventArgs e)
        {
            buscador.dgvSocios.DataSource = bus.MostrarTabla().Tables[0];
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                lblNombre.Text = buscador.nombre;
                lblAPaterno.Text = buscador.apaterno;
                lblAMaterno.Text = buscador.amaterno;

            }
        }
        private void MostrarReicbo(object sender, EventArgs e)
        {
            //aportacion.dgvRecibos.DataSource = bus.MostrarTabla().Tables[0];
            //if (aportacion.ShowDialog() == DialogResult.OK)
            //{
            //    txtFolio.Text = aportacion.folio;
            //    dtFecha.Text = aportacion.fecha;
            //    txtImporte.Text = aportacion.monto;
            //    txtMtoEscrito.Text = aportacion.mtoescrito;
            //    txtEncargado1.Text = aportacion.firmaasistente;
            //    cbEncargado2.Text = aportacion.firmaadministrativo;

            //}
        }


        private void btnAgregarRecibo_Click(object sender, EventArgs e)
        {
        }
    }
}
