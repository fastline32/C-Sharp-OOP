using System;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private readonly int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public void Draw()
        {
            double radiusIn = this.radius - 0.4;
            double radiusOut = this.radius + 0.4;
            for (double i = this.radius; i >= -this.radius ; --i)
            {
                for (double j = -this.radius; j <= radiusOut; j += 0.5)
                {
                    double value = j * j + i * i;
                    if (value >= radiusIn*radiusIn && value <= radiusOut*radiusOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
