using System;
using System.Collections.Generic;

namespace TP03Q03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jogador> jogadores = new List<Jogador>();
            string leitura = Console.ReadLine();
            int n = 0;
            while (leitura != "FIM")
            {
                Jogador jogador = new Jogador();
                jogador.ler(leitura);
                jogadores.Add(jogador);
                leitura = Console.ReadLine();
                n++;
            }

            MergeSort(jogadores, 0, jogadores.Count - 1);

            for (int i = 0; i < n; i++)
            {
                jogadores[i].imprimir();
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
        public static void MergeSort(List<Jogador> jogadores, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(jogadores, left, middle);
                MergeSort(jogadores, middle + 1, right);
                Merge(jogadores, left, middle, right);
            }
        }

        public static void Merge(List<Jogador> jogadores, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Criar arrays temporários
            Jogador[] leftArray = new Jogador[n1];
            Jogador[] rightArray = new Jogador[n2];

            // Copiar dados para os arrays temporários
            for (int i = 0; i < n1; i++)
            {
                leftArray[i] = jogadores[left + i];
            }
            for (int j = 0; j < n2; j++)
            {
                rightArray[j] = jogadores[middle + 1 + j];
            }

            // Realizar o merge dos arrays temporários de volta ao array original
            int k = left;
            int i1 = 0;
            int i2 = 0;
            while (i1 < n1 && i2 < n2)
            {
                if (leftArray[i1].nascimento <= rightArray[i2].nascimento)
                {
                    jogadores[k] = leftArray[i1];
                    i1++;
                }
                else
                {
                    jogadores[k] = rightArray[i2];
                    i2++;
                }
                k++;
            }

            // Copiar os elementos restantes do array esquerdo, se houver
            while (i1 < n1)
            {
                jogadores[k] = leftArray[i1];
                i1++;
                k++;
            }

            // Copiar os elementos restantes do array direito, se houver
            while (i2 < n2)
            {
                jogadores[k] = rightArray[i2];
                i2++;
                k++;
            }
        }
    }
}


