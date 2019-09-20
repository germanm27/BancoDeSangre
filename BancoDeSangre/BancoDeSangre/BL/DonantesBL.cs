using BancoDeSangre.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.BL
{
    public class DonantesBL
    {
        public BindingList<Donantes> ListadeDonantes { get; set; }
        public BindingList<Donantes> ListaDonantesSanos { get; set; }

        public DonantesBL()
        {
            ListadeDonantes = new BindingList<Donantes>();
            ListaDonantesSanos = new BindingList<Donantes>();
            CargarDatos();
        }

        public void AgregarSanoDonante(Donantes donantes)
        {
            var donador = false;

            foreach (var sano in ListaDonantesSanos)
            {
                if (donantes.Id == sano.Id)
                {
                    donador = true;
                }
            }

            if (donador == false)
            {
                ListaDonantesSanos.Add(donantes);
            }
        }
        public void RemoverDonantes(Modelos.Donantes donantes)
        {
            ListadeDonantes.Remove(donantes);
        }

        public void RemoverSano(Donantes sanos)
        {
            ListaDonantesSanos.Remove(sanos);
        }
        private void CargarDatos()
        {
            //Tipos de Sangres
            var tipo1 = new TipodeSangre(1, "A Positivo", 4000, 7);
            var tipo2 = new TipodeSangre(2, "A Negativo", 7000, 3);
            var tipo3 = new TipodeSangre(3, "B Positivo", 7000, 4);
            var tipo4 = new TipodeSangre(4, "B Negativo", 7000, 2);
            var tipo5 = new TipodeSangre(5, "O Positivo", 4000, 1);
            var tipo6 = new TipodeSangre(6, "O Negativo", 7000, 4);
            var tipo7 = new TipodeSangre(7, "AB Positivo", 7000, 8);
            var tipo8 = new TipodeSangre(8, "AB Negativo", 7000, 6);

            //Generos
            var genero1 = new Genero(1, "Masculino");
            var genero2 = new Genero(2, "Femenino");

            //Donantes
            var donante1 = new Donantes(1, "Miguel Lopez", 24, "0504-1995-13422", tipo1, genero1);
            var donante2 = new Donantes(2, "Daniela Martinez", 35, "0511-1984-00263", tipo5, genero2);
            var donante3 = new Donantes(3, "Pedro Mejia", 28, "0501-1991-01452", tipo3, genero1);
            var donante4 = new Donantes(4, "Karla Perez", 31, "0506-1988-33932", tipo2, genero2);
            var donante5 = new Donantes(5, "Jose Camacho", 29, "0501-1990-32521", tipo8, genero1);
            var donante6 = new Donantes(6, "Gerardo Vargas", 56, "0401-1963-56532", tipo4, genero1);
            var donante7 = new Donantes(7, "Medelin Alvarado", 25, "0702-1994-75421", tipo1, genero2);
            var donante8 = new Donantes(8, "Rosalia Lopez", 36, "0120-1983-71266", tipo6, genero2);
            var donante9 = new Donantes(9, "Rocio Santos", 43, "4368-1976-64245", tipo7, genero2);
            var donante10 = new Donantes(10, "Jesus Garcia", 26, "0419-1993-29821", tipo2, genero1);

            ListadeDonantes.Add(donante1);
            ListadeDonantes.Add(donante2);
            ListadeDonantes.Add(donante3);
            ListadeDonantes.Add(donante4);
            ListadeDonantes.Add(donante5);
            ListadeDonantes.Add(donante6);
            ListadeDonantes.Add(donante7);
            ListadeDonantes.Add(donante8);
            ListadeDonantes.Add(donante9);
            ListadeDonantes.Add(donante10);
        }


    }
}
