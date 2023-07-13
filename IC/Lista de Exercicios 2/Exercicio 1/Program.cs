namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Fazer um programa leia uma sequência de valores inteiros fornecida pelo usuário em uma
            // linha de entrada e conte o número de valores positivos, negativos e zeros.

            //declara variavei
            double positivos = 0, negativos = 0, zeros = 0;
            string[] valores;
            //solicitando entrada de dados
            Console.WriteLine("Digite uma sequência de valores inteiros separados por barra: ");
            //Armazenando entrada de dados, separando com split, jogando os dados em uma matriz unidirecional
            valores = Console.ReadLine()!.Split(' ');
            //Pegando cafa valor da matriz e comparando para saber se e ==0, menor que 0 para negativos ou positivos
            foreach (var val in valores)
            {
                if (double.Parse(val) == 0)
                {
                    zeros++;
                }
                else if (double.Parse(val) < 0)
                {
                    negativos++;
                }
                else
                {
                    positivos++;
                }
            }
            //Imprimindo valores para o usuario
            Console.WriteLine($"Quantidade de zeros digitados: {zeros}\nQuantidade de numeros negativos: {negativos}\nQuantidade de numeros positivos: {positivos}");

            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}