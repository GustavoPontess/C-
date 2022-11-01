namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Escreva uma função que recebe por parâmetro um valor inteiro e positivo N e retorna o 
            // valor de S, calculado segundo a fórmula abaixo.
            // S = 2 / 4 + 5 / 5 + 10 / 6 + 17 / 7 + 26 / 8 + ... +(n^2 + 1)/ (n + 3)
            // Faça um programa que leia N e imprima o valor retornado pela função.

            //Declarando variavel
            int num1;
            //Solicitando entrada de dados
            Console.WriteLine("Digite um numero inteiro e positivo: ");
            num1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine(calculo(ref num1));

        }

        //Criando uma função que ira receber um parametro do tipo int e com retorno do tipo string  
        static string calculo(ref int num1)
        {
            double soma = 0;
            for (int i = 1; i <= num1; i++){
                soma += (Math.Pow(i,2)+1.0)/(i + 3.0);
            }
            return ($"\nO resultado de S é: {soma:F3}");
        }
    }
}