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
    public partial class DonantesSanos : Form
    {
        DonantesBL _donantesBL;
        TipodeSangreBL _tipodeSangreBL;
        GeneroBL _generoBL;

        public DonantesSanos()
        {
            InitializeComponent();

            _donantesBL = new DonantesBL();
            _tipodeSangreBL = new TipodeSangreBL();
            _generoBL = new GeneroBL();

            listadeDonantesBindingSource.DataSource = _donantesBL.ListadeDonantes;
            listaDonantesSanosBindingSource.DataSource = _donantesBL.ListaDonantesSanos;
            listadeSangreBindingSource.DataSource = _tipodeSangreBL.ListadeSangre;
            listaDeGenerosBindingSource.DataSource = _generoBL.ListaDeGeneros;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var donante = (Donantes)listadeDonantesBindingSource.Current;

            _donantesBL.AgregarSanoDonante(donante);
            listadeDonantesBindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var donante = (Donantes)listadeDonantesBindingSource.Current;

            _donantesBL.RemoverDonantes(donante);
            listadeDonantesBindingSource.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sanos = (Donantes)listaDonantesSanosBindingSource.Current;

            _donantesBL.RemoverSano(sanos);
            listaDonantesSanosBindingSource.ResetBindings(false);
        }
    }
}
