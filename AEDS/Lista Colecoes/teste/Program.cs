namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====>> Questão 1");

            Lista List = new Lista(10);
            Fila Que = new Fila(10);
            Pilha Sta = new Pilha(10);

            int entrada = 0;
            Console.WriteLine("Digite 10 numeros:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}° Numero: ");
                entrada = int.Parse(Console.ReadLine()!);

                List.Inserir(entrada);
                Que.Inserir(entrada);
                Sta.Inserir(entrada);
            }
            Console.Clear();
            Console.WriteLine("===== ArrayList =====");
            List.Imprimir();
            Console.WriteLine("\n=====   Queue   =====");
            Que.Imprimir();
            Console.WriteLine("\n=====   Stack   =====");
            Sta.Imprimir();

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }

        public class Lista
        {
            private ArrayList _elementos;
            private int _n;

            public Lista()
            {
                _elementos = new ArrayList();
                _n = 0;
            }
            public Lista(int num)
            {
                _elementos = new ArrayList(num);
                _n = 0;
            }
            public void Inserir(int num)
            {
                _elementos.Add(num);
            }
            public void Inserir(string num)
            {
                _elementos.Add(

                );
            }
            public void Imprimir()
            {
                foreach (var num in _elementos)
                {
                    Console.Write($"{num}, ");
                }
            }
        }
    }
}