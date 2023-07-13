using System;
namespace Revisao4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[12, 4];
            Random R = new Random();
            int totalM = 0, totalA = 0;

            for (int linha = 0; linha < 12; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {

                    matriz[linha, coluna] = R.Next(1, 15);
                    totalM += matriz[linha, coluna];
                    Console.WriteLine($"Total mes {linha + 1}: {totalM}");
                    totalA += totalM;
                }
                totalM = 0;
            }
            Console.WriteLine($"Total ano: {totalA}");
        }
    }
}

















