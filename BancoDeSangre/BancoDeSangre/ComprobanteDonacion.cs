using BancoDeSangre.BL;
using BancoDeSangre.Modelos;
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
    public partial class ComprobanteDonacion : Form
    {
        ComprobanteBL _comprobanteBL;

        public ComprobanteDonacion()
        {
            InitializeComponent();
        }

        public void CargarDatos(ComprobanteBL comprobanteBL, DonantesBL donantesBL, 
            TipodeSangreBL tipodeSangreBL)
        {
            _comprobanteBL = comprobanteBL;

            listadeComprobantesBindingSource.DataSource =
                comprobanteBL.ListadeComprobantes;

            listadeDonantesBindingSource.DataSource =
                donantesBL.ListadeDonantes;

            listadeSangreBindingSource.DataSource =
                tipodeSangreBL.ListadeSangre;
        }

        private void comprobanteDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var comprobante = (Comprobante)listadeComprobantesBindingSource.Current;
            comprobante.CalcularTotalComprobante();

            listadeComprobantesBindingSource.ResetBindings(false);
        }
    }
}
