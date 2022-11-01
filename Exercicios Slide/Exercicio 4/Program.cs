namespace Exercicio_4
{
    class Program
    {

        static void Main(string[] args)
        {

            // Questão 4
            // Sabendo que 100 kilowatt de energia custa um sétimo do salário
            // mínimo, faça um programa para ler o valor do salário mínimo e a
            // quantidade de kilowatt gasta em uma residência, calcular e mostrar: o
            // valor em reais de cada kilowatt; o valor em reais a ser pago; e o novo
            // valor a ser pago por essa residência com um desconto de 10%.
            
            //Declaração de variaveis
            double salario, kilowatt, valorporkw, valorapagar, valorcomdesconto;

            //Solitar entrada de dados
            Console.WriteLine("Digite o valor do salario minimo:");
            //Armazenar a entrada de dados
            salario = double.Parse(Console.ReadLine() ?? string.Empty);

            //Solitar entrada de dados
            Console.WriteLine("Digite a quatidade gasta de Kilowatt na residencia:");
            //Armazenar a entrada de dados
            kilowatt = double.Parse(Console.ReadLine() ?? string.Empty);

            //Limpando a tela
            Console.Clear();

            //Calcular o valor em reais do Kilowatt
            valorporkw = salario/700;
            //Calculando o valor a ser pago
            valorapagar = valorporkw*kilowatt;
            //Calculando o valor a ser pago com desconto
            valorcomdesconto = valorapagar * 0.9;

            //Imprimindo a saida de dados
            Console.WriteLine($"Valor por Kilowatt: {valorporkw:F2} \nValor total: {valorapagar:F2} \nValor com desconto: {valorcomdesconto:F2}");
            Console.ReadKey(true);
        }
    }
}