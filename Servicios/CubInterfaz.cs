using jromres.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres.Servicios
{
    internal interface CubInterfaz
    {
        /// <summary>
        /// Mètodo para dar de alta un nuevo elemento a la lista de cubiertos ya existen o lista antigua
        /// @author JRT - 4/12/2023
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCubiertos(List<CubDtos> listaAntigua);

        /// <summary>
        /// Método para eleminar un elemento de la lista (listaAntigua) que tenemos de cubiertos 
        /// @author JRT - 4/12/2023
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void borrarElemento(List<CubDtos> listaAntigua);


        /// <summary>
        /// Método que permite modificar la cantidad de un cubierto 
        /// @author JRT - 4/12/2023
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void modificarCantidad(List<CubDtos> listaAntigua);
    }
}
