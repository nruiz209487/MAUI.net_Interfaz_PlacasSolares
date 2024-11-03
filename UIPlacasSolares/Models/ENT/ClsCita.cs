using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIPlacasSolares.ENT
{
    /// <summary>
    /// Clase publica  ClsCitas con los atributos NumeroCita,Direccion,Propietario y un constructor con todos los parametros
    /// </summary>
    public class ClsCita
    {
        public int NumeroCita { get; }
        public String Direccion { get; set; }
        public String Propietario { get; set; }

        /// <summary>
        /// Constructor ClsCita con todos los parametros , comprobaciones y exepciones 
        /// </summary>
        /// <param name="NumeroCita"></param>
        /// <param name="Direccion"></param>
        /// <param name="Propietario"></param>
        /// <exception cref="Exception"></exception>
        public ClsCita(int NumeroCita, String Direccion, String Propietario)
        {
            if (NumeroCita > 0)
            {
                this.NumeroCita = NumeroCita;
            }
            else
            {
                throw new Exception("numero Negativo");
            }

            if (Direccion != null && Direccion != "")
            {
                this.Direccion = Direccion;
            }
            else
            {
                throw new Exception("Direccion no valido");
            }

            if (Propietario != null && Propietario != "")
            {
                this.Propietario = Propietario;
            }
            else
            {
                throw new Exception("Propietario no valido");
            }

        }
    }


}
