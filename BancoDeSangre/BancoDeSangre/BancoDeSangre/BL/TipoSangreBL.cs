using BancoDeSangre.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.BL
{
    public class TipoSangreBL
    {
        public List<TipoSangre> TiposDeSangre { get; set; }

        public TipoSangreBL()
        {
            TiposDeSangre = new List<TipoSangre>();
            CrearDatosDePrueba();
        }

        private void CrearDatosDePrueba()
        {
            var tipo1 = new TipoSangre(1, "A Positivo");
            var tipo2 = new TipoSangre(2, "A Negativo");
            var tipo3 = new TipoSangre(3, "B Positivo");
            var tipo4 = new TipoSangre(4, "B Negativo");
            var tipo5 = new TipoSangre(5, "AB Positivo");
            var tipo6 = new TipoSangre(6, "AB Negativo");

            TiposDeSangre.Add(tipo1);
            TiposDeSangre.Add(tipo2);
            TiposDeSangre.Add(tipo3);
            TiposDeSangre.Add(tipo4);
            TiposDeSangre.Add(tipo5);
            TiposDeSangre.Add(tipo6);
        }
    }
}
