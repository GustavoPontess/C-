namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = int.Parse(Console.ReadLine()!);
            Console.WriteLine(Fibonacci(numero));
        }
        static int Fibonacci(int numero)
        {
            if (numero <= 1)
            {
                return numero;
            }
            else
            {
                return Fibonacci(numero - 1) + Fibonacci(numero - 2);
            }
        }
    }
}
