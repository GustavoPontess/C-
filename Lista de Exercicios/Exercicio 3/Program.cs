namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Faça um programa para ler os coeficientes de uma equação do primeiro grau (ax + b = 0),
            // calcular e escrever a raiz da equação.

            //Declarando as variaveis
            double a, b, c, resultado;

            //Solicitando entrada de dados
            Console.WriteLine("Digite o valor do primeiro cociente:");
            //Armazenando a entrada de dados
            a = double.Parse(Console.ReadLine()?? string.Empty);
            //Solicitando entrada de dados
            Console.WriteLine("Digite o valor do segundo cociente:");
            //Armazenando a entrada de dados
            b = double.Parse(Console.ReadLine()?? string.Empty);
            //Solicitando entrada de dados
            Console.WriteLine("Digite o valor do terceiro cociente:");
            //Armazenando a entrada de dados
            c = double.Parse(Console.ReadLine()?? string.Empty);
            //Limpando a tela
            Console.Clear();
            //Imprimindo a equação
            Console.WriteLine($"A equação digitada foi {a}x + {b} = {c}");
            //Calculando a raiz da equação
            resultado = (c - b)/a;
            //Imprimindo o resultado
            Console.WriteLine($"A raiz da equação e: {resultado}");
            


            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}