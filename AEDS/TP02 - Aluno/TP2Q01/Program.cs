using System;

namespace TP2Q01
{
    class Program
    {
        static void Main(string[] args)
        {
            string? leitura = Console.ReadLine();
            while (leitura != "FIM")
            {
                Jogador Jogadores = new Jogador();
                Jogadores.ler(leitura);
                Jogadores.imprimir();
                leitura = Console.ReadLine();
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
                for (int i = 0; i < this.time.Length-1; i++)
                {
                    Console.Write($"{this.time[i]}, ");
                }
                Console.Write(this.time[this.time.Length-1]);
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