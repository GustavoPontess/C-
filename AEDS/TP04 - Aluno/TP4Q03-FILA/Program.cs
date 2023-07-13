using System;
using System.Collections.Generic;

namespace TP2Q06
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();

            string leitura = Console.ReadLine();
            int j = 0, u = 0;
            while (leitura != "FIM")
            {
                Jogador jogador = new Jogador();
                jogador.ler(leitura);
                fila.Inserir(jogador);
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
                        fila.Inserir(jogador);
                        break;
                    case 'R':
                        fila.Remover();
                        break;
                }
            }

            fila.Imprimir();

        }

        public class Celula
        {
            public Jogador elemento;
            public Celula prox;

            public Celula(Jogador jogador)
            {
                this.elemento = jogador;
                this.prox = null;
            }
        }

        public class Fila
        {
            private Celula primeiro;
            private Celula ultimo;

            public Fila()
            {
                this.primeiro = null;
                this.ultimo = null;
            }

            public bool Vazia()
            {
                return primeiro == null;
            }

            public void Inserir(Jogador jogador)
            {
                Celula novaCelula = new Celula(jogador);
                if (Vazia())
                {
                    primeiro = novaCelula;
                    ultimo = novaCelula;
                }
                else
                {
                    ultimo.prox = novaCelula;
                    ultimo = novaCelula;
                }
            }

            public Jogador Remover()
            {
                if (Vazia())
                {
                    throw new Exception("Erro!");
                }

                Jogador jogador = primeiro.elemento;
                primeiro = primeiro.prox;
                if (primeiro == null)
                {
                    ultimo = null;
                }
                return jogador;
            }

            public void Imprimir()
            {
                Celula atual = primeiro;
                while (atual != null)
                {
                    atual.elemento.imprimir();
                    atual = atual.prox;
                }
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
                int i = 0, cont = 1;
                string data = "", time = "", numero = "";

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
                numero = "";
                i = 0;

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
