using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.Modelos
{
    public class Donantes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Cedula { get; set; }
        public int SangreId { get; set; }
        public int GeneroId { get; set; }
        public TipodeSangre TipodeSangre { get; set; }
        public Genero Genero { get; set; }

        public Donantes()
        {
            TipodeSangre = new TipodeSangre(1, "", 0, 0);
            SangreId = TipodeSangre.Id;
            Genero = new Genero(1, "");
            GeneroId = Genero.Id;
        }

        public Donantes(int id, string nombre, int edad, string cedula,  TipodeSangre tipoDeSangre,
            Genero genero)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Cedula = cedula;
            TipodeSangre = tipoDeSangre;
            Genero = genero;
            SangreId = tipoDeSangre.Id;
            GeneroId = genero.Id;
        }

    }
}
