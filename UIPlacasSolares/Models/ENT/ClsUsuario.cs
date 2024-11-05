using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIPlacasSolares.Models.ENT
{/// <summary>
/// clase clsUsuario que tiene una prpiedaad nombre y contrasenya las cuales no pueden ser modificadas
/// </summary>
    public class ClsUsuario
    {
        public String nombre { get; }
        public String contrasenya { get; }
        /// <summary>
        /// Contructor vacio 
        /// </summary>
        public ClsUsuario() { }

        /// <summary>
        /// contrcutor completo con comprobaciones 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="contrasenya"></param>
        /// <exception cref="Exception"></exception>
        public ClsUsuario(string nombre, string contrasenya)
        {
            if (nombre != null && nombre != "")
            {
                this.nombre = nombre;
            }
            else { throw new Exception("El Nombre no puede ser nula o vacia."); }
            if (contrasenya != null && contrasenya != "")
            {
                this.contrasenya = contrasenya;
            }
            else { throw new Exception("La contrasenya no puede ser nula o vacia."); }


        }
    }
}
