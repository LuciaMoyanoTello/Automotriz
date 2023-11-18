using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizApp.Datos;

namespace AutomotrizApp.Presentacion.ReporteVenta
{
    public partial class FrmReporteVentas : Form
    {
        public FrmReporteVentas()
        {
            InitializeComponent();
        }

        //
        private void FrmReporteVentas_Load(object sender, EventArgs e)
        {
            rvReporteVenta.RefreshReport();
            
            dtpFechaMin.Value = new DateTime(2000, 1, 1);
            dtpFechaMax.Value = DateTime.Today.AddDays(1);

            btnBuscar_Click();
        }


        //
        private void btnBuscar_Click(object sender = null, EventArgs e = null)
        {
            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Add(new Parametro("@input_fecha_min", dtpFechaMin.Value));
            lParametros.Add(new Parametro("@input_fecha_max", dtpFechaMax.Value));

            DataTable tabla = new DataTable();
            tabla = DBHelper.ObtenerInstancia().ConsultarSP("SP_REPORTE_VENTAS_X_TIPO", lParametros);

            rvReporteVenta.LocalReport.DataSources.Clear();
            rvReporteVenta.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", tabla));
            rvReporteVenta.RefreshReport();
        }
    }
}
