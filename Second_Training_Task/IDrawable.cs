using System;
using System.Collections;

namespace IDrawableMethod
{
    public interface IDrawable
    {
        void Draw();
    }

    public class Some_Figure
    {
        public readonly int X;
        public readonly int Y;

        public Some_Figure(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    public class Some_Square : Some_Figure, IDrawable
    {
        public Some_Square(int X, int Y)
            : base(X, Y)
        {

        }

        public void Draw()
        {
            Console.WriteLine("I'm square");
        }
    }

    public class Some_Rectangle : Some_Figure, IDrawable
    {
        public Some_Rectangle(int X, int Y)
            : base(X, Y)
        {

        }

        public void Draw()
        {
            Console.WriteLine("I'm rectangle");
        }
    }
}
