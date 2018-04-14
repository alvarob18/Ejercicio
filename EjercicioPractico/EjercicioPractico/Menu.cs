using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico
{
    class Menu
    {
        public void muestraMenu()
        {
            string respuesta = "";
            bool descuento = false;
            bool opcionFamiliar = false;
            int eleccion;
            int cont = 0;
            Alquiler alquiler = new Alquiler();

            do
            {
            inicio:
                if ((opcionFamiliar) && (cont > 0))
                {
                    Console.WriteLine("Desea alquilar algo mas? escriba s para si y n para no.");
                    respuesta = Console.ReadLine();
                }
                if (respuesta == "n")
                {
                    break;
                }
                Console.WriteLine("1. Rental by hour, charging $5 per hour");
                Console.WriteLine("2. Rental by day, charging $20 a day");
                Console.WriteLine("3. Rental by week, changing $60 a week");

                if (opcionFamiliar != true)
                {
                    Console.WriteLine("4. Family Rental, is a promotion that can include from 3 to 5 Rentals (of any type) with a discount of 30% of the total price");
                }
                alquiler.Eleccion = Convert.ToInt32(Console.ReadLine());

                alquiler.opciones(alquiler.Eleccion);

                if (alquiler.Eleccion == 4)
                {
                    opcionFamiliar = true;
                    goto inicio;
                }
                cont++;
                if (cont > 4)
                {
                    opcionFamiliar = false;
                }

            } while (opcionFamiliar);

            if (!alquiler.Descuento)
                Console.WriteLine("El costo total es: " + alquiler.CostoTotal);
            else
            {
                alquiler.CostoTotal = alquiler.CostoTotal * 0.70;
                Console.WriteLine("El costo total es: " + alquiler.CostoTotal);
            }
        }
    }
}
