using BancoDeSangre.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.BL
{
    public class ComprobanteBL
    {
        public BindingList<Comprobante> ListadeComprobantes { get; set; }

        public ComprobanteBL()
        {
            ListadeComprobantes = new BindingList<Comprobante>();
        }
    }
}
