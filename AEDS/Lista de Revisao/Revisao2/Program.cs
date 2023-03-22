using System;
namespace Revisao2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            double resultado = x(ref raio);
            Console.WriteLine($"{resultado: F2}");
        }



        static double x(ref double raio)
        {
            raio = Math.Floor(raio);
            double volume = (4 * 3.14 * Math.Pow(raio, 3)) / 3;
            return volume;

        }
    }
}