namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. Escrever um procedimento que preenche uma matriz M(10,10) e a escreve. Faça outros 
            // procedimentos que recebam uma matriz preenchida, realize as trocas indicadas a seguir 
            // (um procedimento para cada uma delas) e exiba a matriz resultante da troca:
            // a) a linha 2 com a linha 8
            // b) a coluna 4 com a coluna 10
            // c) a diagonal principal com a diagonal secundária
            // d) a linha 5 com a coluna 10.

            // Faça um programa que faça as devidas declarações e acione os módulos para exemplificar o seu uso.

            int linha = 10, coluna = 10;
            int[,] A = new int[linha, coluna];
            int[,] B = new int[,] { };


            inicio(ref A, ref B, linha, coluna);
            questaoA(ref A, ref B, linha, coluna);
            questaoB(ref A, ref B, linha, coluna);
            questaoC(ref A, ref B, linha, coluna);
            questaoD(ref A, ref B, linha, coluna);
        }
        //procedimento que preenche a matriz e chama o procedimento de imprimir a matriz
        static void inicio(ref int[,] A, ref int[,] B, int linha, int coluna)
        {
            Random R = new Random();
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    A[i, j] = R.Next(0, 10);
                }
            }
            imprime(A, B, linha, coluna);
        }
        //procedimento que imprime matrizes
        static void imprime(int[,] A, int[,] B, int linha, int coluna)
        {
            if (B.Length != 0)
            {
                Console.WriteLine("==========Matriz A==========      ==========Matriz B==========");
            }
            else
            {
                Console.WriteLine("==========Matriz A==========");
            }
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (j == (coluna - 1))
                    {
                        if (B.Length != 0)
                        {
                            Console.Write(A[i, j] + "      ");
                            for (int x = 0; x < coluna; x++)
                            {
                                if (x == (coluna - 1))
                                {
                                    Console.WriteLine(B[i, x]);
                                }
                                else
                                {
                                    Console.Write(B[i, x] + "  ");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(A[i, j]);
                        }

                    }
                    else
                    {
                        Console.Write(A[i, j] + "  ");
                    }
                }
            }
            Console.WriteLine();
        }
        //procedimento que troca a linha 2 com a linha 8
        static void questaoA(ref int[,] A, ref int[,] B, int linha, int coluna)
        {
            B = new int[linha, coluna];
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (i == 1)
                    {
                        B[7, j] = A[i, j];
                    }
                    else if (i == 7)
                    {
                        B[1, j] = A[i, j];
                    }
                    // else
                    // {
                    //     B[i, j] = A[i, j];
                    // }
                }
            }
            imprime(A, B, linha, coluna);
        }
        //procedimento que troca a coluna 4 com a coluna 10
        static void questaoB(ref int[,] A, ref int[,] B, int linha, int coluna)
        {
            B = new int[linha, coluna];
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (j == 3)
                    {
                        B[i, 9] = A[i, j];
                    }
                    else if (j == 9)
                    {
                        B[i, 3] = A[i, j];
                    }
                    // else
                    // {
                    //     B[i, j] = A[i, j];
                    // }
                }
            }
            imprime(A, B, linha, coluna);
        }
        //procedimento que troca a diagonal principal com a diagonal secundária
        static void questaoC(ref int[,] A, ref int[,] B, int linha, int coluna)
        {
            B = new int[linha, coluna];
            int cont = coluna;
            int cont1 = coluna;
            int cont2 = 0;

            for (int x = 0; x < linha; x++)
            {
                for (int y = 0; y < coluna; y++)
                {
                    if (x == y) //descubro a posição da minha diagonal principal 
                    {
                        B[x, (cont - 1)] = A[x, y]; //pego o valor da diagonal principal e atribuo a posição da diagonal secundaria
                        cont--;
                    }
                    else if (y == (cont1 - 1)) // descubro a posição da diagonal secundaria
                    {
                        B[cont2, cont2] = A[x, (cont1 - 1)]; // pego o valor da diagonal secundaria e atribuo a posição da diagonal principal
                        cont1--;
                        cont2++;
                    }
                    // else
                    // {
                    //     B[x, y] = A[x, y];
                    // }
                }
            }
            imprime(A, B, linha, coluna);
        }
        //procedimento que troca a linha 5 com a coluna 10.
        static void questaoD(ref int[,] A, ref int[,] B, int linha, int coluna)
        {
            B = new int[linha, coluna];
            int li = 0;
            int co = 0;
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (i == 4)
                    {
                        B[li, 9] = A[i, j];
                        li++;
                    }
                    if (j == 9)
                    {
                        B[4, co] = A[i, j];
                        co++;
                    }
                    // if(i!=4&&j!=9)
                    // {
                    //     B[i, j] = A[i, j];
                    // }
                }
            }
            imprime(A, B, linha, coluna);
        }
    }
}