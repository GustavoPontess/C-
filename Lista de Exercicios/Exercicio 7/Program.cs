namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Faça um programa para calcular e imprimir o valor de Y, dado um valor de X:           
            //             {1   ,se x <= 1
            // y = f(x) =  {2   ,se 1 < x <= 2
            //             {x^2 ,se 2 < x <= 3
            //             {x^3 ,se x > 3

            //Declarando variaveis
            double x,y;

            //Solicitando entrada de dados
            Console.WriteLine("Digite o valor de X:");
            //Armazenando entrada de dados
            x = double.Parse(Console.ReadLine() ?? string.Empty);

            //Calculando o valor de X
            if(x<=1){
                y=1;
            }else if(x>1 && x<=2){
                y=2;
            }else if(x>2 && x<=3){
                y=Math.Pow(x,2);
            }else{
                y=Math.Pow(x,3);
            }

            //Imprimindo o valor de Y
            Console.WriteLine($"O valor de Y e: {y}");
            
            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}