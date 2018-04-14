using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu menu = new Menu();

                menu.muestraMenu();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un errror.");
            }
        }
    }
}
