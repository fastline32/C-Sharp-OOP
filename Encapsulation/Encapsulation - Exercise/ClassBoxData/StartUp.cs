﻿using System;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine()!);
            double width = double.Parse(Console.ReadLine()!);
            double height = double.Parse(Console.ReadLine()!);

            Box box = null;
            try
            {
                box = new Box(length, width, height);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            

            Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.Volume():F2}");
        }
    }
}
