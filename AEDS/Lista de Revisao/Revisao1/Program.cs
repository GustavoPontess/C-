using System;
namespace Revisao1
{
    class Program
    {
        static void Main(string[] args)
        { 
            double raio = double.Parse(Console.ReadLine());
            double resultado = x (raio);
            Console.WriteLine($"{resultado:F2}");
        }

        static double x (double raio) {
            double volume;
            volume = (4*3.14*Math.Pow(raio,3))/3;
            return volume;
        }
    }
}