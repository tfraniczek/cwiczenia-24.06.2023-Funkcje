using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1_formatowanie_czasu
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą: ");
            int sekundy = Convert.ToInt32(Console.ReadLine());
            zmianaNaCzas(sekundy);
        }

        static void zmianaNaCzas(int sekundy)
        {
            TimeSpan dodaj_sekundy = TimeSpan.FromSeconds(sekundy);
            TimeSpan czasStartowy = new TimeSpan (0, 0, 0);
            TimeSpan wynik = czasStartowy + dodaj_sekundy;
            Console.WriteLine(wynik.ToString());
        }
    }
}
