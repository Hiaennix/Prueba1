using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1Liessel
{
    internal class Buque
    {
        private string codigo;
        private string nombre;
        private string pais;
        private int cantContainers;
        private int cantContainersCa;
        private int costoTransporte;
        private List<Container> listaContainers = new List<Container>();

        /// <summary>
        /// Getters y setters de la clase
        /// </summary>
        public string Codigo { get { return codigo; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Pais { get { return pais; } set { pais = value; } }
        public int CantidadContainers { get { return cantContainers; } set { cantContainers = value; } }
        public int CantidadContainersCargados { get { return cantContainersCa; } set { cantContainersCa = value; } }
        public int GastoTransporte { get { return costoTransporte; } set { costoTransporte = value; } }
        public List<Container> Containers { get { return listaContainers; } set { listaContainers = value; } }

        /// <summary>
        /// Constructor solo con código de la clase
        /// </summary>
        /// <param name="codigo"></param>
        public Buque(string codigo)
        {
            if (codigo.Length >= 5)
            {
                this.codigo = codigo;
            }
            else
            {
                Console.WriteLine("El código es demasiado corto");
            }
        }

        /// <summary>
        /// Constructor con datos básicos de buque
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="pais"></param>
        /// <param name="cantidadContainers"></param>
        public Buque(string codigo, string nombre, string pais, int cantidadContainers) : this(codigo)
        {
            if (codigo.Length >= 5)
            {
                this.codigo = codigo;
                this.nombre = nombre;
                this.pais = pais;
                this.cantContainers = cantidadContainers;
            }
            else
            {
                Console.WriteLine("El código es demasiado corto");
            }

        }


        /// <summary>
        /// Método para subir un container si es que posee
        /// la capacidad para ello siempre y cuando el método
        /// PuedeSubir() de Container devuelva true
        /// </summary>
        /// <param name="container"> Objeto Container que será ingresado al buque </param>
        public bool SubirContainer(Container container)
        {
            bool esPosible = false;

            int tamañoContainer = 0;

            if (container.Tamaño == 20)
            {
                tamañoContainer = 1;
            }
            else if (container.Tamaño == 40)
            {
                tamañoContainer = 2;
            }

            int espacioFinal = cantContainersCa + tamañoContainer;

            if (espacioFinal > cantContainers)
            {
                Console.WriteLine("El buque no tiene la capacidad disponible para almacenar el container que desea ingresar");
            }
            else
            {
                esPosible = true;
                cantContainersCa = espacioFinal;
                container.Buque = new Buque(codigo, nombre, pais, cantContainers);
                listaContainers.Add(container);
                Console.WriteLine("El container ha sido agregado a la carga del buque");
            }



            return esPosible;

        }

        /// <summary>
        /// Método que lista los containers de un buque
        /// </summary>
        public void ListarContainers()
        {
            foreach (Container container in listaContainers)
            {
                string str = container.ToString("G");
                Console.WriteLine(str);
            }

        }

    }
}
