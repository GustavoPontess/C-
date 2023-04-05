namespace Exercicio_3
{
    class Program
    {

        static void Main(string[] args)
        {

            // Questão 3
            // Faça um programa para ler a base e a altura de um retângulo e mostrar
            // seu perímetro, área e diagonal.
            // perimetro = 2 * (base + altura);
            // area = (base * altura);
            // diagonal = Math.Sqrt(Math.Pow(base, 2) + Math.Pow(altura, 2));

            //Dleclarando as variaveis
            double basee, altura, perimetro, area, diagonal;

            //Solicitar entrada de dados
            Console.WriteLine("Digite o valor da base:");
            //Armazenando a variavel e convertendo para double
            basee = double.Parse(Console.ReadLine() ?? string.Empty);

            //Solicitar entrada de dados
            Console.WriteLine("Digite o valor da altura:");
            //Armazenando a variavel e convertendo para double
            altura = double.Parse(Console.ReadLine() ?? string.Empty);

            //Calculando o perimetro 
            perimetro = 2 * (basee + altura);
            //Calculando a area
            area = (basee * altura);
            //Calculando a diagonal
            diagonal = Math.Sqrt(Math.Pow(basee, 2) + Math.Pow(altura, 2));

            //Imprimindo as respostas
            Console.WriteLine($"Perimetro: {perimetro:F2} \n Area: {area:F2} \n Diagonal: {diagonal:F2}");
            Console.ReadKey(true);
        }
    }
}
