using System;

namespace TP01Q04___Is_em_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();

            while (linha != "FIM")
            {
                Console.WriteLine((SomenteVogais(linha) ? "SIM" : "NAO") + " " +
                                  (SomenteConsoantes(linha) ? "SIM" : "NAO") + " " +
                                  (NumeroInteiro(linha) ? "SIM" : "NAO") + " " +
                                  (NumeroReal(linha) ? "SIM" : "NAO"));

                linha = Console.ReadLine();
            }
        }
        static bool SomenteVogais(string linha)
        {
            string vogais = "aeiouAEIOU";
            foreach (char letra in linha)
            {
                bool isVogal = false;
                for (int i = 0; i < vogais.Length; i++)
                {
                    if (letra == vogais[i])
                    {
                        isVogal = true;
                        break;
                    }
                }
                if (!isVogal)
                {
                    return false;
                }
            }
            return true;
        }


        static bool SomenteConsoantes(string linha)
        {
            string consoantes = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            foreach (char letra in linha)
            {
                bool isConsoante = false;
                for (int i = 0; i < consoantes.Length; i++)
                {
                    if (letra == consoantes[i])
                    {
                        isConsoante = true;
                        break;
                    }
                }
                if (!isConsoante)
                {
                    return false;
                }
            }
            return true;
        }


        static bool NumeroInteiro(string linha)
        {
            int numero;
            return int.TryParse(linha, out numero);
        }

        static bool NumeroReal(string linha)
        {
            if (linha.StartsWith("."))
            {
                linha = "0" + linha;
            }
            int numPontos = 0;
            foreach (char letra in linha)
            {
                if (letra == '.')
                {
                    numPontos++;
                }
            }
            if (numPontos > 1)
            {
                return false;
            }
            double numero;
            return double.TryParse(linha, out numero);
        }
    }
}