using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoblacionComp2.Soy_el_Mayor
{
    public class Pais
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int poblacion;

        public int Poblacion
        {
            get { return poblacion; }
            set { poblacion = value; }
        }
    }

    public class Paises
    {
        Pais[] countries = new Pais[12];

        public Pais GetPais(int i)
        {
            return countries[i];
        }

        public Paises()
        {
            countries[0] = new Pais() { Nombre = "Bolivia", Poblacion = 10027254 };
            countries[1] = new Pais() { Nombre = "Suiza", Poblacion = 8140000 };
            countries[2] = new Pais() { Nombre = "Venezuela", Poblacion = 30851343 };
            countries[3] = new Pais() { Nombre = "Estados Unidos", Poblacion = 319047000 };
            countries[4] = new Pais() { Nombre = "Cuba", Poblacion = 11258597 };
            countries[5] = new Pais() { Nombre = "Brasil", Poblacion = 202769000 };
            countries[6] = new Pais() { Nombre = "Alemania", Poblacion = 80889505 };
            countries[7] = new Pais() { Nombre = "Japon", Poblacion = 127061000 };
            countries[8] = new Pais() { Nombre = "Francia", Poblacion = 63920000 };
            countries[9] = new Pais() { Nombre = "Rusia", Poblacion = 143819569 };
            countries[10] = new Pais() { Nombre = "China", Poblacion = 1367820000 };
            countries[11] = new Pais() { Nombre = "Peru", Poblacion = 30769077 };
        }
    }
}
