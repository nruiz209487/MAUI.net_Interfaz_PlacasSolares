using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIPlacasSolares.Models.DAL;
using UIPlacasSolares.Models.ENT;

namespace UIPlacasSolares.ViewModels
{
    /// <summary>
    /// Clase LoginVM que hace de intermediario entre dal y la vista
    /// </summary>
    internal class LoginVM
    {    /// <summary>
         /// Variable que tiene una ObservableCollection de ClsUsuario
         /// </summary>
        private static ObservableCollection<ClsUsuario>? listaaUsuariosVM;
        /// <summary>
        /// ObservableCollection estática que llama la lista de citas llamando a ObtenerListaUsuariosDal().
        /// </summary>
        public static ObservableCollection<ClsUsuario> ListaCitasVM
        {
            get
            {
                if (listaaUsuariosVM == null)
                {
                    listaaUsuariosVM = ClsListaUsuarios.ObtenerListaUsuariosDal();
                }
                return listaaUsuariosVM;
            }
        }
    }
}
