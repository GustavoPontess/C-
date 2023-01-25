namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4.Escreva um procedimento que recebe 3 valores reais X, Y e Z e que verifique se esses 
            // valores podem ser os comprimentos dos lados de um triângulo e, neste caso, exibe qual é o 
            // tipo de triângulo formado.Para que X, Y e Z formem um triângulo é necessário que a seguinte 
            // propriedade seja satisfeita: o comprimento de cada lado de um triângulo é menor do que a 
            // soma do comprimento dos outros dois lados. O procedimento deve identificar o tipo de 
            // triângulo formado observando as seguintes definições:

            // - Triângulo Equilátero: os comprimentos dos 3 lados são iguais;
            // - Triângulo Isósceles: os comprimentos de pelo menos 2 lados são iguais.
            // - Triângulo Escaleno: os comprimentos dos 3 lados são diferentes.

            // Em seguida, escreva um procedimento que mostrar o valor das áreas dos dois triângulos.
            // A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
            // seguinte (fórmula de Heron):

            // area = √p( p - a)( p - b)( p - c)   Onde     p = a + b + c / 2

            // Faça um programa que leia um número indeterminado de triângulos(valores dos 3 lados) e 
            // para cada triângulo, acione o procedimento.


            //Declarando variaveis
            Triangulo x;
            do
            {
                x = new Triangulo();
                Console.Clear();
                Console.WriteLine("Informe 3 medidas para obter informações sobre o triângulo: ");
                Console.Write("1° medida: ");
                x.A = double.Parse(Console.ReadLine()!);
                Console.Write("\n2° medida: ");
                x.B = double.Parse(Console.ReadLine()!);
                Console.Write("\n3° medida: ");
                x.C = double.Parse(Console.ReadLine()!);
                Console.Clear();
                Console.Write(x.QualTriangulo());

                Console.WriteLine("Press <Enter> to continue or <Esc> to exit...");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
            Console.Clear();
        }
    }
}