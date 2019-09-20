using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.Modelos
{
    public class Donante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Cedula { get; set; }
        public bool Enfermedad { get; set; }
        public string Mensaje { get; set; }
        public int SangreId { get; set; }
        public TipoSangre Sangre { get; set; }
        public Genero Genero { get; set; }

        public Donante(int id, string nombre, int edad,string cedula, bool enfermedad,string mensaje, TipoSangre sangre, Genero genero)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Enfermedad = enfermedad;
            Mensaje = mensaje;
            Cedula = cedula;
            Sangre = sangre;
            Genero = genero;
        }
    }
}
