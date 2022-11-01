namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o valor de E:
            //E = 1 + 1 / 1! + 1 / 2! + 1 / 3! + .... + 1 / N!
            
            //Declarando variaveis
            double fatorial, resultado = 1, total = 1;
            //Solicitando entrada de dados
            Console.WriteLine("Qual fatorial deseja calcula?");
            //Armazenando entrada de dados
            fatorial = double.Parse(Console.ReadLine()!);

            for(int i = 1; i <= fatorial; i++){
                resultado *= i;
                total += 1.0 / resultado;
            }
            Console.WriteLine($"O valor do fatorial: {resultado}");
            Console.WriteLine($"O valor do E: {total:F2}");
        }
    }
}