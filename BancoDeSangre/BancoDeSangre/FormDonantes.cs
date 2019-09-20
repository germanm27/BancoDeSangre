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
    public partial class FormDonantes : Form
    {
        public FormDonantes()
        {
            InitializeComponent();
        }

        public void CargarDatos(DonantesBL donantesBL, GeneroBL generoBL, TipodeSangreBL tipodeSangre)
        {
            listadeDonantesBindingSource.DataSource =
                donantesBL.ListadeDonantes;

            listaDeGenerosBindingSource.DataSource =
                generoBL.ListaDeGeneros;

            listadeSangreBindingSource.DataSource =
                tipodeSangre.ListadeSangre;
        }

        private void FormDonantes_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
                
        }
    }
}
