namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Faça um programa que imprima todos os elementos da série de 
            //Fibonacci menores que L.


            //Declarando variaveis
            int numero, fn = 1, fn1 = 0, fn2 = 0;
            //Solicitando entrada de dados
            Console.WriteLine("Qual numero deseja calcula?");
            //Armazenando entrada de dados
            numero = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= numero; i++)
            {
                fn2 = fn1;
                fn1 = fn;
                fn = fn1 + fn2;
            }

            fn2 = fn;
            fn = fn1;

            for (int i = numero; i >= 1; i--)
            {
                Console.WriteLine($"{i}° numero: {fn}");
                fn = fn2 - fn1;
                fn2 =fn1;
                fn1 = fn;
            }
        }
    }
}