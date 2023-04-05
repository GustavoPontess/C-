using System;
using System.IO;
using System.Text;

namespace Exercicio_5
{
    class Program
    {
        // 5. Implemente um programa que leia um arquivo texto e imprima, linha a linha, o seu conteúdo na tela. 
        // Imprima também a quantidade de linhas que este arquivo possui.
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("exemplo.txt", false, Encoding.ASCII);
            for (int x = 0; x < 10; x++)
            {
                sw.WriteLine(x);
            }
            sw.Close();
            StreamReader sr = new StreamReader("exemplo.txt");
            String line = sr.ReadLine()!;
            int cont = 0;
            while (line != null)
            {
                Console.WriteLine(line);
                cont++;
                line = sr.ReadLine()!;
            }
            Console.WriteLine($"O documente tem {cont} linhas");
            sr.Close();
        }
    }
}
