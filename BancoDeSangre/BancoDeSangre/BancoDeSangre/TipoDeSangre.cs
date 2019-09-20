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
    public partial class TipoDeSangre : Form
    {
        public TipoDeSangre()
        {
            InitializeComponent();

            var tipoSangre = new TipoSangreBL();
            tiposDeSangreBindingSource.DataSource = tipoSangre.TiposDeSangre;
        }
    }
}
