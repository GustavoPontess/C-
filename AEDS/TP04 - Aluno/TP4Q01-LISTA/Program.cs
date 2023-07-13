using System;

namespace TP2Q04
{
    class Program
    {
        static void Main(string[] args)
        {
            Celula lista = new Celula();
            int n = 0;
            string leitura = Console.ReadLine();

            while (leitura != "FIM")
            {
                Jogador jogador = new Jogador();
                jogador.ler(leitura);
                InserirFim(jogador, ref lista, ref n);
                leitura = Console.ReadLine();
            }

            int j = int.Parse(Console.ReadLine());

            for (int i = 0; i < j; i++)
            {
                leitura = Console.ReadLine();
                string tipo = leitura.Substring(0, 2);
                int pos = 0;

                if (leitura[1] == '*')
                {
                    pos = int.Parse(leitura[3].ToString());

                    if (leitura[0] == 'I')
                    {
                        Jogador jogador = new Jogador();
                        jogador.ler(leitura.Substring(5));
                        Inserir(jogador, pos, ref lista, ref n);
                    }
                    else
                    {
                        Remover(pos, ref lista, ref n);
                    }
                }
                else
                {
                    switch (tipo)
                    {
                        case "II":
                            Jogador jogadorI = new Jogador();
                            jogadorI.ler(leitura.Substring(5));
                            InserirInicio(jogadorI, ref lista, ref n);
                            break;
                        case "IF":
                            Jogador jogadorF = new Jogador();
                            jogadorF.ler(leitura.Substring(5));
                            InserirFim(jogadorF, ref lista, ref n);
                            break;
                        case "RI":
                            RemoverInicio(ref lista, ref n);
                            break;
                        case "RF":
                            RemoverFim(ref lista, ref n);
                            break;
                        default:
                            break;
                    }
                }
            }

            Celula atual = lista.prox;
            while (atual != null)
            {
                atual.elemento.imprimir();
                atual = atual.prox;
            }
        }

        public static void InserirInicio(Jogador jogador, ref Celula lista, ref int n)
        {
            Celula novaCelula = new Celula(jogador);
            novaCelula.prox = lista.prox;
            lista.prox = novaCelula;
            n++;
        }

        public static void InserirFim(Jogador jogador, ref Celula lista, ref int n)
        {
            Celula novaCelula = new Celula(jogador);
            Celula atual = lista;
            while (atual.prox != null)
            {
                atual = atual.prox;
            }
            atual.prox = novaCelula;
            n++;
        }

        public static void Inserir(Jogador jogador, int pos, ref Celula lista, ref int n)
        {
            if (pos < 0 || pos > n)
            {
                throw new Exception("Erro!");
            }

            if (pos == 0)
            {
                InserirInicio(jogador, ref lista, ref n);
            }
            else if (pos == n)
            {
                InserirFim(jogador, ref lista, ref n);
            }
            else
            {
                Celula novaCelula = new Celula(jogador);
                Celula atual = lista;
                for (int i = 0; i < pos; i++)
                {
                    atual = atual.prox;
                }
                novaCelula.prox = atual.prox;
                atual.prox = novaCelula;
                n++;
            }
        }

        public static void RemoverInicio(ref Celula lista, ref int n)
        {
            if (n == 0)
            {
                throw new Exception("Erro!");
            }

            lista.prox = lista.prox.prox;
            n--;
        }

        public static void RemoverFim(ref Celula lista, ref int n)
        {
            if (n == 0)
            {
                throw new Exception("Erro!");
            }

            Celula atual = lista;
            while (atual.prox.prox != null)
            {
                atual = atual.prox;
            }
            atual.prox = null;
            n--;
        }

        public static void Remover(int pos, ref Celula lista, ref int n)
        {
            if (n == 0 || pos < 0 || pos >= n)
            {
                throw new Exception("Erro!");
            }

            if (pos == 0)
            {
                RemoverInicio(ref lista, ref n);
            }
            else if (pos == n - 1)
            {
                RemoverFim(ref lista, ref n);
            }
            else
            {
                Celula atual = lista;
                for (int i = 0; i < pos; i++)
                {
                    atual = atual.prox;
                }
                atual.prox = atual.prox.prox;
                n--;
            }
        }

        public class Celula
        {
            public Jogador elemento;
            public Celula prox;

            public Celula()
            {
                this.elemento = null;
                this.prox = null;
            }

            public Celula(Jogador jogador)
            {
                this.elemento = jogador;
                this.prox = null;
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
