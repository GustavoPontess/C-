using System;
using System.Globalization;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        { 
            Funcionario user1, user2;
            user1 = new Funcionario();
            user2 = new Funcionario();

            // Solicitando entrada de dados
            Console.WriteLine("Qual o seu nome?");
            // Acessando um atributo do objeto e atribuindo o nome da pessoa
            user1.Nome = Console.ReadLine()!;
            Console.WriteLine("Qual o seu salario?");
            user1.Salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine("Qual o seu nome?");
            // Acessando um atributo do objeto e atribuindo o nome da pessoa
            user2.Nome = Console.ReadLine()!;
            Console.WriteLine("Qual o seu salario?");
            user2.Salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine($"Sálario médio = {(user1.Salario+user2.Salario)/2.0:F2}");
        }
    }
}