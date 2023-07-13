namespace Exercicio_2
{
    class Program
    {

        static void Main(string[] args)
        {
            // Questão 2
            // Faça um programa para ler os valores dos catetos de um triângulo
            // retângulo e mostrar a hipotenusa
            // a = Math.Sqrt(Math.Pow(b, 2) + Math.pow(c, 2));

            //declarar as variaveis
            double cateto1, cateto2, hipotenusa;

            //Solicitação de entrada de dados
            Console.WriteLine("Digite o valor do primeiro cateto");
            //Armazenar a entrada de dados na variavel e converter de string para inteiro
            cateto1 = double.Parse(Console.ReadLine() ?? string.Empty);

            //Limpando a tela
            Console.Clear();

            //Solicitação de entrada de dados
            Console.WriteLine("Digite o valor do segundo cateto");
            //Armazenar a entrada de dados na variavel e converter de string para inteiro
            cateto2 = double.Parse(Console.ReadLine() ?? string.Empty);

            //Limpando a tela
            Console.Clear();

            //Calculando o valor da hipotenusa
            hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            //Imprimindo o valor de saida
            Console.WriteLine($"O valor da hipotenusa e: {hipotenusa:F2}");
            Console.ReadKey(true);
        }
    }
}