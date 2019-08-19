using System;

namespace Circle_Name
{
    public class Circle
    {
        private const double pi = 3.14;

        public static double Langth(int radius)
        {
            return 2 * pi * radius;
        }
        public static double Square(int radius)
        {
            return pi * (radius * radius);
        }
    }
}
