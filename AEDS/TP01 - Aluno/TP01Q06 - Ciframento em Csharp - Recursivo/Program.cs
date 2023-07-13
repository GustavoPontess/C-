using System;

namespace TP01Q06___Ciframento_em_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string codigo = Console.ReadLine();
            string cripto = string.Empty;
            if (codigo != "FIM")
            {
                cesar(codigo, 0, ref cripto);
            }
        }

        static void cesar(string codigo, int cont, ref string cripto)
        {
            if (cont < codigo.Length)
            {
                string _char = ((char)(Convert.ToInt32(codigo[cont]) + 3)).ToString();
                cripto += _char;
                cesar(codigo, ++cont,ref cripto);
                cont--;
                if (cont == 0)
                {
                    Console.WriteLine(cripto);
                    cripto = string.Empty;
                    codigo = Console.ReadLine();
                    if (codigo != "FIM")
                    {
                        cesar(codigo, 0, ref cripto);
                    }
                }
            }
        }
    }
}