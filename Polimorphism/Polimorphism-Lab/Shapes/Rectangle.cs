using System;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; private set; }
        public double Width { get; private set; }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (Height + Width);
            return perimeter;
        }

        public override double CalculateArea()
        {
            double area = Height*Width;
            return area;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('*',(int)Width));
            for (int i = 1; i < Height - 1; i++)
            {
                sb.AppendLine("*" + new string(' ',(int)Width-2) + "*");
            }
            sb.AppendLine(new string('*', (int)Width));
            return sb.ToString();
        }
    }
}