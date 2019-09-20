using BancoDeSangre.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangre
{
    public partial class ReportedeVentaSangre : Form
    {
        public ReportedeVentaSangre()
        {
            InitializeComponent();
        }

        public void CargarDatos(ComprobanteBL comprobanteBL, DonantesBL donantesBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from c in comprobanteBL.ListadeComprobantes
                select new
                {
                    Id = c.Id,
                    Fecha = c.Fecha,
                    Donantes = donantesBL
                    .ListadeDonantes
                    .FirstOrDefault( r => r.Id == c.DonantesId).Nombre,
                    Subtotal = c.Subtotal,
                    Impuesto = c.Impuesto,
                    Total = c.Total,
                    Activo = c.Activo

                };

            var reporte = new RepordeComprobante();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
