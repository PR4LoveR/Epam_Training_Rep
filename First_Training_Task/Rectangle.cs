using System;

namespace Rectangle_Name
{
    public class Rectangle
    {
        public Coordinates coordinatesA { get; set; }
        public Coordinates coordinatesB { get; set; }

        /*
         * public int perimetr;
         *
         * public Perimetr
         * {
         *      get {return 2 * (sideA + sideB)}
         * }
         * {
         *      perimetr = value;
         * }
         * */

        public static int sideA { get; set; }
        public static int sideB { get; set; }

        public Rectangle(Coordinates pointerA, Coordinates pointerB)
        {
            coordinatesA = pointerA;
            coordinatesB = pointerB;
        }
        public void GetSide()
        {
            if (coordinatesA.X < 0)
                sideA = (coordinatesA.X * (-1)) + coordinatesB.X;
            else if (coordinatesB.X < 0)
                sideA = (coordinatesB.X * (-1)) + coordinatesA.X;
            else sideA = coordinatesB.X - coordinatesA.X;

            if (coordinatesA.Y < 0)
                sideB = (coordinatesA.Y * (-1)) + coordinatesB.Y;
            else if (coordinatesB.Y < 0)
                sideB = (coordinatesB.Y * (-1)) + coordinatesA.Y;
            else sideB = coordinatesB.Y - coordinatesA.Y;

            if (sideA < 0)
                sideA = sideA * (-1);

            if (sideB < 0)
                sideB = sideB * (-1);

        }
        public int Perimeter()
        {
            return 2 * (sideA + sideB);
        }
        public int Square()
        {
            return sideA * sideB;
        }
    }
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
