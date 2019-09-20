using BancoDeSangre.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangre.BL
{
    public class UsuarioBL
    {
        public BindingList<Usuario> ListadeUsuarios { get; set; }

        public UsuarioBL()
        {
            ListadeUsuarios = new BindingList<Usuario>();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var usuarioAdmin = new Usuario(1, "admin", "12345");
            usuarioAdmin.PuedeVerSangres = true;
            usuarioAdmin.PuedeVerFacturas = true;
            usuarioAdmin.PuedeVerSangres = true;
            usuarioAdmin.PuedeVerDonantesSanos = true;

            var usuarioSangre = new Usuario(2, "sangre", "0987");
            usuarioSangre.PuedeVerFacturas = false;
            usuarioSangre.PuedeVerDonantes = false;
            usuarioSangre.PuedeVerDonantesSanos = false;
            usuarioSangre.PuedeVerSangres = true;

            ListadeUsuarios.Add(usuarioAdmin);
            ListadeUsuarios.Add(usuarioSangre);
        }

        public Usuario Autenticar(string nombre, string contrasena)
        {
            foreach (var usuario in ListadeUsuarios)
            {
                if(usuario.Nombre == nombre 
                    && usuario.Contrasena == contrasena)
                {
                    return usuario;
                }
            }

            return null;
        }
    }
}
