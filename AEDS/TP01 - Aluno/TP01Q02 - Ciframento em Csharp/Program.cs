using System;

namespace TP01Q02___Ciframento_em_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string codigo = " ";
            while (codigo != "FIM")
            {
                codigo = Console.ReadLine();
                if (codigo != "FIM")
                {
                    Console.WriteLine(cesar(codigo));
                }
            }
        }

        static string cesar(string codigo)
        {
            string cripto = string.Empty;

            for (int i = 0; i < codigo.Length; i++)
            {
                string _char = ((char)(Convert.ToInt32(codigo[i]) + 3)).ToString();
                cripto += _char;
            }
            return cripto;
        }
    }
}