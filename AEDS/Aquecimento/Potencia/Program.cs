using System;
namespace Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                Console.WriteLine(Elevado(numeros));
            }
        }

        static double Elevado(string[] numeros)
        {
            return Math.Pow(double.Parse(numeros[0]), double.Parse(numeros[1]));
        }
    }
}