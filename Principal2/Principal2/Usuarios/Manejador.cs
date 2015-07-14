using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal2.Usuarios
{
    public static class Manejador
    {
        public static ListaUsuarios ListaU { get; set; }
        public static void AñadirUsuario(string nombre, int puntos)
        {
            ListaU.AddUsuario(new Usuario() { Nombre = nombre, Puntos = puntos });
        }
    }
}
