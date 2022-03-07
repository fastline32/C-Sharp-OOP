using System;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; private set; }
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            return perimeter;
        }
        public override double CalculateArea()
        {
            double area = Math.PI* Radius * Radius;
            return area;
        }

        public override string Draw()
        {
            double consoleRatio = Convert.ToDouble(4.0 / 2.0);
            double a = consoleRatio * Radius;
            double b = Radius;
            var sb = new StringBuilder();

            for (double y = -Radius; y <= Radius; y++)
            {
                for (double x = -a; x <= a; x++)
                {
                    double d = (x / a) * (x / a) + (y / b) * (y / b);
                    if (d > 1 && d < 1.2)
                    {
                        sb.Append('*');
                    }

                    else
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}