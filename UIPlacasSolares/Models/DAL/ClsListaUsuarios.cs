using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIPlacasSolares.Models.ENT;

namespace UIPlacasSolares.Models.DAL
{
    /// <summary>
    /// Clase Lista Usuarios almacena una lisata de usuario
    /// </summary>
    public static class ClsListaUsuarios
    {
        /// <summary>
        /// FUNCION QUE CREA una lista de usuarios y que la retorna  
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<ClsUsuario> ObtenerListaUsuariosDal()
        {
            var listaUsuariosDal = new List<ClsUsuario> {
                new ClsUsuario("usuario", "1234"),
            };
            return new ObservableCollection<ClsUsuario>(listaUsuariosDal);
        }
    }
}
