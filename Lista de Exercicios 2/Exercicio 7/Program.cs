namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Faça um programa que imprima os N primeiros elementos da série de Fibonacci. 
            // Por exemplo, se o usuário digitou o número 40, deverão ser 
            // apresentados os 40 números da sequência na tela.    

            //Declarando variaveis
            double numero, fn = 1, fn1 = 0, fn2 = 0;
            //Solicitando entrada de dados
            Console.WriteLine("Qual numero deseja calcula?");
            //Armazenando entrada de dados
            numero = double.Parse(Console.ReadLine()!);

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"{i}° numero: {fn}");
                fn2 = fn1;
                fn1 = fn;
                fn = fn1 + fn2;
            }
        }
    }
}