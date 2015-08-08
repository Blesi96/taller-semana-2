using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c4
{
    class Program
    {
        enum Days { domingo, lunes, martes, miercoles, jueves, viernes, sabado };
        static void Main(string[] args)
        {
            int numero;
            string dato;
            Console.WriteLine("ingrese un numero, 1 siendo domingo 7 siendo sabado");
            dato = Console.ReadLine();

            if (int.TryParse(dato, out numero))
            {
                if (numero == 1)
                {
                    Console.WriteLine(Days.domingo);
                }
                if (numero == 2)
                {
                    Console.WriteLine(Days.lunes);
                }
                if (numero == 3)
                {
                    Console.WriteLine(Days.martes);
                }
                if (numero == 4)
                {
                    Console.WriteLine(Days.miercoles);
                }
                if (numero == 5)
                {
                    Console.WriteLine(Days.jueves);
                }
                if (numero == 6)
                {
                    Console.WriteLine(Days.viernes);
                }
                if (numero == 7)
                {
                    Console.WriteLine(Days.sabado);
                }
            }
            Console.ReadKey();
        }
    }
}
