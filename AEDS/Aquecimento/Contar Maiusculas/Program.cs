using System;
namespace Contar_Maiusculas
{
    class Program
    {
        // 1. Faça um programa para ler uma frase e contar quantos caracteres são espaços em brancos.
        static void Main(string[] args)
        {
            string str = " ";
            while (str != "FIM")
            {
                str = Console.ReadLine();
                Count(str);
            }
        }

        static void Count(string str)
        {
            int upper = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    upper++;
            }
            if (str != "FIM")
            {
                Console.WriteLine(upper);
            }
        }
    }
}