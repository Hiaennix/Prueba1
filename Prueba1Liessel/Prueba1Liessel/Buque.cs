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
        private int cantContainersC;
        private int gastoTransp;
        private List<Container> listaContainers;

        public string Codigo { get { return codigo; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Pais { get { return pais; } set { pais = value; } }
        public int CantContainers { get { return cantContainers; } set { cantContainers = value; } }
        public int CantContainersC { get { return cantContainersC; } set { cantContainersC = value; } }
        public int GastoTransp { get { return gastoTransp; } set { gastoTransp = value; } }
        public List<Container> ListaContainers { get { return listaContainers; } set { listaContainers = value; } }



        public bool SubirContainer(Container asdfg) 
        {
            bool container1;

            if(asdfg.Tamaño)

            return true;

        }
    }
}
