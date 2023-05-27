using System;
using System.Collections;

namespace TP2Q03
{
    class Program
    {
        static void Main(string[] args)
        {
            string leitura = Console.ReadLine();
            Jogador Jogadores = new Jogador();
            while (leitura != "FIM")
            {
                Jogadores.ler(leitura);
                leitura = Console.ReadLine();
            }
            leitura = Console.ReadLine();
            while (leitura != "FIM")
            {
                Console.WriteLine(Jogadores.pesquisa(leitura));
                leitura = Console.ReadLine();
            }
        }
        public class Jogador
        {
            public string nome;
            string[] nomes = new string[20];
            int n = 0;
            public void imprimir()
            {
                for (int i = 0; i < nomes.Length; i++)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
            public string pesquisa(string leitura)
            {
                int dir = n - 1, esq = 0, meio;
                while (esq <= dir)
                {
                    meio = (esq + dir) / 2;
                    if (leitura == nomes[meio])
                    {
                        return "SIM";
                    }
                    else if (leitura[0] >= (nomes[meio])[0])
                    {
                        esq = meio + 1;
                    }
                    else
                    {
                        dir = meio - 1;
                    }
                }
                return "NAO";
            }
            public void ler(string leitura)
            {
                int i = 0;
                while (leitura[i] != ',')
                {
                    i++;
                }
                i++;
                while (leitura[i] != ',')
                {
                    nome += leitura[i];
                    i++;
                }
                nomes[n] = nome;
                nome = "";
                n++;
            }
        }
    }
}