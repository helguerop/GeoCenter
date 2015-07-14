using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direcciones.DataModel
{
    public class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }

    public class Pais
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string dirimagen;

        public string DirImagen
        {
            get { return dirimagen; }
            set { dirimagen = value; }
        }
        
        
        private string norte;

        public string Norte
        {
            get { return norte; }
            set { norte = value; }
        }

        private string sur;

        public string Sur
        {
            get { return sur; }
            set { sur = value; }
        }

        private string este;

        public string Este
        {
            get { return este; }
            set { este = value; }
        }

        private string oeste;

        public string Oeste
        {
            get { return oeste; }
            set { oeste = value; }
        }

        private string noreste;

        public string NorEste
        {
            get { return noreste; }
            set { noreste = value; }
        }

        private string sureste;

        public string SurEste
        {
            get { return sureste; }
            set { sureste = value; }
        }

        private string noroeste;

        public string NorOeste
        {
            get { return noroeste; }
            set { noroeste = value; }
        }

        private string suroeste;

        public string SurOeste
        {
            get { return suroeste; }
            set { suroeste = value; }
        }

        public Pais()
        {
            norte = string.Empty;
            sur = string.Empty;
            este = string.Empty;
            oeste = string.Empty;
            noreste = string.Empty;
            sureste = string.Empty;
            noroeste = string.Empty;
            suroeste = string.Empty;
        }
    }

    public class Paises
    {
        Pais[] countries = new Pais[9];

        public Pais getCountries(int i)
        {
            return countries[i];
        }

        public Paises()
        {
            countries[0] = new Pais { Nombre = "Bolivia", Norte = "Brasil", Sur = "Argentina", Este = "Brasil", Oeste = "Peru", NorEste = "Brasil", NorOeste = "Peru", SurEste = "Paraguay", SurOeste = "Chile", DirImagen = "/Images/Mapa/BoliviaMapa.png" };
            countries[1] = new Pais { Nombre = "Peru", Norte = "Colombia", Sur = "Chile", Este = "Brasil", Oeste = string.Empty, NorEste = "Colombia", SurEste = "Bolivia", NorOeste = "Ecuador", SurOeste = string.Empty, DirImagen = "/Images/Mapa/PeruMapa.png" };
            countries[2] = new Pais { Nombre = "Colombia", Norte = string.Empty, Sur = "Peru", Este = "Venezuela", Oeste = string.Empty, NorEste = "Venezuela", NorOeste = "Panama", SurEste = "Brasil", SurOeste = "Ecuador", DirImagen = "/Images/Mapa/ColombiaMapa.png" };

            countries[3] = new Pais { Nombre = "Mexico", Norte = "Estados Unidos", Sur = "Guatemala", Este = string.Empty, Oeste = string.Empty, NorEste = "Estados Unidos", SurEste = "Belice", NorOeste = "Estados Unidos", SurOeste = string.Empty, DirImagen = "/Images/Mapa/MexicoMapa.png" };
            countries[4] = new Pais { Nombre = "Republica Checa", Norte = "Polonia", Sur = "Austria", Este = "Polinia", Oeste = "Alemania", NorEste = "Polinia", SurEste = "Eslovaquia", NorOeste = "Alemania", SurOeste = "Alemania", DirImagen = "/Images/Mapa/Republica ChecaMapa.png" };
            countries[5] = new Pais { Nombre = "Venezuela", Norte = string.Empty, Sur = "Brasil", Este = "Guyana", Oeste = "Colombia", NorEste = string.Empty, SurEste = string.Empty, NorOeste = "Colombia", SurOeste = "Brasil", DirImagen = "/Images/Mapa/VenezuelaMapa.png" };

            countries[6] = new Pais { Nombre = "Israel", Norte = "Libano", Sur = "Egipto", Este = "Jordania", Oeste = string.Empty, NorEste = "Siria", NorOeste = string.Empty, SurEste = "Jordania", SurOeste = "Egipto", DirImagen = "/Images/Mapa/IsraelMapa.png" };
            countries[7] = new Pais { Nombre = "Alemania", Norte = string.Empty, Sur = "Suiza", Este = "Republica Checa", Oeste = "Belgica", NorEste = "Polonia", NorOeste = "Holanda", SurEste = "Austria", SurOeste = "Francia", DirImagen = "/Images/Mapa/AlemaniaMapa.png" };
            countries[8] = new Pais { Nombre = "Francia", Norte = "Belgica", Sur = string.Empty, Este = "Suiza", Oeste = string.Empty, NorEste = "Alemania", SurEste = "Italia", SurOeste = "España", NorOeste = string.Empty, DirImagen = "/Images/Mapa/FranciaMapa.png" };
            
            /*countries[9] = ;
            countries[10] = ;
            countries[11] = ;
            countries[12] = ;
            countries[13] = ;
            countries[14] = ;
            countries[15] = ;
            countries[16] = ;
            countries[17] = ;
            countries[18] = ;
            countries[19] = ;*/
        }
    }
}
