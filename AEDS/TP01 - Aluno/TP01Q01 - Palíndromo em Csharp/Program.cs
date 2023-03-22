using System;

namespace TP01Q01___Palíndromo_em_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindromo = "";
            while (palindromo != "FIM")
            {
                palindromo = Console.ReadLine();
                if (palindromo != "FIM")
                {
                    Console.WriteLine(isPalindromo(palindromo));
                }
            }
        }

        static string isPalindromo(string palindromo)
        {
            int quantidade = palindromo.Length - 1, metade = palindromo.Length / 2;
            if (quantidade % 2 == 0)
            {
                metade = (palindromo.Length - 1) / 2;
            }

            for (int i = 0; i < metade + 1; i++)
            {
                if (palindromo[i] != palindromo[quantidade])
                {
                    return "NAO";
                }
                quantidade--;
            }
            return "SIM";
        }
    }
}