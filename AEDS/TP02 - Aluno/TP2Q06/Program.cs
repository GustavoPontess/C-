using System;
using System.Collections.Generic;

namespace TP2Q06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jogador> jogadores = new List<Jogador>(new Jogador[5]);
            List<Jogador> teste = new List<Jogador>(new Jogador[20]);
            string leitura = Console.ReadLine();
            int j = 0, u = 0, p = 0, cont = 0;
            while (leitura != "FIM")
            {
                Jogador jogador = new Jogador();
                jogador.ler(leitura);
                jogadores[u] = jogador;
                leitura = Console.ReadLine();
                u++;
            }
            j = int.Parse(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                leitura = Console.ReadLine();
                Jogador jogador = new Jogador();
                char tipo = leitura[0];
                switch (tipo)
                {
                    case 'I':
                        jogador.ler(leitura.Substring(1));
                        Inserir(jogador, ref jogadores, ref u, ref p, ref teste, ref cont);
                        break;
                    case 'R':
                        Remover(ref jogadores, ref u, ref p);
                        break;
                }
            }

            while (p != u)
            {
                jogadores[p].imprimir();
                p = (p + 1) % jogadores.Capacity;
            }
            for (int i = 0; i < cont; i++)
            {
                teste[i].imprimir();
            }
        }
        public static void Inserir(Jogador numero, ref List<Jogador> jogadores, ref int u, ref int p,ref List<Jogador> teste, ref int cont)
        {
            if (((u + 1) % jogadores.Capacity) == p)
            {
                teste[cont] = numero;
                cont++;
            }
            else
            {
                jogadores[u] = numero;
                u = (u + 1) % jogadores.Capacity;

            }
        }
        public static void Remover(ref List<Jogador> jogadores, ref int u, ref int p)
        {
            if (p == u)
            {
                throw new Exception("Erro!");
            }
            p = (p + 1) % jogadores.Capacity;
        }

        public class Jogador
        {
            public string nome = "";
            public string foto = "";
            public DateTime nascimento = DateTime.Parse("7/07/1994");
            public int id = 0;
            public int[] time;

            public void imprimir()
            {
                Console.Write($"{id} {nome} {nascimento.ToString("d/MM/yyyy")} {foto} ");
                Console.Write('(');
                for (int i = 0; i < this.time.Length - 1; i++)
                {
                    Console.Write($"{this.time[i]}, ");
                }
                Console.Write(this.time[this.time.Length - 1]);
                Console.WriteLine(')');
            }
            public void ler(string leitura)
            {
                int i = 0, cont = 1; string data = "", time = "", numero = "";
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
                i++;
                while (leitura[i] != ',')
                {
                    foto += leitura[i];
                    i++;
                }
                i++;
                while (leitura[i] != ',')
                {
                    data += leitura[i];
                    i++;
                }
                nascimento = DateTime.Parse(data);
                i++;
                while (leitura[i] != ',')
                {
                    i++;
                }
                i++;
                while (leitura[i] != ',')
                {
                    numero += leitura[i];
                    i++;
                }
                id = int.Parse(numero);
                i++;
                while (leitura[i] != '[')
                {
                    i++;
                }
                i++;
                while (leitura[i] != ']')
                {
                    time += leitura[i];
                    if (leitura[i] == ',')
                    {
                        cont++;
                    }
                    i++;
                }
                this.time = new int[cont];
                numero = ""; i = 0;
                for (int j = 0; j <= time.Length; j++)
                {
                    if (j != time.Length)
                    {
                        if (time[j] != ',' && time[j] != ' ')
                        {
                            numero += time[j];
                        }
                        else if (numero != "")
                        {
                            this.time[i] = int.Parse(numero);
                            numero = "";
                            i++;
                        }
                    }
                    else
                    {
                        this.time[i] = int.Parse(numero);
                    }
                }
            }
        }
    }
}