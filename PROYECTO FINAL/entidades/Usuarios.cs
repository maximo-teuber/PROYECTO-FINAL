using System;
using System.Collections.Generic;
using System.Linq;

namespace PROYECTO_FINAL.entidades
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Usuarios { get; set; }
        public string Contraseña { get; set; }

        public void registrar(string n, string us, string con)
        {
            var nuevoUsuario = new Usuario
            {
                Nombre = n,
                Usuarios = us,
                Contraseña = con
            };

            BaseUsuarios.ListaUsuarios.Add(nuevoUsuario);
        }

        public bool login(string us, string con)
        {
            return BaseUsuarios.ListaUsuarios.Any(u => u.Usuarios == us && u.Contraseña == con);
        }
    }
}
