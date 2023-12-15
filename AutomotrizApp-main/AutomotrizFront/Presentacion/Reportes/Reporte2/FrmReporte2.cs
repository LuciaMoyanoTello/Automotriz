using AutomotrizBack.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentacion.Reportes.Reporte2
{
    public partial class FrmReporte2 : Form
    {
        public FrmReporte2()
        {
            InitializeComponent();
        }

        private void FrmReporte1_Load(object sender, EventArgs e)
        {
            rvReporte.LocalReport.ReportEmbeddedResource = "AutomotrizFront.Presentacion.Reportes.Reporte2.Reporte2.rdlc";
            rvReporte.RefreshReport();

            btnBuscar_Click();
        }

        private void btnBuscar_Click(object sender = null, EventArgs e = null)
        {
            List<Parametro> lParametros = new List<Parametro>();
            if (txtDniCliente.Text != "")
            {
                lParametros.Add(new Parametro("@input_dni_cliente", txtDniCliente.Text));
            }
            else { lParametros = null; }


            DataTable tabla = new DataTable();
            tabla = DBHelper.ObtenerInstancia().ConsultarSP("SP_REPORTE_COMPRAS_X_CIENTE", lParametros);

            rvReporte.LocalReport.DataSources.Clear();
            rvReporte.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", tabla));
            rvReporte.RefreshReport();
        }

        //Veriica si la tecla presionada es un numero o un "backspace", si no lo es, se ignora
        private void txtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
