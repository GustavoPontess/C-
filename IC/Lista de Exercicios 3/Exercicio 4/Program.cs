namespace Exercicio_4
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

            // Faça um programa que leia um número indeterminado de triângulos(valores dos 3 lados) e 
            // para cada triângulo, acione o procedimento.

            //Declarando variaveis
            int lado1 = 0, lado2 = 0, lado3 = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Informe 3 medidas para obter informações sobre o triângulo: ");
                Console.Write("1° medida: ");
                lado1 = int.Parse(Console.ReadLine()!);
                Console.Write("2° medida: ");
                lado2 = int.Parse(Console.ReadLine()!);
                Console.Write("3° medida: ");
                lado3 = int.Parse(Console.ReadLine()!);

                qualTriangulo(ref lado1, ref lado2, ref lado3);

                Console.WriteLine("Press <Enter> to continue or <Esc> to exit...");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
            Console.Clear();
        }

        static void qualTriangulo(ref int lado1, ref int lado2, ref int lado3)
        {
            if (lado1 + lado2 >= lado3 && lado3 + lado2 >= lado1 && lado3 + lado1 >= lado2)
            {
                Console.Write("\nAs medidas usadas formam um triângulo: ");
                if (lado1 == lado2 && lado2 == lado3){
                    Console.WriteLine("Equilátero.\n");
                }else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1){
                    Console.WriteLine("Isósceles.\n");
                }else{
                    Console.WriteLine("Escaleno.\n");
                }
            }else{
                Console.WriteLine("\nAs medidas usadas não formam um triângulo.\n");
            }
        }
    }
}