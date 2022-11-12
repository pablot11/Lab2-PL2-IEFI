﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresIEFIPL2_LAB2
{
    public partial class frmConsultaClientePorActividad : Form
    {
        public frmConsultaClientePorActividad()
        {
            InitializeComponent();
        }

        private void lstActividadConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void frmConsultaClientePorActividad_Load(object sender, EventArgs e)
        {
            clsActividad objClaseCliente = new clsActividad();
            objClaseCliente.LlenarListaDesplegable(lstActividadConsulta);
            lstActividadConsulta.SelectedIndex = -1;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 varActividad = 0;
            varActividad = Convert.ToInt32(lstActividadConsulta.SelectedValue);
            clsCliente objClaseActividad = new clsCliente();
            objClaseActividad.ListarActividad(varActividad, dgvConsulta);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            clsCliente objClaseCliente = new clsCliente();
            Int32 CodigoActividad = Convert.ToInt32(lstActividadConsulta.SelectedValue);
            objClaseCliente.Reportar(CodigoActividad);
            MessageBox.Show("Reporte generado exitosamente");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Ventana que nos permite elegir las impresoras
            prtVentana.ShowDialog();
            //Al objeto documento le asignamos la impresora que se eligio en la ventana de impresoras
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            //Indicamos que el documento se debe imprimir
            //Ejecuta el evento del Documento PrintPage
            prtDocumento.Print();
            
        }
        
        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsCliente objClaseCliente = new clsCliente();
            objClaseCliente.Imprimir(e);

        }
    }
}