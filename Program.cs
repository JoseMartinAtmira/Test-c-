using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 2;
            int var2 = 4;
            Circulo miCirculo = new Circulo();

            Console.WriteLine(" El resultado de la suma es: " + (var1 + var2));
            System.Console.WriteLine($"La variable 1 es:{var1}");

            miCirculo.calculoArea(4);            
        }
    }

    class Circulo{
        const double pi = 3.1416;
        public double calculoArea(int radio){
            return  pi * radio * radio;
        }
    }
}
