using System;
using IDrawableMethod;

namespace Second_Training_Task
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Some_Figure square = new Some_Square(3, 6);
            Some_Figure rectangle = new Some_Rectangle(3, 6);
            DrawAll(square as IDrawable, rectangle as IDrawable);
        }

        public static void DrawAll(params IDrawable[] drawables)
        {
            foreach (IDrawable i in drawables)
            {
                i.Draw();
            }
        }
    }

    class Figure
    {
        public readonly int X;
        public readonly int Y;

        public Figure(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public virtual void Draw()
        {
            Console.WriteLine("I'm some figure");
        }

    }

    class Square : Figure
    {
        public Square(int X, int Y)
            : base(X, Y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("I'm square");
        }
    }

    class Rectangle : Figure
    {
        public Rectangle    (int X, int Y)
            : base(X, Y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("I'm rectangle");
        }
    }
}
