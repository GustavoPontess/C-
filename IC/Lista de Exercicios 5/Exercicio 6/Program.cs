using System;
using System.IO;
using System.Text;

namespace Exercicio_6
{
    class Program
    {
        // 6. Faça um programa que solicite ao usuário um número, em seguida, imprima na tela todos os 
        // seus divisores. Salve em um arquivo texto a soma total desses divisores.
        static void Main(string[] args)
        { 
            int num = 0, soma = 0;
            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Divisores do numero {num}:");
            for (int i = 1; i <= num; i++)
            {
                if (num%i == 0)
                {
                    Console.WriteLine(i);
                    soma += i;
                }
            }
            StreamWriter sw = new StreamWriter("exemplo.txt", true, Encoding.ASCII);
            sw.WriteLine($"A soma dos divisores do numero {num} e: {soma}");
            sw.Close();
            
        }
    }
}
