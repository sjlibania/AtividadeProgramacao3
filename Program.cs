﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int maiorValor = int.MinValue;
            int menorValor = int.MaxValue;
            int soma = 0;
            int positivos = 0;
            int negativos = 0;

            
            do
            {
                Console.Write("Digite a quantidade de números (positivo e menor que 20): ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0 || n >= 20)
                {
                    Console.WriteLine("Erro: A quantidade deve ser positiva e menor que 20.");
                }

            } while (n <= 0 || n >= 20);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                int valor = int.Parse(Console.ReadLine());

                
                if (valor > maiorValor)
                    maiorValor = valor;
                if (valor < menorValor)
                    menorValor = valor;

              
                soma += valor;

                if (valor > 0)
                    positivos++;
                else if (valor < 0)
                    negativos++;
            }

           
            double media = (double)soma / n;

            double porcentagemPositivos = (double)positivos / n * 100;
            double porcentagemNegativos = (double)negativos / n * 100;

            Console.WriteLine($"Maior valor: {maiorValor}");
            Console.WriteLine($"Menor valor: {menorValor}");
            Console.WriteLine($"Soma dos valores: {soma}");
            Console.WriteLine($"Média aritmética dos valores: {media}");
            Console.WriteLine($"Porcentagem de valores positivos: {porcentagemPositivos}%");
            Console.WriteLine($"Porcentagem de valores negativos: {porcentagemNegativos}%");

        }
    }
}
