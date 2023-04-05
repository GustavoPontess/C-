namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Faça um programa que receba dez números e verifique se eles são divisíveis 
            //por 3 e 9 (ao mesmo tempo), por 2 e por 5. Caso algum número não seja divisível por 
            //nenhum desses números mostre a mensagem “Número não é divisível pelos valores”. 
            //Apresente também ao final a quantidade de números divisíveis por 3 e 9, por 2 e por 5.

            //Declarando variaveis
            int num, divPor3e9 = 0, divPor2e5 = 0;
            string div3e9 ="Os numeros divisiveis por 3 e 9 são: ",div2e5="Os numeros divisiveis por 2 e 5 são: ";
            //Iniciando uma estrutura de repetição que ira executar 10x
            for (int i = 0; i < 10; i++)
            {
                //Solicitando entrada de dados
                Console.WriteLine("Digite um numero:");
                //Armazenando entrada de dados
                num = int.Parse(Console.ReadLine()!);
                //verifiando se e divisivel por 3 e por 9 se o resto da divisao for igual a zero
                if(num%3 == 0 && num%9 == 0){
                    divPor3e9++; // soma mais um para saber quantos numeros sao divisiveis 
                    div3e9 += $"{num}, "; // faz a comcatenação da string de resposta
                }else 
                //verificando se e divisivel por 2 e por 5 se o resto da divisao for igual a zero
                if(num%2==0 && num%5==0){ 
                    divPor2e5++;    // soma mais um para saber quantos numeros sao divisiveis 
                    div2e5 += $"{num}, "; // faz a comcatenação da string de resposta
                }else{
                    Console.WriteLine("Número não é divisível pelos valores");
                }
            }
            Console.Clear();
            Console.WriteLine($"Quantidade de numeros divisivel por 3 e 9: {divPor3e9}\n{div3e9}\nQuantidade de numeros divisivel por 2 e 5: {divPor2e5}\n{div2e5}");

        }
    }
}