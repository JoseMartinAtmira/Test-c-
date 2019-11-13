using System;
using System.Collections.Generic;

namespace temp
{
    enum estaciones {primavera=3, verano=5, otoño=7, invierno=9};
    class Program
    {        
        private const bool V = true;

        static void Main(string[] args)
        {       
            estaciones alrgia = estaciones.primavera;

            System.Console.WriteLine(alrgia );

            int var1 = 2;
            int var2 = 4;
            int[] valores = new int[4] { 5, 4, 9, 6 };
            int[] val2 = { 4, 5, 6 };
            Hijas.Circulo miCirculo = new Hijas.Circulo();
            Hijas.Coche Coche01 = new Hijas.Coche(17.00);
            Punto p = new Punto(3,4);

            p.esOlimpico(); 
            Punto.memorizar();            


            System.Console.WriteLine(string.Format("hola {0} y adios {1}",var1, var2));


            Hijas.Circulo[] Acirc = new Hijas.Circulo[3];
            List<int> listaInt = new List<int>();


            Console.WriteLine(" El resultado de la suma es: " + (var1 + var2));
            Console.WriteLine($"La variable 1 es:{var1}");

            miCirculo.calculoArea(4);

            Console.WriteLine(Coche01.getInfoCoche());

            for (int i = 0; i < valores.Length; i++)
            {
                System.Console.WriteLine(valores[i]);
            }

            foreach (Hijas.Circulo item in Acirc)
            {
                System.Console.WriteLine($"El item es: {item}");
            }

            String str = "123456";
            Boolean esPad = V;
            char pad = esPad ? '0' : '1';
            
            System.Console.WriteLine(str.PadRight(10, pad));
            System.Console.WriteLine(str.Length);

            Object obj = new Hijas.Coche(4.55);          
            
        }
    }

    public partial class Hijas
    {
        public class Circulo
        {
            public const double pi = 3.1416;
            public double calculoArea(int radio)
            {
                return pi * radio * radio;
            }
        }

        public class Coche : Circulo 
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

        public class Rectangulo
        {
            private int lado1;
            private int lado2;

            public int Lado1
            {
                get
                {
                    return lado1;
                }
                set
                {
                    lado1 = value;
                }
            }

            public int Lado2
            {
                get
                {
                    return lado2;
                }
                set
                {
                    lado2 = value;
                }
            }

            public int Area()
            {
                return this.lado1 * this.lado2;
            }
        }
    }

}