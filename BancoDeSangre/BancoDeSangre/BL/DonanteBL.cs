using BancoDeSangre.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.BL
{
    public class DonanteBL
    {

        public List<Donante> ListaDeDonantes { get; set; }

        public DonanteBL()
        {
            ListaDeDonantes = new List<Donante>();
            CrearDatosDePrueba();
        }

        private void CrearDatosDePrueba()
        {
            //Generos
            var genero1 = new Genero(1, "Masculino");
            var genero2 = new Genero(2, "Femenino");

            //Tipos de Sanagre
            var tipo1 = new TipoSangre(1, "A Positivo");
            var tipo2 = new TipoSangre(2, "A Negativo");
            var tipo3 = new TipoSangre(3, "B Positivo");
            var tipo4 = new TipoSangre(4, "B Negativo");
            var tipo5 = new TipoSangre(5, "AB Positivo");
            var tipo6 = new TipoSangre(6, "AB Negativo");

            //Donantes
            var donante1 = new Donante(1, "Miguel Lopez", 34, "0504-1985-11233", false, "Puede Donar", tipo4, genero1);
            var donante2 = new Donante(2, "Lili Perez", 26, "0602-1993-64532", true, "No Puede Donar", tipo1, genero2);
            var donante3 = new Donante(3, "Luis Zeron", 41, "1243-1978-13421", false, "Puede Donar", tipo3, genero1);

            ListaDeDonantes.Add(donante1);
            ListaDeDonantes.Add(donante2);
            ListaDeDonantes.Add(donante3);
        }
    }
}
