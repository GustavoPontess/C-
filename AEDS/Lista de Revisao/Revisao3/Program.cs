using System;
namespace Revisao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int vT = 10, acima = 0;
            int total = 0, media = 0;
            int[] X = new int[vT];

            Random R = new Random();

            for (int i = 0; i < vT; i++)
            {
                X[i] = R.Next(0, 100);
                total = X[i];
            }

            media = total / 10;

            for (int i = 0; i < vT; i++){
                if (X[i] > media)
                {
                    acima++;
                }
            }
            Console.WriteLine($"Alunos acima da media {acima}");

        }
    }
}


