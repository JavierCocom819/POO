using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueva.Entites;

namespace Prueva.Services
{
    public class Operacion
    {
        public double compra()
        {

            int s;
            double total=0;
            do
            {


                Producto ventaf = new Producto();

                Console.WriteLine("¿Que producto quieres comprar?");
                Console.WriteLine("(1)Tel_Sansun $3500");
                Console.WriteLine("(2)Kokakola $25");
                Console.WriteLine("(3)Alcohol_Iso $150");
                Console.WriteLine("(4)Cigarrillos $120");
                Console.WriteLine("(5)Laptop_Tell $4500");
                Console.WriteLine("(6)Mintendo_Chuich $4000");

                int o = int.Parse(Console.ReadLine());

                switch (o)
                {
                    case 1:
                        total = total + cantidad(ventaf.Tel_Sansun);
                        
                        break;
                    case 2:
                        total = total + cantidad(ventaf.Kokakola);
                        break;
                    case 3:
                        total = total + cantidad(ventaf.Alcohol_Iso);
                        break;
                    case 4:
                        total = total + cantidad(ventaf.Cigarrillos);
                        break;
                    case 5:
                        total = total + cantidad(ventaf.Laptop_Tell);
                        break;
                    case 6:
                        total = total + cantidad(ventaf.Mintendo_Chuich);
                        break;
                    default:

                        break;
                }
                Console.WriteLine("¿Quieres seguir comprando? (1)SI (2)NO");
                s=int.Parse(Console.ReadLine());
                Console.Clear();
            }while (s==1);
            total=descuento(total);
            return total;
        }
        public double cantidad(double b)
        {
            Console.WriteLine("¿Cuantos de estos productos quieres comprar?");
            int a=int.Parse(Console.ReadLine());
            double total = a * b;
            return total;
        }

        public double descuento(double total)
        {
            if (total >5000)
            {
                Console.WriteLine("Se aplicado un descuento del 10% por la compra mayor a 5,000");
                total = total - (total * 0.1);
                meses(total);
                return total;
            }
            else
            {
                
                return total;
            }
                
        }
        public double meses(double total)
        {
            if(total >8000 && total < 10000)
            {
                double mes3 = total / 3;
                Console.WriteLine("Puedes pagar 3 meses sin intereses por: " + mes3 + " cada mes");
            }
            if (total > 10000)
            {
                double mes12 = total / 12;
                Console.WriteLine("Puedes pagar 12 meses sin intereses por: " + mes12 + " cada mes");
            }
            return total;
        }
    }
}
