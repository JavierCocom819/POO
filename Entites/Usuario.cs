using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueva.Entites
{
    public class Usuario
    {
        string Nombre { get; set; }
        string Correo { get; set; }
        string Telefono { get; set; }

        
         public Usuario()
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingresa tu nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu correo");
            Correo = Console.ReadLine();
            Console.WriteLine("Ingresa tu telefono");
            Telefono = Console.ReadLine();
            Console.Clear();
        }
        public void mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("----Datos----");
            Console.WriteLine();
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Correo: " + Correo);
            Console.WriteLine("Telefono: " + Telefono);
        }
    }

}
