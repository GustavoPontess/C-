namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. Faça um procedimento que preencha 2 matrizes, A 4 x 6 e B 4 x 6. Faça uma função para 
            // cada uma das situações a seguir, que recebe duas matrizes preenchidas, calcula e retorna 
            // as matrizes indicadas :
            // a) uma matriz S que seja a soma de A e B.
            // b) uma matriz D que seja a diferença de A e B. (A - B).
            // Faça um programa que faça as devidas declarações e acione os módulos para exemplificar o 
            // seu uso. Escreva as matrizes resultantes do acionamento de cada uma das funções.

            int linha = 4, coluna = 6;
            int[,] A = new int[linha, coluna];
            int[,] B = new int[linha, coluna];
            int[,] C = new int[,] { };

            preencher(ref A, ref B, linha, coluna);
            imprime(ref A, ref B, ref C, linha, coluna);
            C = calculaA(ref A, ref B, linha, coluna);
            imprime(ref A, ref B, ref C, linha, coluna, '+');
            C = calculaB(ref A, ref B, linha, coluna);
            imprime(ref A, ref B, ref C, linha, coluna, '-');

        }
        //procedimento que preenche as matizes
        static void preencher(ref int[,] A, ref int[,] B, int linha, int coluna)
        {
            Random R = new Random();
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    A[i, j] = R.Next(0, 10);
                    B[i, j] = R.Next(0, 10);
                }
            }
        }
        //procedimento que imprime matrizes
        static void imprime(ref int[,] A, ref int[,] B, ref int[,] C, int linha, int coluna, char operador = ' ')
        {
            if (operador != ' ')
            {
                Console.WriteLine($"    Matriz A      {operador}       Matriz B       =      Resultado    ");
            }
            else
            {
                Console.WriteLine("    Matriz A              Matriz B    ");
            }
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (j == (coluna - 1))
                    {
                        Console.Write(A[i, j] + "      ");
                        for (int x = 0; x < coluna; x++)
                        {
                            if (x == (coluna - 1))
                            {
                                if (operador != ' ')
                                {
                                    Console.Write(B[i, x] + "      ");
                                    for (int y = 0; y < coluna; y++)
                                    {
                                        if (y == (coluna - 1))
                                        {
                                            Console.WriteLine(C[i, y]);
                                        }
                                        else
                                        {
                                            Console.Write(C[i, y] + "  ");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(B[i, x]);
                                }
                            }
                            else
                            {
                                Console.Write(B[i, x] + "  ");
                            }
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
        //funcao que soma matriz e retornar uma matriz;
        static int[,] calculaA(ref int[,] A, ref int[,] B, int linha, int coluna)
        {
            int[,] C = new int[linha, coluna];
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                   C[i,j] = A[i,j] + B[i,j];
                }
            }
            return (C);
        }
        //funcao que subtrai matriz e retornar uma matriz;
        static int[,] calculaB(ref int[,] A, ref int[,] B, int linha, int coluna)
        {
            int[,] C = new int[linha, coluna];
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                   C[i,j] = A[i,j] - B[i,j];
                }
            }
            return (C);
        }
    }
}