using System;
using System.Collections.Generic;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 2;
            int var2 = 4;
            int[] valores = new int[4] { 5, 4, 9, 6 };
            int[] val2 = { 4, 5, 6 };
            Circulo miCirculo = new Circulo();
            Coche Coche01 = new Coche(17.00);
                        

            Circulo[] Acirc = new Circulo[3];
            List<int> listaInt = new List<int>();


            Console.WriteLine(" El resultado de la suma es: " + (var1 + var2));
            Console.WriteLine($"La variable 1 es:{var1}");

            miCirculo.calculoArea(4);

            Console.WriteLine(Coche01.getInfoCoche());

            for (int i = 0; i < valores.Length; i++)
            {
                System.Console.WriteLine(valores[i]);
            }

            foreach (Circulo item in Acirc)
            {
                System.Console.WriteLine($"El item es: {item}");
            }
            
            String str = "123456";
            char pad = '0';
            System.Console.WriteLine(str.PadRight(10,pad));            

        }
    }

    class Circulo
    {
        public const double pi = 3.1416;
        public double calculoArea(int radio)
        {
            return pi * radio * radio;
        }
    }

    class Coche: Circulo
    {
        private int ruedas;
        private double largo;

        public Coche(double larcgoCoche)
        {
            ruedas = 4;
            this.largo = larcgoCoche;
        }

        public String getInfoCoche()
        {
            return $"La información del coche es: Medidas={ruedas} y largo={largo}";
        }
    }

    class Rectangulo{
        private int lado1;
        private int lado2;

        public int Lado1{
            get{
                return lado1;
            }
            set{
                lado1 = value;
            }
        }

        public int Lado2{
            get{
                return lado2;
            }
            set{
                lado2 = value;
            }
        }

        public int Area (){
            return this.lado1 * this.lado2;
        }
    }
}
