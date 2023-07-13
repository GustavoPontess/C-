using System;

namespace _1001
{
    class Program
    {
        static void Main(string[] args)
        {
            int A =  0,  B = 0, SOMA = 0;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine()); 
            SOMA = A + B;
            Console.WriteLine($"SOMA = {SOMA}");
        }
    }
}