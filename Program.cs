using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_2
{
    class Program
    {
        public class Myint
        {
            public int MyValue;
        }
        static void Main(string[] args)
        {
            //volumen es pi*radiocuadrado por la altura
            //area 2pi radio *(altura+radio)
            /*  C1 
                string r, h;
                double v, a,radio,altura;
                do{
                Console.WriteLine("ingrese el radio, si quiere salir escriba exit \n");
                r = Console.ReadLine();
                Console.WriteLine("ingrese la altura \n");
                h = Console.ReadLine();
                if (double.TryParse(r, out radio) && double.TryParse(h, out altura))
                {
                    v = (Math.PI * (radio * radio) * altura);
                    a = 2 * Math.PI * radio * (altura + radio);
                    Console.WriteLine("el volumen es " + v);
                    Console.WriteLine("el area es " + a);
                }
                else {
                    Console.WriteLine("ingrese un numero la proxima vez \n");
                }}while(r != "exit");*/

            //C2
            /* int a = 7;
             int b = 2;
             float c = 4;
             float d = 3;
             float result = (float)((float)(a) / (float)(b)) + (c / d);
             Console.WriteLine(result);
             Console.ReadKey();
             */
            /*    short a = 30000;
               short b = 30000;
                short sum= (short)(a+b);
                Console.WriteLine("el resultado es " + sum);
                Console.ReadKey();
                */

            /* punto 14
            int[] scores = new int[10] { 100,95, 92, 87, 55, 50, 48, 40, 35, 10 };
                Console.WriteLine(scores[5]);
                Console.ReadKey();
              */

            //C3
            /*
                        int[] datos=new int[] {4,51,-7,13,-99,15,-8,45,90};
                        int i=0;
                        int mayor, menor;
                        mayor = datos[0];
                        menor = datos[0];
                        foreach (int element in datos)
                        {

                            if (i < 8)
                            {
                                if (datos[i] < datos[i + 1])
                                {
                                    i++;
                                    if (mayor < datos[i])
                                    {
                                        mayor = datos[i];
                                    }
                                }else{
                                i++;
                                if (datos[i] < menor)
                                {
                                    menor = datos[i];
                                }
                            }
                            }
                
                        }Console.WriteLine("el mayor es "+mayor+"\n el menor es "+menor);
            
                        Console.ReadKey();

                        */
            //P23
            /*  int[] a = new int[] { 1, 2, 3 };
               int[] b = a;
               b[0] = 17;
               Console.WriteLine(a[0]);
               Console.ReadKey();*/

            // p24
            /*Console.WriteLine("ReturnValue() es: {0}", ReturnValue());
            Console.WriteLine("ReturnValue() es: {0}", ReturnValue2());
            Console.ReadKey();
        }
        public static int ReturnValue()
        {
            int x = new int();
            x = 3;
            int y = new int();
            y = x;
            y = 4;
            return x;
        }
        public static int ReturnValue2()
        {
            Myint x = new Myint();
            x.MyValue = 3;
            Myint y = new Myint();
            y = x;
            y.MyValue = 4;
           return x.MyValue;}
            */


        } //c4
        enum Days { domingo, lunes, martes, miercoles, jueves, viernes, sabado };
        static void Main(string[] args)
        {
            int numero;
            string dato;
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
