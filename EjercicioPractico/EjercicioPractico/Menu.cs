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
                Console.WriteLine("1. Alquilar por hora, cargando $5 por hora");
                Console.WriteLine("2. Alquilar por dia, cargando $20 por dia");
                Console.WriteLine("3. Alquilar por semana, cargando $60 por semana");

                if (opcionFamiliar != true)
                {
                    Console.WriteLine("4. Alquiler familiar, es una promocion que puede incluir desde 3 a 5 alquileres (de cualquier tipo) con un descuento de 30% del precio total");
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
