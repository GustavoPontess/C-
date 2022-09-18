namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Faça um algoritmo que segundo uma nota informada pelo usuário, verifique em qual faixa
            // a mesma se encaixa e imprima para o usuário a mensagem correspondente conforme a
            // tabela abaixo:
            // | Faixa das notas        | Mensagem       |
            // |------------------------|----------------|
            // | Nota >= 8 e Nota <= 10 | Ótimo          |
            // | Nota >= 7 e Nota < 8   | Bom            |
            // | Nota >= 5 e Nota < 7   | Regular        |
            // | Nota < 5               | Insatisfatório |

            //Declarando variaveis
            double nota;
            char r;
            do
            {
                //Solicitando entrada de dados
                Console.WriteLine("Digite o valor da nota:");
                //Armazenando entradad de dado
                nota = double.Parse(Console.ReadLine() ?? string.Empty);

                //verificando onde a nota se encaixa e imprimindo resultado para usuario
                if (nota >= 8 && nota > -10)
                {
                    Console.WriteLine("Ótimo");
                }
                else if (nota >= 7 && nota < 8)
                {
                    Console.WriteLine("Bom");
                }
                else if (nota >= 5 && nota < 7)
                {
                    Console.WriteLine("Regular");
                }
                else
                {
                    Console.WriteLine("Insatisfatório");
                }

                Console.WriteLine("Deseja continuar? S(sim) N(não)");
                r = Convert.ToChar(Console.ReadLine()!.ToUpper());
            } while (r != 'N');

            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
