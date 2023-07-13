namespace Exercicio_5
{
    class Program
    {

        static void Main(string[] args)
        { 

            // Questão 5
            // Construa um algoritmo que, tendo como dados de entrada dois pontos
            // quaisquer no plano, P(x1,y1) e P(x2,y2), escreva a distância entre eles. A
            // fórmula que efetua tal cálculo é:
            
            //Declarando as variaveis
            double px, py, px1, py1, distancia;
            
            //Solicitar entrada de dados
            Console.WriteLine("Digite o valor X do primeiro ponto:");
            //Armazenar o valor de entrada
            px = double.Parse(Console.ReadLine() ?? string.Empty);
            //Solicitar entrada de dados
            Console.WriteLine("Digite o valor Y do primeiro ponto:");
            //Armazenar o valor de entrada
            py = double.Parse(Console.ReadLine() ?? string.Empty);
            //Solicitar entrada de dados
            Console.WriteLine("Digite o valor X do segundo ponto:");
            //Armazenar o valor de entrada
            px1 = double.Parse(Console.ReadLine() ?? string.Empty);
            //Solicitar entrada de dados
            Console.WriteLine("Digite o valor Y do segundo ponto:");
            //Armazenar o valor de entrada
            py1 = double.Parse(Console.ReadLine() ?? string.Empty );

            //Calculando a distancia entre os ponto no plano
            distancia = Math.Sqrt(Math.Pow((px-px1),2)+Math.Pow((py-py1),2));
            //Imprimindo o resultando
            Console.WriteLine($"A distancia entre o Ponto 1 e o Ponto 2 e: {distancia}");
            Console.ReadKey(true);
        }
    }
}
