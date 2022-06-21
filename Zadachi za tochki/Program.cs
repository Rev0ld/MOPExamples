using System;

namespace Zadachi_za_tochki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First coordinates
            int fx = 2;
            int fy = 3;
            int fz = 1;
            //Second Coordinates
            int sx = 4;
            int sy = 5;
            int sz = 1;
            //Razstoqnie dvumerno neshto si
            double d2 = Math.Sqrt(Math.Pow(sx - fx, 2) + Math.Pow(sy - fy, 2));
            //Razstoqnie trimerno neshto si
            double d3 = Math.Sqrt(Math.Pow(sx - fx, 2) + Math.Pow(sy - fy, 2) + Math.Pow(sz - fz, 2));

        }
        static void PolarCoord() 
        {
            //DECART TO POLAR
            //from coordinates "x" and "y" to "r"(radius) and "t"(angle)
            //find r from x and y with: r = math.Sqrt(x*x + y*y) pitagor
            
            //find sin"t" from y/r
            //find t from 1/sin"t"

            //POLAR TO DECART
            //y^2 = x^2 + r^2 - 2r*x

        public static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static double CalculateTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {

            double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            return side1 + side2 + side3;
        }
        static void Triugulnik()
        {

            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("{0:F2}", CalculateTriangle(coordinates[0], coordinates[1], coordinates[2], coordinates[3], coordinates[4], coordinates[5]));
        }
    }

}



        }
    }
}
