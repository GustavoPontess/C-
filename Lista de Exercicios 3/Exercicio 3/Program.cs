namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Faça um procedimento que recebe 3 valores inteiros por parâmetro e os exiba 
            // em ordem crescente. Faça um programa que leia N conjuntos de 3 valores e acione o 
            // procedimento para cada conjunto. (N deve ser lido do teclado)

            //Declarando variaveis
            int num1 = 0, num2 = 0, num3 = 0, N = 0;

            Console.WriteLine("Quantos conjuntos de 3 numeros inteiros voce ira digitar?");
            N = int.Parse(Console.ReadLine()!);
            Console.Clear();

            for (var i = 0; i < N; i++)
            {
                Console.WriteLine($"Esta e o {i + 1}° conjunto de numeros:");
                Console.Write("1° numero: ");
                num1 = int.Parse(Console.ReadLine()!);
                Console.Write("2° numero: ");
                num2 = int.Parse(Console.ReadLine()!);
                Console.Write("3° numero: ");
                num3 = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Esta e sua ordem crescente: ");
                ordemCrescente(ref num1, ref num2, ref num3);

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        //Criando um procedimento que recebe parametros por referencia
        static void ordemCrescente(ref int num1, ref int num2, ref int num3)
        {
            int[] ordem = new int[3];
            ordem[0] = num1;
            ordem[1] = num2;
            ordem[2] = num3;
            Array.Sort(ordem);
            foreach(var num in ordem){
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }
    }
}