using System;
namespace Plano_de_Internet
{
    class Program
    {
        static void Main(string[] args)
        {
            int qMensal = int.Parse(Console.ReadLine());
            int Meses = int.Parse(Console.ReadLine());
            int sobra = 0;

            for (int i = 0; i < Meses; i++)
            {
                sobra += qMensal - int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sobra+qMensal);
        }
    }
}