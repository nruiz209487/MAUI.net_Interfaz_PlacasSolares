using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIPlacasSolares.Models.ENT
{/// <summary>
/// 
/// </summary>
    public class ClsUsuario
    {/// <summary>
    /// 
    /// </summary>
        public String nombre {get;}
        public String contrasenya {get;}

        public ClsUsuario() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="contrasenya"></param>
        /// <exception cref="Exception"></exception>
        public ClsUsuario(string nombre, string contrasenya)
        {
            if (nombre != null && nombre != "") {
                this.nombre = nombre;
            } else { throw new Exception("El Nombre no puede ser nula o vacia.");  }
            if (contrasenya != null && contrasenya != "")
            {
                this.contrasenya = contrasenya;
            }
            else { throw new Exception("La contrasenya no puede ser nula o vacia."); }


        }
    }
}
