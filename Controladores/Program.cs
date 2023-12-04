using jromres.Dtos;
using jromres.Servicios;

namespace jromres.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// @author JRT - 4/12/2023
    /// </summary>
    /// <param name="args"></param>
    internal class Program
    {
        /// <summary>
        /// metodo de entrada de la aplicacion 
        /// @author JRT - 4/12/2023
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            CubInterfaz ci = new CubImplementacion();
            List<CubDtos> listaCubiertos = new List<CubDtos>();

            int seleccionUsuario;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                seleccionUsuario = mi.mostrarMenuYSeleccion();
                switch (seleccionUsuario)
                {
                    case 0:
                        Console.WriteLine("Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Se ejecuta caso 1");
                        ci.darAltaCubiertos(listaCubiertos);
                        ///el siguiente bucle nos permitirá recorrer la lista para mostrar el nuevo cubierto
                        ///dado de alta en la lista , será para prueba
                        ///@author JRT- 4/12/2023
                        foreach(CubDtos cubierto in listaCubiertos)
                        {
                            Console.WriteLine(cubierto.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Se ejecuta caso 2");
                        ci.borrarElemento(listaCubiertos);
                        foreach (CubDtos cubierto in listaCubiertos)
                        {
                            Console.WriteLine(cubierto.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Se ejecuta caso 3");
                        foreach(CubDtos cubierto in listaCubiertos)
                        {
                            Console.WriteLine(cubierto.ToString());
                        }
                        break;
                    case 4:
                        Console.WriteLine("Se ejecuta caso 4");
                        ci.modificarCantidad(listaCubiertos);
                        break;
                    default:
                        Console.WriteLine("Introduzca una opcion valida");
                        break;
                   

                }
            }
        }
    }
}