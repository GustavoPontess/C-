namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Escreva um algoritmo que lê um valor n inteiro e positivo e que calcula a seguinte soma:
            // S = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n
            // O algoritmo deve escrever cada termo gerado e o valor final de S.        


            //Declarando variaveis
            double N, S = 1;
            //Solicitando entrada de dados
            Console.WriteLine("Qual numero deseja calcula?");
            //Armazenando entrada de dados
            N = double.Parse(Console.ReadLine()!);

            for(int i = 2; i <= N; i++){
                S += 1.0 / i;
            }
            Console.WriteLine($"O valor do E: {S:F2}");    
        }
    }
}