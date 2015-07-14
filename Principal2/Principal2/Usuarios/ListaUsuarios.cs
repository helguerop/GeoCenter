using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal2.Usuarios
{
    public class ListaUsuarios
    {

        ////public List<Usuario> ListaDeUsuarios { get; set; }


        private List<Usuario> ListaDeUsuarios = new List<Usuario>();

        //
        public void AddUsuario(Usuario usr)
        {
            ListaDeUsuarios.Add(usr);
        }
        public List<Usuario> GetListaDeUsuarios
        {
            get { return ListaDeUsuarios; }
        }
    }
}
