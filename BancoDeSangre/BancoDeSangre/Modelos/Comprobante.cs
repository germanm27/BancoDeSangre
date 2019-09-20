using BancoDeSangre.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.Modelos
{
    public class Comprobante
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int DonantesId { get; set; }
        public Donantes Donantes { get; set; }

        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        public bool Activo { get; set; }

        public BindingList<ComprobanteDetalle> ComprobanteDetalle { get; set; }


        public Comprobante()
        {
            Id = Id;
            Fecha = DateTime.Now;
            Activo = true;
            ComprobanteDetalle = new BindingList<ComprobanteDetalle>();
        }

        public void CalcularTotalComprobante()
        {
            var tipodeSangreBL = new TipodeSangreBL();

            double subtotal = 0;
            foreach (var detalle in ComprobanteDetalle)
            {
                var precio = tipodeSangreBL.ObtenerPrecio(detalle.Sangreid);
                subtotal = subtotal + detalle.CalcularTotalDetalle(precio);
            }

            Subtotal = subtotal;
            Impuesto = Subtotal * 0.15;
            Total = Impuesto + Subtotal;
        }

    }

    public class ComprobanteDetalle
    {
        public int Id { get; set; }
        public int Sangreid { get; set; }
        public TipodeSangre TipodeSangre { get; set; }

        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

        public ComprobanteDetalle()
        {
            Cantidad = 1;
            Sangreid = 1;
        }

        public double CalcularTotalDetalle(double precio)
        {
            Precio = precio;
            Total = Cantidad * Precio;

            return Total;
        }
    }
}
