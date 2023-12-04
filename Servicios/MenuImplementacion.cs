using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres.Servicios
{
    /// <summary>
    /// Clase que contiene la implementacion de cada mètodo del menuInterfaz
    /// @author JRT - 4/12/2023
    /// </summary>
    internal class MenuImplementacion:MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionSeleccionada;
            Console.WriteLine("#####################################");
            Console.WriteLine("Seleccione la opcion que desee ejecutar ");
            Console.WriteLine("0.Cerrar aplicacion");
            Console.WriteLine("1.Dar de alta nuevo elemento");
            Console.WriteLine("2.Eliminar elemento");
            Console.WriteLine("3. Ver lista de elementos");
            Console.WriteLine("4. Modificar cantidad de elemento");
            Console.WriteLine("#####################################");
            opcionSeleccionada =Console.ReadKey(true).KeyChar-('0');
            return opcionSeleccionada;
        }
        public string pedirIdElemento()
        {
            string idABuscar = Console.ReadLine();
            return idABuscar;
        }
    }
}
