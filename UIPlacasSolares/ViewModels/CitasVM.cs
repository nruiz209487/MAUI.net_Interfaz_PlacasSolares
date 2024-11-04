using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIPlacasSolares.ENT;
using UIPlacasSolares.Models.DAL;

namespace UIPlacasSolares.ViewModels
{

    /// <summary>
    /// Clase CitasVM que hace de intermediario entre dal y la vista
    /// </summary>
    internal class CitasVM
    {
    /// <summary>
    /// Variable que tiene una ObservableCollection de ClsCita
    /// </summary>
    private static ObservableCollection<ClsCita>? listaCitasVM;

        /// <summary>
        /// Propiedad estática que llama la lista de citas llamando a ObtenerCitasDal().
        /// </summary>
        public static ObservableCollection<ClsCita> ListaCitasVM
        {
            get
            {
                if (listaCitasVM == null) 
                {
                    listaCitasVM = ClsListaCitas.ObtenerCitasDal(); 
                }
                return listaCitasVM; 
            }
        }
    }
}







