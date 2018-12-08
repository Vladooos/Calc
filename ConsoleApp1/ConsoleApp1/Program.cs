using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) {
            float chislo, chislo_1;
            string znak;

            Console.WriteLine("Vvedite 1 chislo:");
            chislo = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("\nVvedite 2 chislo:");
            chislo_1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\nVvedite znak:");
            znak = Console.ReadLine();
            if (znak == "+" ) Console.WriteLine("\nRezultat:" + (chislo + chislo_1));
            else 
                if (znak == "-" ) Console.WriteLine("\nRezultat:" + (chislo - chislo_1));
            else
                if (znak == "*" ) Console.WriteLine("\nRezultat:" + (chislo * chislo_1));
            else
                if (znak == "/" ) Console.WriteLine("\nRezultat:" + (chislo / chislo_1));
            Console.ReadLine();

        }
    }
}
