using System;
using System.Collections;

namespace TP2Q07
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList List = new ArrayList(20);
            string leitura = Console.ReadLine();
            int j = 0, n = 0;
            while (leitura != "FIM")
            {
                Jogador jogador = new Jogador();
                jogador.ler(leitura);
                List.Add(jogador);
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
                        List.Insert(pos, jogador);
                    }
                    else
                    {
                        List.RemoveAt(pos);
                    }
                }
                else
                {
                    switch (tipo)
                    {
                        case "II":
                            jogador.ler(leitura.Substring(5));
                            List.Insert(0, jogador);
                            break;
                        case "IF":
                            jogador.ler(leitura.Substring(5));
                            List.Add(jogador);
                            break;
                        case "RI":
                            List.RemoveAt(0);
                            break;
                        case "RF":
                            List.RemoveAt(List.Count - 1);
                            break;
                        default:
                            break;
                    }
                }
            }

            foreach (Jogador jogador in List)
            {
                jogador.imprimir();
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