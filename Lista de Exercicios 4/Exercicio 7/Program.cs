namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Faça um procedimento que preencha uma matriz M 5 x 5. Faça uma função que receba uma 
            // matriz preenchida, calcule e retorne cada uma das somas a seguir 
            // (uma função para cada item abaixo):
            // a) da linha 4 de M
            // b) da coluna 2 de M
            // c) da diagonal principal
            // d) da diagonal secundária
            // e) de todos os elementos da matriz.
            // Faça um programa que faça as devidas declarações e acione os módulos para exemplificar o seu uso.

            preenche();

        }
        //Criando procedimento para preenchimento da matriz
        static void preenche()
        {
            int val = 5;
            int[,] M = new int[val, val];
            Random R = new Random();
            for (int x = 0; x < val; x++)
            {
                for (int y = 0; y < val; y++)
                {
                    M[x, y] = R.Next(0, 10);
                }
            }
            imprime(M);
            Console.WriteLine($"A Soma da linha 4               : {calculaA(M)}");
            Console.WriteLine($"A Soma da coluna 2              : {calculaB(M)}");
            Console.WriteLine($"A Soma da diagonal principal    : {calculaC(M)}");
            Console.WriteLine($"A Soma da diagonal secundaria   : {calculaD(M)}");
            Console.WriteLine($"A Soma de tudo                  : {calculaE(M)}");
        }
        static int calculaA(int[,] M)
        {
            int resultado = 0;
            for (int x = 0; x < 5; x++)
            {
                resultado += M[3, x];
            }
            return (resultado);
        }
        static int calculaB(int[,] M)
        {
            int resultado = 0;

            for (int x = 0; x < 5; x++)
            {
                resultado += M[x, 1];
            }
            return (resultado);
        }
        static int calculaC(int[,] M)
        {
            int resultado = 0;

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (x == y)
                    {
                        resultado += M[x, y];
                    }
                }
            }
            return (resultado);
        }
        static int calculaD(int[,] M)
        {
            int resultado = 0;
            int cont = 4;

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (y == cont)
                    {
                        resultado += M[x, cont];
                        cont--;
                    }
                }
            }
            return (resultado);
        }
        static int calculaE(int[,] M)
        {
            int resultado = 0;
            foreach (var item in M)
            {
                resultado += item;
            }
            return (resultado);
        }
        static void imprime(int[,] M){
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (y == 4)
                    {
                        Console.WriteLine(M[x, y]);
                    }
                    else
                    {
                        Console.Write(M[x, y] + " ");
                    }
                }
            }
        }
        // static int[] calcula(int[,] M)
        // {

        //     int[] resultado = new int[5];
        //     int cont = 4;

        //     for (int x = 0; x < 5; x++)
        //     {
        //         resultado[0] += M[3, x];
        //         resultado[1] += M[x, 1];
        //         for (int y = 0; y < 5; y++)
        //         {
        //             if (x == y)
        //             {
        //                 resultado[2] += M[x, y];
        //             }
        //             if (y == cont)
        //             {
        //                 resultado[3] += M[x, cont];
        //                 cont--;
        //             }
        //         }
        //     }
        //     foreach (var item in M)
        //     {
        //         resultado[4] += item;
        //     }
        //     // for (int x = 0; x < 5; x++)
        //     // {
        //     //     for (int y = 0; y < 5; y++)
        //     //     {
        //     //         if (y == 4)
        //     //         {
        //     //             Console.WriteLine(M[x, y]);
        //     //         }
        //     //         else
        //     //         {
        //     //             Console.Write(M[x, y] + " ");
        //     //         }
        //     //     }
        //     // }
        //     // foreach (var item in resultado)
        //     // {
        //     //     Console.WriteLine(item);
        //     // }
        //     return (resultado);
        // }
    }
}