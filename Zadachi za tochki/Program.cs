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




        }
    }
}
