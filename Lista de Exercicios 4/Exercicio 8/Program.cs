namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Faça um programa para preencher uma matriz 4 x 4, em seguida apresentar na 
            // tela a soma dos elementos abaixo da diagonal principal. Mostre na tela os elementos da 
            // diagonal principal também.

            int val = 4, cont = 0, soma = 0;
            int[,] M = new int[val, val];
            Random R = new Random();
            for (int x = 0; x < val; x++)
            {
                
                for (int y = 0; y < val; y++)
                {
                    M[x, y] = R.Next(0, 10);

                    if (y == (val - 1))
                    {
                        if (x == y)
                        {
                            Console.WriteLine(M[x, y]);
                        }
                        Console.WriteLine("   ");
                    }
                    else
                    {
                        if (x == y)
                        {
                            Console.Write(M[x, y]);
                        }
                        Console.Write("   ");
                    }
                }
            }
            
            for (int x = 0; x < val; x++)
            {
                if (x == (cont + 1))
                {
                    soma += M[x, cont];
                    cont++;
                }
                // for (int y = 0; y < val; y++)
                // {
                //     if (y == (val - 1))
                //     {
                //         Console.WriteLine(M[x, y]);
                //     }
                //     else
                //     {
                //         Console.Write(M[x, y] + "  ");
                //     }
                // }
            }
            Console.WriteLine($"A soma dos numeros abaixo da diagonal e: {soma}");
        }
    }
}