using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal2.Anagrama.Clases
{
    class Pais
    {
        public string Nombre { get; set; }
        public string Anagrama { get; set; }
        public string Bandera { get; set; }
        public string Escudo { get; set; }
        public string Monumentos { get; set; }
        public Pais(string nombre, string bandera, string escudo, string monumentos)
        {
            Nombre = nombre;
            Bandera = bandera;
            Escudo = escudo;
            Monumentos = monumentos;
            Anagrama = GetAnagrama();
        }
        public Pais()
        {
            //Anagrama = GetAnagrama();
        }
        public string GetAnagrama()
        {
            Random r = new Random();
            List<char> vec = new List<char>();
            char[] vec2 = new char[40];
            vec2 = Nombre.ToLower().ToCharArray(0, Nombre.Length);
            for (int i = 0; i < Nombre.Length; i++)
            {
                vec.Add(vec2[i]);
            }
            char c;
            for (int i = 0; i < Nombre.Length; i++)
            {
                c = vec[r.Next(0, Nombre.Length)];
                vec.Remove(c);
                vec.Add(c);
            }
            for (int i = 0; i < Nombre.Length; i++)
            {
                vec2[i] = vec[i];
            }
            Anagrama = new String(vec2);
            return Anagrama;
        }
    }
}
