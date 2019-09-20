using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.Modelos
{
    public class Genero
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Genero()
        {
            
        }

        public Genero(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
