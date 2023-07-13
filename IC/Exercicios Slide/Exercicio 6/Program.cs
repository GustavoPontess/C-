namespace Exercicio_6
{
    class Program
    {

        static void Main(string[] args)
        {

            // Questão 6
            // Uma pessoa resolveu fazer uma aplicação em uma poupança
            // programada em que o valor acumulado é igual a p * ((1+i)n –1) / i, onde
            // p é a aplicação mensal, i é a taxa e n é o número de meses. Faça um
            // programa para ler o valor constante da aplicação mensal, a taxa e o
            // número de meses, calcular e mostrar o rendimento.

            //Declarando as variaveis
            double p, i, n, rendimento;

            //Solicitar entrada de dados
            Console.WriteLine("Digite o valor que sera aplicado mensalmente:");
            //Armazenando o valor de entrada
            p = double.Parse(Console.ReadLine() ?? string.Empty);

            //Solicitar entrada de dados
            Console.WriteLine("Digite o valor da taxa:");
            //Armazenando o valor de entrada
            i = double.Parse(Console.ReadLine() ?? string.Empty);

            //Solicitar entrada de dados
            Console.WriteLine("Digite o numero de meses:");
            //Armazenando o valor de entrada
            n = double.Parse(Console.ReadLine() ?? string.Empty);
            
            // Limpando o console
            Console.Clear();
            
            rendimento=p*((Math.Pow((1+i),n)-1)/i);

            //Imprimindo o resultado do rendimento
            Console.WriteLine($"O valor {p} aplicado a uma taxa de {i} por um periodo de {n} meses deu um rendimento de: {rendimento:F2}");
            Console.ReadKey(true);
        }
    }
}