using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIPlacasSolares.Models.ENT;

namespace UIPlacasSolares.Models.DAL
{
    public  static class ClsListaUsuarios
    {
        public static ObservableCollection<ClsUsuario> ObtenerListaUsuariosDal()
        {
            var listaUsuariosDal = new List<ClsUsuario> {
                new ClsUsuario("usuario", "1234"),


            };
            return new ObservableCollection<ClsUsuario>(listaUsuariosDal);
        }
    }
}
