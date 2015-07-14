using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal2.Anagrama.Clases
{
    class ListaPaises
    {
        public List<Pais> ListaDePaises { get; set; }
        public ListaPaises()
        {
            ListaDePaises = new List<Pais>();
            ListaDePaises.Add(new Pais() { Nombre = "Bolivia", Bandera = "/Images/Banderas/BoliviaBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Mexico", Bandera = "/Images/Banderas/MexicoBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Colombia", Bandera = "/Images/Banderas/ColombiaBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Alemania", Bandera = "/Images/Banderas/AlemaniaBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Francia", Bandera = "/Images/Banderas/FranciaBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Israel", Bandera = "/Images/Banderas/IsraelBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Peru", Bandera = "/Images/Banderas/PeruBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Republica Checa", Bandera = "/Images/Banderas/Republica ChecaBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Venezuela", Bandera = "/Images/Banderas/VenezuelaBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Italia", Bandera = "/Images/Banderas/ItaliaBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Eslovaquia", Bandera = "/Images/Banderas/EslovaquiaBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Canada", Bandera = "/Images/Banderas/CanadaBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Portugal", Bandera = "/Images/Banderas/PortugalBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Ucrania", Bandera = "/Images/Banderas/UcraniaBandera.png" });
            ListaDePaises.Add(new Pais() { Nombre = "Congo", Bandera = "/Images/Banderas/CongoBandera.png" });
        }
    }
}
