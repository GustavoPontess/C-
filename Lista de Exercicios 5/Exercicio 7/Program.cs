using System;
using System.IO;
using System.Text;

namespace Exercicio_7
{
    class Program
    {
        // 7. Faça um programa para inserir N letras informadas pelo usuário em um arquivo texto. Onde N é uma quantidade 
        // de letras definida pelo usuário. Depois de inseridas as N letras, o programa deverá ler todas as N letras do 
        // arquivo, calcular e mostrar a quantidade de vogais, ou seja, quantas letras a, e, i, o, u.
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("exemplo.txt", false, Encoding.ASCII);
            int num = 0;
            Console.Write("Digite a quantidade de letras que deseja informar: ");
            num = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Digite a {i}° letra: ");
                sw.WriteLine(Console.ReadLine());
            }
            sw.Close();
            StreamReader sr = new StreamReader("exemplo.txt");
            String line = sr.ReadLine()!;
            int cont = 0;
            string[] vogais = new string[] { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };
            while (line != null)
            {
                foreach (var vogal in vogais)
                {
                    if (vogal == line)
                    {
                        cont++;
                    }
                }
                line = sr.ReadLine()!;
            }
            Console.WriteLine($"O documente tem {cont} vogais");
            sr.Close();
        }
    }
}
