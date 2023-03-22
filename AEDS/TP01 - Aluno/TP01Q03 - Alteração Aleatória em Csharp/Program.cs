using System;

namespace TP01Q03___Alteração_Aleatória_em_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool one = true;
            while (true)
            {
                string linha = Console.ReadLine();
                if (linha == "FIM") { break; }

                Console.WriteLine(SubstituirLetra(linha, one));
                one = false;
            }
        }

        static string SubstituirLetra(string texto, bool one)
        {
            Random random = new Random(4);
            char letraAntiga, letraNova;

            do
            {
                letraAntiga = (char)('a' + (Math.Abs(random.Next()) % 26));
                letraNova = (char)('a' + (Math.Abs(random.Next()) % 26));
            } while (letraAntiga == letraNova);

            if (one)
            {
                Console.WriteLine($"valores: {letraAntiga} e {letraNova}");
            }

            string textoSubstituido = String.Empty;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == letraAntiga)
                {
                    textoSubstituido += letraNova;
                }
                else
                {
                    textoSubstituido += texto[i];
                }
            }
            return textoSubstituido;
        }
    }
}