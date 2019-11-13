using System;

namespace temp
{
    class  Punto{
        private int x;
        private int y;

        public Punto(int x, int y){
            this.X = x;
            this.Y = y;
        }

        public override string ToString(){
            string _str = "x: " + x + "y: " + y;

            return _str;
        }
        
        public static void memorizar(){
            System.Console.WriteLine("hola");
        }

        public Boolean esOlimpico() => true;

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }
    }
} 