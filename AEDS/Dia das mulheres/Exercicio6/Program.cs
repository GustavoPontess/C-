namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split('[', ']', ',');
            Console.WriteLine(Soma(entrada, entrada.Length - 2));
        }
        static int Soma(string[] entrada, int num)
        {
            if (num <= 1)
            {
                return int.Parse(entrada[num]);
            }
            else
            {
                return int.Parse(entrada[num]) + Soma(entrada, num - 1);
            }
        }
    }
}