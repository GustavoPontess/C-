using System;
namespace Revisao5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um nJmero inteiro: ");
            int num = int.Parse(Console.ReadLine()!);
            int j = recebe(num);
            Console.WriteLine(j);
        }
        static int recebe(int num)
        {
            int resultado = 1;

            while (num != 1)
            {

                resultado = resultado * num;
                num = num - 1;
            }
            return resultado;
        }
    }
}