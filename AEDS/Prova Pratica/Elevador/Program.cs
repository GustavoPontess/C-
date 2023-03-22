using System;
namespace Elevador
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] nc = Console.ReadLine().Split(' ');
            int cont = 0; bool res = false;
            for (int i = 0; i < int.Parse(nc[0]); i++)
            {
                string[] se = Console.ReadLine().Split(' ');
                cont -= int.Parse(se[0]);
                cont += int.Parse(se[1]);
                if (int.Parse(nc[1]) < cont)
                {
                    res = true;
                }
            }
            if (res)
            {
                Console.WriteLine("S");
            }else
            {
                Console.WriteLine("N");
            }
        }
    }
}