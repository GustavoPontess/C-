using System;
using System.IO;
using System.Text;

namespace Exercicio_10
{
    class Program
    {
        // 10. Considere um arquivo texto que armazene números em ponto flutuante em cada uma de suas linhas. 
        // Escreva um programa que determine o valor máximo, o valor mínimo e a média desses valores armazenados no 
        // arquivo. Imprima esses valores na tela.
        static void Main(string[] args)
        { 
            Random R = new Random();
            StreamWriter sw = new StreamWriter("exemplo.txt", false, Encoding.ASCII);
            for (int x = 0; x < 10; x++)
            {
                sw.WriteLine(R.NextDouble());
            }
            sw.Close();
            StreamReader sr = new StreamReader("exemplo.txt");
            String line = sr.ReadLine()!;
            double maior = Convert.ToDouble(line), menor = Convert.ToDouble(line), media = 0;
            int cont = 0;
            while (line != null)
            {
                cont++;
                if (Convert.ToDouble(line) > maior)
                {
                    maior = Convert.ToDouble(line);
                }else if(Convert.ToDouble(line) < menor){
                    menor = Convert.ToDouble(line);
                }
                media += Convert.ToDouble(line);
                line = sr.ReadLine()!;
            }
            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine($"Media dos valores: {media/cont}");
            sr.Close();
        }
    }
}
