using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var buque1 = new Buque("35877", "La Fragata", "Portugal", 64);
            var buque2 = new Buque("35866", "Viking 5", "USA", 72);
            var buque3 = new Buque("35899", "Chin Chu Lancha", "China", 128);


            var container1 = new Container("56538", "Adidas", 3000, 20, false, 1850);
            var container2 = new Container("56536", "Codelco", 25000, 40, false, 22000);
            var container3 = new Container("54863", "san José", 10000, 20, true, 7500);
            var container4 = new Container("16565", "BIC", 5000, 20, false, 5000);

            buque1.SubirContainer(container1);
            buque1.SubirContainer(container2);

            buque1.ListarContainers();

            container3.ValorPagoInspeccion();

            Console.WriteLine("Valor envío container 1: $" + container1.CalcularGastosEnvio());
            Console.WriteLine("Valor envío container 2: $" + container2.CalcularGastosEnvio());
            Console.WriteLine("Valor envío container 3: $" + container3.CalcularGastosEnvio());
            Console.WriteLine("Valor envío container 4: $" + container4.CalcularGastosEnvio());

            container4.PuedeSubir(container4.CantidadMaxima, 2000);

            container1.SacarPeso(200);

            Console.ReadKey();

        }
    }
}