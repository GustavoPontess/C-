namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split('[', ']', ',');
            Console.WriteLine(Cont(entrada, entrada.Length - 2));
        }
        static int Cont(string[] entrada, int num)
        {
            if (num <= 1)
            {
                return int.Parse(entrada[num]) >= 0 ? 1 : 0;
            }
            else
            {
                if (int.Parse(entrada[num]) >= 0)
                {
                    return Cont(entrada, num - 1) + 1;
                }
                return Cont(entrada, num - 1);
            }
        }
    }
}