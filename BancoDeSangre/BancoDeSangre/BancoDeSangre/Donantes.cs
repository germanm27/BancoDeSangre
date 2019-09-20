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
    public partial class Donantes : Form
    {
        public Donantes()
        {
            InitializeComponent();
        }

        public void cargarDatos(DonanteBL donantesBL, TipoSangreBL tipoSangreBL)
        {
            listaDeDonantesBindingSource.DataSource = donantesBL.ListaDeDonantes;
            tiposDeSangreBindingSource.DataSource = tipoSangreBL.TiposDeSangre;
        }
    }
}
