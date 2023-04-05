namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Em matemática, o algoritmo de Euclides é um método simples e eficiente de encontrar o 
            // Máximo Divisor Comum (MDC) entre dois números inteiros diferentes de zero. Crie uma função 
            // que receba dois números e calcule o MDC. 

            int num1, num2, apoio = 0;

            Console.Clear();
            Console.WriteLine("Informe dois números inteiros diferentes de zero: ");
            Console.Write("1° número: ");
            num1 = int.Parse(Console.ReadLine()!);
            Console.Write("2° número: ");
            num2 = int.Parse(Console.ReadLine()!);
            if (num2 > num1){ //garantindo que a variavel num1 tenha sempre o maior valor
                apoio = num1;num1 = num2;num2 = apoio;
            }
            Console.WriteLine($"\nO MDC entre {num1} e {num2}: {euClides(ref num1, ref num2, ref apoio)}");
        }
        //Criando uma função que tera como retorno um inteiro e recebe por parametro variaveis pro referencia
        static int euClides(ref int num1, ref int num2, ref int apoio)
        {
            if (num1 != 0 && num2 != 0){
                while((num1%num2) != 0){
                    apoio = num1%num2;
                    num1 = num2;
                    num2 = apoio;
                }
                return(num2);
            }else{
                Console.WriteLine("Os números tem que ser diferentes de zero!!!!");
                return (0);
            }
        }
    }
}