namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string leitura = Console.ReadLine();
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
            public string nome;
            public string foto;
            public DateOnly nascimento;
            public int id;
            public int[] time;

            public void imprimir()
            {
                Console.WriteLine($"{id} {nome} {nascimento} {foto} ");
                // Console.WriteLine('(');
                // foreach (var item in time)
                // {
                //     Console.Write($" {item}");
                // }
                // Console.WriteLine(')');
            }
            public void ler(string leitura)
            {
                int i = 0; string data = ""; string time = "";
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
                i++;
                while (leitura[i] != ',')
                {
                    i++;
                }
                i++;
                while (leitura[i] != ',')
                {
                    id += leitura[i];
                    i++;
                }
                // i++;
                // while (leitura[i] != '[')
                // {
                //     i++;
                // }
                // i++;
                // while (leitura[i] != ']')
                // {
                //     time += leitura[i];
                //     i++;
                // }
            }

        }
    }
}