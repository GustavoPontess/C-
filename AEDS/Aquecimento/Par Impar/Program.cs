using System;
namespace Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            while (num > 0)
            {
                num = int.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("PAR");
                    }
                    else
                    {
                        Console.WriteLine("IMPAR");
                    }
                }
            }
        }
    }
}