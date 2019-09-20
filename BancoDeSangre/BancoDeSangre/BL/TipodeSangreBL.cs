using BancoDeSangre.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.BL
{
   public class TipodeSangreBL
    {
        public BindingList<TipodeSangre> ListadeSangre { get; set; }

        public TipodeSangreBL()
        {
            ListadeSangre = new BindingList<TipodeSangre>();
            CargarDatos();
        }

        public double ObtenerPrecio(int id)
        {
            double precio = 0;
            foreach (var sangre in ListadeSangre)
            {
                if (sangre.Id == id)
                {
                    precio = sangre.Precio;
                }
            }

            return precio;
        }

        private void CargarDatos()
        {
            var tipo1 = new TipodeSangre(1, "A Positivo", 4000, 8);
            var tipo2 = new TipodeSangre(2, "A Negativo", 7000, 3);
            var tipo3 = new TipodeSangre(3, "B Positivo", 7000, 4);
            var tipo4 = new TipodeSangre(4, "B Negativo", 7000, 2);
            var tipo5 = new TipodeSangre(5, "O Positivo", 4000, 1);
            var tipo6 = new TipodeSangre(6, "O Negativo", 7000, 4);
            var tipo7 = new TipodeSangre(7, "AB Positivo", 7000, 8);
            var tipo8 = new TipodeSangre(8, "AB Negativo", 7000, 6);

            ListadeSangre.Add(tipo1);
            ListadeSangre.Add(tipo2);
            ListadeSangre.Add(tipo3);
            ListadeSangre.Add(tipo4);
            ListadeSangre.Add(tipo5);
            ListadeSangre.Add(tipo6);
            ListadeSangre.Add(tipo7);
            ListadeSangre.Add(tipo8);
        }
    }
}
