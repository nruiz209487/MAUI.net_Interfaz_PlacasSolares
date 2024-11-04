using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIPlacasSolares.ENT;
using UIPlacasSolares.Views;

namespace UIPlacasSolares.Models.DAL
{
    /// <summary>
    /// Clase estatica  ClsListaPersonas que contiene una funcion ObtenerCitas que devuleve un a lista de Citas
    /// </summary>
    public static class ClsListaCitas
    {
        
        /// <summary>
        /// Funcion   ObtenerCitas que contiene una lista de ClsCitas
        /// </summary>
        /// <returns>Devuelve una ObservableCollection de citas  </returns>
        public static ObservableCollection<ClsCita> ObtenerCitasDal()
        {
            var listaCitasDal = new List<ClsCita> {
                new ClsCita(1, "Calle Principal 123", "Juan Pérez"),
                new ClsCita(2, "Avenida Libertad 456", "Ana Gómez"),
                new ClsCita(3, "Calle 5 Norte 789", "Carlos Ruiz"),
                new ClsCita(4, "Boulevard Reforma 101", "Marta Sánchez"),
                new ClsCita(5, "Avenida Central 202", "Luis Fernández"),
                new ClsCita(6, "Calle Sur 303", "Laura Ortiz"),
                new ClsCita(7, "Carrera 15 #4-56", "Andrés Gómez"),
                new ClsCita(8, "Camino Real 789", "Patricia León"),
                new ClsCita(9, "Paseo de los Olivos 345", "Carlos Martínez"),
                new ClsCita(10, "Callejón de las Flores 1010", "Fernanda Rivera"),
                new ClsCita(11, "Zona Centro 505", "Rafael Rojas"),
                new ClsCita(12, "Calle de la Paz 77", "Mariana López"),
                new ClsCita(13, "Avenida Universidad 150", "Eduardo Hernández"),
                new ClsCita(14, "Residencial Villa 34", "Gabriela Castro"),
                new ClsCita(15, "Calle Primavera 88", "Manuel Pérez"),
                new ClsCita(16, "Plaza Mayor 700", "Lorena Sánchez"),
                new ClsCita(17, "Avenida Sol Naciente 110", "Carmen Guzmán"),
                new ClsCita(18, "Paseo del Bosque 200", "Sergio Moreno"),
                new ClsCita(19, "Colinas de las Estrellas 401", "Natalia Torres"),
                new ClsCita(20, "Barrio San José 1500", "Ricardo Vargas")

            };
            return new ObservableCollection<ClsCita>(listaCitasDal);
        }

    }
}
