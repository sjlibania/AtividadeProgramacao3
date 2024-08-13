using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroValor;
            int segundoValor;

            Console.WriteLine("Digite o primeiro valor:");
            primeiroValor = int.Parse(Console.ReadLine());

            do
            {

                Console.WriteLine("Digite o segundo valor:");
                segundoValor = int.Parse(Console.ReadLine());

                if (segundoValor <= primeiroValor)
                {
                    Console.WriteLine("O segundo valor deve ser maior que o primeiro. Tente novamente.");
                }

            } while (segundoValor <= primeiroValor);

            // Aqui, segundoValor é garantidamente maior que primeiroValor
            Console.WriteLine($"Você digitou corretamente os valores: {primeiroValor} e {segundoValor}");





        }
    }
}
