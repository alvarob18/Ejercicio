using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico
{
    public class Alquiler
    {
        private double costoTotal = 0;
        private int eleccion = 0;
        private bool descuento = false;

        public double CostoTotal
        {
            get
            {
                return costoTotal;
            }
            set
            {
                costoTotal = value;
            }
        }
        public bool Descuento
        {
            get
            {
                return descuento;
            }
            set
            {
                descuento = value;
            }
        }
        public int Eleccion
        {
            get
            {
                return eleccion;
            }
            set
            {
                eleccion = value;
            }
        }
        
        public void opciones(int n)
        {
            int cost = 0;
            switch(n)
            {
                case 1:
                    cost = 5;
                    CostoTotal += cost;
                    break;
                case 2:
                    cost = 20;
                    CostoTotal += cost;
                    break;
                case 3:
                    cost = 60;
                    CostoTotal += cost;
                    break;
                case 4:
                    Descuento = true;
                    break;
            }
        }
    }
}
