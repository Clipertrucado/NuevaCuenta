using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    /// <summary>
    /// Interfaz con la relación de métodos de la funcionalidad menú
    /// 250923 - rfg
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra mensaje de bienvenida al cajero.
        /// 250923-rfg
        /// </summary>
        public void mostrarMensajeBienvenida();

        /// <summary>
        /// Método que muestra el menú y recoge la selección del usuario
        /// 260923-rfg
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public int mostrarMenuYSeleccion();


    }
}
