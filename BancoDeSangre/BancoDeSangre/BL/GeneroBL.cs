using BancoDeSangre.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.BL
{
    public class GeneroBL
    {
        public BindingList<Genero> ListaDeGeneros { get; set; }

        public GeneroBL()
        {
            ListaDeGeneros = new BindingList<Genero>();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var genero1 = new Genero(1, "Masculino");
            var genero2 = new Genero(2, "Femenino");

            ListaDeGeneros.Add(genero1);
            ListaDeGeneros.Add(genero2);
        }
    }
}
