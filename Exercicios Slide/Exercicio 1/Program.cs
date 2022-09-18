namespace Exercicio_1
{
    class Program
    {

        static void Main(string[] args)
        {

            // Questão 1
            // Faça um programa para ler do teclado um número inteiro com três
            // dígitos(no formato CDU - centena, dezena e unidade) e mostrar o
            // número invertido(no formato UDC).
            // c = num / 100;
            // d = (num % 100) / 10;
            // u = num % 10;
            // numInv = u * 100 + d * 10 + c;

            //Declaração de variavel
            int centena, dezena, unidade, numeroInvertido, num;

            //Solicitar a entrada de dados
            Console.WriteLine("Degite um numero inteiro:");
            //Leitura da entrada de dados convertendo a entrada para um inteiro
            num = int.Parse(Console.ReadLine() ?? string.Empty);

            //Seperando a centena
            centena = num / 100;
            //Separando a dezena
            dezena = (num % 100) / 10;
            //Separando a unidade
            unidade = num % 10;
            //Invertendo o numero
            numeroInvertido = unidade * 100 + dezena * 10 + centena;

            //imprimir a saida de dados
            Console.WriteLine($"O numero invertudo e: {numeroInvertido}");
            Console.ReadKey(true);
        }
    }
}