namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. Fazer um programa para:
            // - ler um símbolo do teclado;
            // - identificar com a estrutura SWITCH e mostrar as seguintes mensagens, segundo o
            // caso:
            // - "SINAL DE MENOR"
            // - "SINAL DE MAIOR"
            // - "SINAL DE IGUAL"
            // - "OUTRO SINAL"

            //Declarando variavel
            //Descreve a chave do console que foi pressionada, incluindo o caractere 
            //representado pela chave do console e o estado das teclas modificadoras SHIFT, ALT e CTRL.
            ConsoleKeyInfo simbulo;
            
            //Solicitar entrada de dados
            Console.WriteLine("Aperte qualquer simbulo do teclado:");
            //Armazenando entrada de dados
            //ReadKey: Obtém o próximo caractere ou tecla de função pressionada pelo usuário.
            simbulo = Console.ReadKey();

            //Indentificando qual simbulo foi armazenado e imprimindo resultado
            switch (simbulo.KeyChar)
            {
                case '<':
                    Console.WriteLine(" -- SINAL DE MENOR");
                    break;
                case '>':
                    Console.WriteLine(" -- SINAL DE MAIOR");
                    break;
                case '=':
                    Console.WriteLine(" -- SINAL DE IGUAL");
                    break;
                default:
                    Console.WriteLine(" -- OUTRO SINAL");
                    break;
            }

            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}