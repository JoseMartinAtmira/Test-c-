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
            Coche Coche01 = new Coche(17.00);

            Console.WriteLine(" El resultado de la suma es: " + (var1 + var2));
            System.Console.WriteLine($"La variable 1 es:{var1}");

            miCirculo.calculoArea(4);            

            System.Console.WriteLine(Coche01.getInfoCoche());
        }
    }

    class Circulo{
        const double pi = 3.1416;
        public double calculoArea(int radio){
            return  pi * radio * radio;
        }
    }

    class Coche{
        private int ruedas;
        private double  largo;

        public Coche (double larcgoCoche){
            ruedas = 4;
            this.largo = larcgoCoche;
        }

        public String getInfoCoche(){
            return $"La información del coche es: Medidas={ruedas} y largo={largo}";
        }
    }
}
