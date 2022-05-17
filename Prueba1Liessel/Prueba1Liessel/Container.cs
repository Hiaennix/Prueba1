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
        private int cantMax;
        private byte tamaño;
        private bool esRefrigerado;
        private int pesoActual;
        public Buque buque;

       
        public string Codigo { get => codigo; }
        public string Marca { get => marca; set => marca = value; }
        public int CantidadMaxima { get => cantMax; set => cantMax = value; }
        public byte Tamaño { get => tamaño; set => tamaño = value; }
        public bool EsRefrigerado { get => esRefrigerado; set => esRefrigerado = value; }
        public int PesoActual { get => pesoActual; set => pesoActual = value; }
        public Buque Buque { get => buque; set => buque = value; }

        
        public Container(string codigo) => this.codigo = codigo;

      
        public Container(string codigo, string marca, int cantidadMaxima, byte tamaño, bool esRefrigerado, int pesoActual)
        {

            if (0 < pesoActual)
            {
                if (PuedeSubir(cantidadMaxima, pesoActual))
                {
                    if (tamaño == 20 || tamaño == 40)
                    {
                        this.codigo = codigo;
                        this.marca = marca;
                        this.cantMax = cantidadMaxima;
                        this.esRefrigerado = esRefrigerado;
                        this.pesoActual = pesoActual;
                        this.tamaño = tamaño;
                    }
                    else
                    {
                        Console.WriteLine("El container debe medir 20 o 40 pies");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Capacidad del container sobrepasada");
                }
            }
            else
            {
                Console.WriteLine("Error: El peso en el container no puede ser igual o menor a 0");
            }

        }


       
        public void SacarPeso(int pesoPerdido)
        {
            int pesoResultante = pesoActual - pesoPerdido;

            if (pesoResultante >= 0)
            {
                pesoActual = pesoResultante;
            }
            else
            {
                Console.WriteLine("No se puede restar más del peso actual. Peso actual del container: " + pesoActual);
            }
        }

       
        public int ValorPagoInspeccion()
        {
            int costoInspeccion = pesoActual * 5;

            return costoInspeccion;
        }

        
        public int CalcularGastosEnvio()
        {
            int coste = 0;
            if (tamaño == 20)
            {
                coste = 3500;
            }
            else if (tamaño == 40)
            {
                coste = 9000;
            }
            return coste;
        }

       
        public bool PuedeSubir(int pesoMaximo, int pesoPorSubir)
        {
            bool Cargar = false;
            int pesoResultante = pesoPorSubir + pesoActual;

            if (pesoMaximo >= pesoResultante)
            {
                Cargar = true;
                Console.WriteLine("Se puede subir el peso");
            }
            else
            {
                Console.WriteLine("No se puede subir el peso");
            }

            return Cargar;
        }

        public string ToString(string fmt)
        {
            if (string.IsNullOrEmpty(fmt))
                fmt = "G";

            switch (fmt.ToUpperInvariant())
            {
                case "G":
                    return string.Format("Código: {0} | Marca: {1} | Capacidad máxima: {2} | Tamaño: {3} | ¿Refrigeración?: {4} | Peso actual: {5} | Buque: {6}",
                        codigo, marca, cantMax, tamaño, esRefrigerado, pesoActual, buque.Codigo);
                default:
                    string msg = string.Format("'{0}' is an invalid format string",
                                               fmt);
                    throw new ArgumentException(msg);
            }
        }

    }
}