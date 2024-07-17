using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;

            Console.WriteLine("Tabuada do número " + numero + ":");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));


            }
        }
    }
}
