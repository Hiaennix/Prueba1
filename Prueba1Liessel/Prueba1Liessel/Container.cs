using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1Liessel
{
    internal class Container
    {
        private string codigo;
        private string marca;
        private int capMax;
        private byte tamaño;
        private bool esRefrigerado;
        private int pesoActual;

        public string Codigo { get { return codigo; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public int CapMax { get { return capMax; } set { capMax = value; } }
        public byte Tamaño { get { return tamaño; } set { tamaño = value; } }
        public bool EsRefrigerado { get { return esRefrigerado; } set { esRefrigerado = value; } }
        public int PesoActual { get { return pesoActual; } set { pesoActual = value;} }

        public Buque buque;
        

        public void SacarPeso() { }

        public int ValorPagoInspeccion()
        {
            return pesoActual*5;  
        }
        public int CalcularGastosEnvio()
        {
            return CantContainers{ get; set; };

        }

        public bool puedeSubir { get; set; }
    }
}
