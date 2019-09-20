using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.Modelos
{
    public class TipoSangre
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public TipoSangre(int id,string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
