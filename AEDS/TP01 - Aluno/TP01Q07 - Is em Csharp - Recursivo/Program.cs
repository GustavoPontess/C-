using System;

namespace TP01Q07___Is_em_Csharp___Recursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();

            if (linha != "FIM")
            {
                bool apenasVogais = true;
                bool apenasConsoantes = true;
                bool numeroInteiro = true;
                bool numeroReal = true;

                SomenteVogais(linha, ref apenasVogais);
                SomenteConsoantes(linha, ref apenasConsoantes);
                NumeroInteiro(linha, ref numeroInteiro);
                NumeroReal(linha, ref numeroReal, 0);

                Console.WriteLine((apenasVogais ? "SIM" : "NAO") + " " +
                                  (apenasConsoantes ? "SIM" : "NAO") + " " +
                                  (numeroInteiro ? "SIM" : "NAO") + " " +
                                  (numeroReal ? "SIM" : "NAO"));

                // Chamada recursiva do método Main
                Main(args);
            }
        }

        static void SomenteVogais(string linha, ref bool apenasVogais, int pos = 0)
        {
            string vogais = "aeiouAEIOU";

            if (pos < linha.Length)
            {
                if (!vogais.Contains(linha[pos].ToString()))
                {
                    apenasVogais = false;
                }

                SomenteVogais(linha, ref apenasVogais, pos + 1);
            }
        }

        static void SomenteConsoantes(string linha, ref bool apenasConsoantes, int pos = 0)
        {
            string consoantes = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

            if (pos < linha.Length)
            {
                if (!consoantes.Contains(linha[pos].ToString()))
                {
                    apenasConsoantes = false;
                }

                SomenteConsoantes(linha, ref apenasConsoantes, pos + 1);
            }
        }

        static void NumeroInteiro(string linha, ref bool numeroInteiro, int pos = 0)
        {
            if (pos < linha.Length)
            {
                if (!Char.IsDigit(linha[pos]))
                {
                    numeroInteiro = false;
                }

                NumeroInteiro(linha, ref numeroInteiro, pos + 1);
            }
        }

        static void NumeroReal(string linha, ref bool numeroReal, int pos = 0, int numPontos = 0)
        {
            if (pos < linha.Length)
            {
                if (Char.IsDigit(linha[pos]))
                {
                    NumeroReal(linha, ref numeroReal, pos + 1, numPontos);
                }
                else if (linha[pos] == '.' && numPontos == 0 && pos < linha.Length - 1)
                {
                    NumeroReal(linha, ref numeroReal, pos + 1, numPontos + 1);
                }
                else
                {
                    numeroReal = false;
                }
            }
            else if (numPontos <= 1 && pos > 0)
            {
                numeroReal = true;
            }
        }

    }
}