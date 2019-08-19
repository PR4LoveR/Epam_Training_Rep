using System;
using Circle_Name;
using Rectangle_Name;
using ComplexNumber_Name;

namespace First_Training_Task
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;
            Console.Write("Виберіть завдання\n");
            Console.Write("1 -> Rectangle\n");
            Console.Write("2 -> ComplexNumber\n");
            Console.Write("3 -> Circle\n");
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Coordinates coordinatesA = new Coordinates(0, 0);
                    Coordinates coordinatesB = new Coordinates(0, 0);

                    Console.Write("Точка A, координата X = ");
                    coordinatesA.X = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Точка A, координата Y =");
                    coordinatesA.Y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Точка B, координата X =");
                    coordinatesB.X = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Точка B, координата Y =");
                    coordinatesB.Y = Convert.ToInt32(Console.ReadLine());

                    Rectangle rectangle = new Rectangle(coordinatesA, coordinatesB);

                    rectangle.GetSide();

                    int perimeter = rectangle.Perimeter();
                    int square = rectangle.Square();

                    Console.WriteLine("Square is = " + square);
                    Console.WriteLine("Perimeter is = " + perimeter);
                    break;
                case 2:
                    ComplexNumber complex1 = new ComplexNumber(0, 0);
                    ComplexNumber complex2 = new ComplexNumber(0, 0);

                    Console.Write("Уявна частина першого числа = ");
                    complex1.i = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Реальна частина першого числа = ");
                    complex1.r = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Уявна частина другого числа = ");
                    complex2.i = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Реальна частина другого числа = ");
                    complex2.r = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Imeg = " + (complex1 * complex2).i + "\nReal = " + ((complex1 * complex2).r * (-1)));
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Write("Введіть радіус = ");
                    int rad = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Довжина кола = {0}\n Площа круга = {1}", Circle.Langth(rad), Circle.Square(rad));
                    break;
                default:
                    Console.WriteLine("Ви ввели невідомий номер");
                    break;
            }

        }
    }
}
