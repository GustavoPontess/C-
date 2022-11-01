namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Faça um algoritmo que leia 2 números inteiros e faça sua adição. Se o resultado for maior
            // ou igual a 10, some 5 a este número. Caso contrário some 7 a ele. Imprima o resultado
            // final.

            //decalrando variaveis
            double num1, num2, adicao;
            string resultado;
            //Solicitando entrada de dados
            Console.WriteLine($"Digite o primeiro numero:");
            //Armazenando o valor de entrada
            num1 = double.Parse(Console.ReadLine() ?? string.Empty);
            //Solicitando entrada de dados
            Console.WriteLine($"Digite o segundo numero:");
            //Armazenando o valor de entrada
            num2 = double.Parse(Console.ReadLine() ?? string.Empty);
            //Fazendo a adição
            adicao = num1 + num2;
            //Se a soma for maior igual a 10 somar 5 ao numero
            if(adicao >= 10){
                adicao += 5;
                resultado = " e maior que ou igual a 10 entao foi somado mais 5 ao resultado;";
            }else{ //caso a soma nao seja maior ou igual a 10 somar 7 ao numero
                adicao += 7;
                resultado = " e menor que 10 entao foi somado mais 7 ao resultado;";
            }
            //Imprimindo o resultado
            Console.WriteLine($"A soma de {num1} + {num2} {resultado}\nResultado: {adicao}");
            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}