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

        
        public string Codigo { get { return codigo; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Pais { get { return pais; } set { pais = value; } }
        public int CantidadContainers { get { return cantContainers; } set { cantContainers = value; } }
        public int CantidadContainersCargados { get { return cantContainersCa; } set { cantContainersCa = value; } }
        public int GastoTransporte { get { return costoTransporte; } set { costoTransporte = value; } }
        public List<Container> Containers { get { return listaContainers; } set { listaContainers = value; } }

       
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
