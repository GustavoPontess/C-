namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Dado dois números imprimir somente o maior deles

            //Declarando variaveis
            double num1, num2;
            //Solicitaçao de entrada de dados
            Console.WriteLine("Digite o Primeiro numero:");
            //Gravando entrada de dados
            num1 = double.Parse(Console.ReadLine() ?? string.Empty);
            //Solicitaçao de entrada de dados
            Console.WriteLine("Digite o Segundo numero:");
            //Gravando entrada de dados
            num2 = double.Parse(Console.ReadLine() ?? string.Empty);
            //se num1 maior que num2 imprimir num1
            if(num1 > num2){
                Console.WriteLine($"O maior numero e: {num1}");
            }else{ //se num1 nao for maior que num2 imprimir num2
                Console.WriteLine($"O maior numero e: {num2}");
            }
            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true); 
        }
    }
}
