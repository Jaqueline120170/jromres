using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres.Dtos
{
    /// <summary>
    /// Clase principal que contendra todos los atributos de CubDtos
    /// @author JRT -4/12/2023
    /// </summary>
    internal class CubDtos
    {
        int idElemento;
        string nombreElemento;
        string codigoElemento;
        string descripcionElemento;
        int cantidadElemento;

        /// <summary>
        /// Contructor vacío por defecto 
        /// @author JRT - 4/12/2023
        /// </summary>
        public CubDtos()
        {
        }
        /// <summary>
        /// mètodos get y set los cuales formarán una estructura con caracteristicas que identifiquen de forma 
        /// univoca a cada elemento añadido, en este caso a cada "cubierto"
        /// @author JRT - 4/12/2023
        /// </summary>
        public int IdElemento { get => idElemento; set => idElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

       /// <summary>
       /// Contructor al cual se llamara cuando se haga una copia (new) de los elementos que lo conforman,
       /// en este caso los atributos
       /// @author JRT - 4/12/2023
       /// </summary>
       /// <param name="idElemento"></param>
       /// <param name="nombreElemento"></param>
       /// <param name="codigoElemento"></param>
       /// <param name="descripcionElemento"></param>
       /// <param name="cantidadElemento"></param>
       
        public CubDtos(int idElemento, string nombreElemento, string codigoElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.nombreElemento = nombreElemento;
            this.codigoElemento = codigoElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        /// <summary>
        /// Mètodo tu string el cual convierte de forma automatica el objeto a tipo string sin necesidad de tener que hacer
        /// la conversión al momento
        /// @author JRT -4/12/2023
        /// </summary>
        /// <returns>un tipo string del objeto</returns>
        public string ToString()
        {
            string tipoCubierto = "Id del cubierto: " + this.idElemento +
                "Nombre del cubierto: " + this.nombreElemento +
                "Codigo del cubierto " + this.codigoElemento +
                "Descripcion del cubierto: " + this.descripcionElemento +
                "Cantidad de cubiertos: " + this.cantidadElemento;
            return tipoCubierto;


        }
    }
}
