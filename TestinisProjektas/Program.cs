using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestinisProjektas
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Suma(1, 3);
            Console.WriteLine($"SUMA: {sum}");
            ExitApp();
        }

        static int Suma(int pirmasDemuo, int antrasDemuo)
        {
            return pirmasDemuo + antrasDemuo;
        }

        static int Atimtis(int pirmasDemuo, int antrasDemuo)
        {
            return pirmasDemuo - antrasDemuo;
        }

        static int Daugyba(int pirmasDemuo, int antrasDemuo)
        {
            return pirmasDemuo * antrasDemuo;
        }

        static void ExitApp()
        {
            //---------------------------
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
