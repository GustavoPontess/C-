using System;

namespace TP2Q05
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            string leitura = Console.ReadLine();
            int j = 0, n = 0;
            while (leitura != "FIM")
            {
                Jogador jogador = new Jogador();
                jogador.ler(leitura);
                pilha.InserirI(jogador);
                leitura = Console.ReadLine();
                n++;
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
                        pilha.InserirI(jogador);
                        break;
                    case 'R':
                        pilha.RemoverI();
                        break;
                }
            }

            pilha.Imprimir();

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

        public class Pilha
        {
            private Celula topo;

            public Pilha()
            {
                this.topo = null;
            }

            public bool Vazia()
            {
                return topo == null;
            }

            public void InserirI(Jogador jogador)
            {
                Celula novaCelula = new Celula(jogador);
                novaCelula.prox = topo;
                topo = novaCelula;
            }

            public Jogador RemoverI()
            {
                if (Vazia())
                {
                    throw new Exception("Erro!");
                }

                Jogador jogador = topo.elemento;
                topo = topo.prox;
                return jogador;
            }

            public void Imprimir()
            {
                ImprimirRecursivo(topo);
            }

            private void ImprimirRecursivo(Celula celula)
            {
                if (celula != null)
                {
                    ImprimirRecursivo(celula.prox);
                    celula.elemento.imprimir();
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
