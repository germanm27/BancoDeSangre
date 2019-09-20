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
    public partial class ReporteSangre : Form
    {
        public ReporteSangre()
        {
            InitializeComponent();
        }

        public void CargarDatos(TipodeSangreBL tipodeSangreBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from s in tipodeSangreBL.ListadeSangre
                select new
                {
                    Id = s.Id,
                    Descripcion = s.Descripcion,
                    Precio = s.Precio,
                    Existencia = s.Existencia
                };

            var reporte = new ReportedeSangre();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
