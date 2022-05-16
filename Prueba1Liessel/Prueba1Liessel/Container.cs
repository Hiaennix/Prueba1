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
        private int CapMax;
        private byte tamaño;
        private bool esRefrigerado;
        private int pesoActual;

        public Buque buque;

        public void SacarPeso();

        public int ValorPagoInspeccion();
        public int CalcularGastosEnvio();
    }
}
