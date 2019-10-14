using System;

namespace Puntos
{
    class Punto{
        private int x;
        private int y;

        public Punto(int x, int y){
            this.X = x;
            this.Y = y;
        }

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }
    }
} 