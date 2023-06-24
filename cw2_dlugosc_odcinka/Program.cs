using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2_dlugosc_odcinka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj położenie pierwszego punktu (najpierw X, później Y): ");
            double x1 =Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj położenie drugiego punktu (najpierw X, później Y): ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Odległość między punktami wynosi: " + dystans(x1, x2, y1, y2));
        }
        static double dystans(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }
    }
}
