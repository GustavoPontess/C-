using System;
using System.Collections;

namespace TP2Q02
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
            public string? nome;
            ArrayList AL = new ArrayList();
            public void imprimir()
            {
                for (int i = 0; i < AL.Count; i++)
                {
                    Console.WriteLine(AL[i]);
                }
            }
            public string pesquisa(string leitura){
                for (int i = 0; i < AL.Count; i++)
                {
                    if((string)AL[i] == leitura){
                        return "SIM";
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
                AL.Add(nome);
                nome = "";
            }
        }
    }
}