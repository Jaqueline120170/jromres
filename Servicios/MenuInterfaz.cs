using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres.Servicios
{
    /// <summary>
    /// Interfaz que contiene la relaciòn de metodos con la funcionalidad del menú
    /// @author JRT - 4/12/2023
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menú y recoge la opcion introducida por el usuario
        /// @author JRT -4/12/2023
        /// </summary>
        /// <returns>un tipo int que contendrà la opcion que seleccione el usuario</returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// Método para solcitar al usuario el id del elemento , nos sirve para identificarlo o hacer match
        /// con los id's que contiene la lista y posteriormente hacer algunas modificaciones a los elementos
        /// en este caso , poder modificar la cantidad de ese elemento (cubierto)
        /// @author JRT - 4/12/2023
        /// </summary>
        /// <returns> un string con el idElemento</returns>
        public string pedirIdElemento();
    }
}
