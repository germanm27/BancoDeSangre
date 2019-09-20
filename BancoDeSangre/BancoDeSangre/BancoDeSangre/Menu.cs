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
    public partial class Menu : Form
    {
        DonanteBL _donanteBL;
        TipoSangre _tiposangre;

        public Menu()
        {
            InitializeComponent();

            _donanteBL = new DonanteBL();
            

        }

        private void donantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormDonantes = new Donantes();
            FormDonantes.MdiParent = this;
            FormDonantes.Show();
        }

        private void tiposDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormTipoDeSangre = new TipoDeSangre();
            FormTipoDeSangre.MdiParent = this;
            
            FormTipoDeSangre.Show();
        }
    }
}
