namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Soma(num));
        }
        static int Soma(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num + Soma(num - 1);
            }
        }
    }
}