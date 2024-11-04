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
    internal class LoginVM
    {
        private static ObservableCollection<ClsUsuario>? listaaUsuariosVM;
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
