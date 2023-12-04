using jromres.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres.Servicios
{
    /// <summary>
    /// Clase que contiene la implementación de los métodos de la interfaz CubInterfaz
    /// @author JRT - 4/12/2023
    /// </summary>
    internal class CubImplementacion : CubInterfaz

    {
        public void darAltaCubiertos(List<CubDtos> listaAntigua)
        {
            listaAntigua.Add(crearCubierto());
        }

        /// <summary>
        /// Mètodo que recoge los atributos o datos que conformaran a un nuevo cubierto para
        /// ser añadido a la lista, en este caso e sprivado porque solo se harà o implementará en esta clase.
        /// @author JRT- 4/12/2023
        /// </summary>
        /// <returns></returns>
        private CubDtos crearCubierto()
        {
            int idElemento;
            string nombreElemento;
            string codigoElemento;
            string descripcionElemento;
            int cantidadElemento;

            Console.WriteLine("Introduzca id del cubierto: ");
            idElemento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca nombre del cubierto: ");
            nombreElemento = Console.ReadLine();
            codigoElemento = (idElemento + nombreElemento);
            Console.WriteLine(codigoElemento);
            Console.WriteLine("Introduzca descripcion del cubierto");
            descripcionElemento = Console.ReadLine();
            Console.WriteLine("Introduzca cantidad de cubiertos: ");
            cantidadElemento = Convert.ToInt32(Console.ReadLine());
            CubDtos cubierto = new CubDtos(idElemento, nombreElemento, codigoElemento, descripcionElemento, cantidadElemento);
            return cubierto;
        }

        public void borrarElemento(List<CubDtos> listaAntigua)

        {
            MenuInterfaz mi = new MenuImplementacion();
            string buscarId = mi.pedirIdElemento();
            CubDtos cubiertoaBorrar = new CubDtos();
            foreach (CubDtos cubierto in listaAntigua)
            {
                if (cubierto.IdElemento.Equals(buscarId))
                {
                    cubiertoaBorrar = cubierto;
                  
                }
            }
            listaAntigua.Remove(cubiertoaBorrar);
        }
        /// <summary>
        /// Se supone que este método tendría que modificar la cantidad pero, NO funciona 
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void modificarCantidad(List<CubDtos> listaAntigua)
        {
            MenuInterfaz mi = new MenuImplementacion();
            string buscarId = mi.pedirIdElemento();
            
            foreach (CubDtos cubierto in listaAntigua)
            {
                if (cubierto.IdElemento.Equals(buscarId))
                {
                   
                }
            }
        }

        /// <summary>
        /// método privado que solicita al usuario la nueva cantidad que se añadirá al campo CantidadElemento
        /// @author JRT - 4/12/2023
        /// </summary>
        /// <param name="modificarCant"></param>
        /// <param name="cubierto"></param>
        /// <returns></returns>
        private int cantidadAModificar(CubDtos modificarCant, int cubierto)
        {
            
            Console.WriteLine("Introduzca la nueva cantidad");
            modificarCant.CantidadElemento = Convert.ToInt32(Console.ReadLine());
            return cubierto;

        }
    }
}
