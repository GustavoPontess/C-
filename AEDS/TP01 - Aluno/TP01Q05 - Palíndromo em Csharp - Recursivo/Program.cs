using System;

namespace TP01Q05___Palíndromo_em_Csharp___Recursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindromo = Console.ReadLine();
            isPalindromo(palindromo, 0, palindromo.Length);
        }

        static void isPalindromo(string palindromo, int i, int quantidade)
        {
            int metade = palindromo.Length / 2;
            if (quantidade % 2 == 0 && i == 0)
            {
                metade = (quantidade - 1) / 2;
            }
            if (palindromo != "FIM")
            {
                if (i < metade + 1)
                {
                    if (palindromo[i] != palindromo[quantidade - 1])
                    {
                        Console.WriteLine("NAO");
                    }
                    else
                    {
                        isPalindromo(palindromo, ++i, --quantidade);
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("SIM");
                }
                if (i == 0)
                {
                    palindromo = Console.ReadLine();
                    isPalindromo(palindromo, 0, palindromo.Length);
                }
            }
        }
    }
}