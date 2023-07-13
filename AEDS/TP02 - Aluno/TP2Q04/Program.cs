using System;
using System.Collections.Generic;

namespace TP2Q04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jogador> jogadores = new List<Jogador>(new Jogador[20]);
            string leitura = Console.ReadLine();
            int j = 0, n = 0;
            while (leitura != "FIM")
            {
                Jogador jogador = new Jogador();
                jogador.ler(leitura);
                jogadores[n] = jogador;
                leitura = Console.ReadLine();
                n++;
            }
            j = int.Parse(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                leitura = Console.ReadLine();
                Jogador jogador = new Jogador();
                string tipo = leitura.Substring(0, 2); ;
                int pos = 0;
                if (leitura[1] == '*')
                {
                    pos = int.Parse(leitura[3].ToString());
                    if (leitura[0] == 'I')
                    {
                        jogador.ler(leitura.Substring(5));
                        Inserir(jogador, pos, ref jogadores, ref n);
                    }
                    else
                    {
                        Remover(pos, ref jogadores, ref n);
                    }
                }
                else
                {
                    switch (tipo)
                    {
                        case "II":
                            jogador.ler(leitura.Substring(5));
                            InserirI(jogador, ref jogadores, ref n);
                            break;
                        case "IF":
                            jogador.ler(leitura.Substring(5));
                            InserirF(jogador, ref jogadores, ref n);
                            break;
                        case "RI":
                            RemoverI(ref jogadores, ref n);
                            break;
                        case "RF":
                            RemoverF(ref jogadores, ref n);
                            break;
                        default:
                            break;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                jogadores[i].imprimir();
            }
        }
        public static void InserirI(Jogador numero, ref List<Jogador> jogadores, ref int n)
        {
            if (n >= 20)
            {
                throw new Exception("Erro!");
            }
            //levar elementos para o fim do array
            for (int i = n; i > 0; i--)
            {
                jogadores[i] = jogadores[i - 1];
            }
            jogadores[0] = numero;
            n++;
        }
        public static void InserirF(Jogador numero, ref List<Jogador> jogadores, ref int n)
        {
            if (n >= 20)
            {
                throw new Exception("Erro!");
            }
            jogadores[n] = numero;
            n++;
        }
        public static void Inserir(Jogador numero, int pos, ref List<Jogador> jogadores, ref int n)
        {
            if (n >= 20 || pos < 0 || pos > n)
            {
                throw new Exception("Erro!");
            }
            //levar elementos para o fim da lista
            jogadores.Insert(pos, numero);
            n++;
        }
        public static void RemoverI(ref List<Jogador> jogadores, ref int n)
        {
            if (n == 0)
            {
                throw new Exception("Erro!");
            }
            Jogador resp = jogadores[0];
            n--;
            for (int i = 0; i < n; i++)
            {
                jogadores[i] = jogadores[i + 1];
            }

        }
        public static void RemoverF(ref List<Jogador> jogadores, ref int n)
        {
            if (n == 0)
            {
                throw new Exception("Erro!");
            }
            --n;
        }
        public static void Remover(int pos, ref List<Jogador> jogadores, ref int n)
        {
            if (n == 0 || pos < 0 || pos >= n)
            {
                throw new Exception("Erro!");
            }
            Jogador resp = jogadores[pos];
            n--;
            for (int i = pos; i < n; i++)
            {
                jogadores[i] = jogadores[i + 1];
            }
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