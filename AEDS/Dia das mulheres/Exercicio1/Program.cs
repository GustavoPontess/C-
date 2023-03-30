namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double fatorial = double.Parse(Console.ReadLine());
            Console.WriteLine(Fatorial(fatorial));
        }
        static double Fatorial(double fatorial)
        {
            double resp;
            if (fatorial == 1)
            {
                resp = 1;
            }
            else
            {
                resp = fatorial * Fatorial(fatorial - 1);
            }
            return resp;
        }
    }
}
