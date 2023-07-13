namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Construa um programa que lê uma opção conforme abaixo (usar estrutura SWITCH) e o
            // salário atual do funcionário, calcula e exibe o novo salário:
            // A = aumento de 8% no salário;
            // B = aumento de 11% no salário;
            // C = aumento fixo no salário
            // (de R$ 350,00 se o salário atual for até R$ 1000 e de R$ 200,00 se o salário atual for
            // maior que R$ 1000).

            //Declarando variaveis
            double salario;
            char opcao;

            //Solicitando entrada de dados
            Console.WriteLine("Digite o valor do seu salario atual:");
            //Armazenando entrada de dados
            salario = double.Parse(Console.ReadLine() ?? string.Empty);
            //Solicitando entrada de dados
            Console.WriteLine("Escolha uma das opções: \nA = aumento de 8% no salário\nB = aumento de 11% no salário\nC = aumento fixo no salário");
            //Armazenando entrada de dados
            opcao = Convert.ToChar(Console.ReadLine()!.ToUpper());

            //Calculando e exibindo o novo salario
            switch (opcao)
            {
                case 'A':
                    salario += 0.08 * salario;
                    break;
                case 'B':
                    salario += 0.11 * salario;
                    break;
                case 'C':
                    if (salario <= 1000){
                        salario += 350;
                    }
                    else{
                        salario += 200;
                    }
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }

            //Imprimindo o resultado
            Console.WriteLine($"O novo salario e: {salario}");


            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}