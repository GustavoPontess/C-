namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Faça uma função que recebe um valor inteiro e verifica se o valor é positivo 
            // ou negativo. A função deve retornar um valor lógico (true ou false). Faça um programa 
            // que lê N números e para cada um deles exibe uma mensagem informando se ele é positivo 
            // ou não, dependendo se foi retornado verdadeiro ou falso pela função.

            int num1 = 0;
            bool resposta = true;
            string res;
            do
            {
                Console.WriteLine("Digite um numero inteiro positivo ou negativo: ");
                num1 = int.Parse(Console.ReadLine()!);
                resposta = verificador(num1);
                // if else normal
                // if(resposta){
                //     Console.WriteLine($"O numero {num1} e positivo");
                // }else{
                //     Console.WriteLine($"O numero {num1} e negativo");
                // }
                // usando operador ternario
                res = resposta ? "O numero "+num1+" e positivo" : "O numero "+num1+" e negativo";
                Console.WriteLine(res);

                Console.WriteLine("Press <Enter> to continue or <Esc> to exit...");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
            Console.Clear();
        }

        //Criando uma função que tera um retorno do tipo bool <true or false> que recebe um parametro
        //por referencia
        static bool verificador(int num1)
        {
            // if(num1>=0){
            //     return(true);
            // }else{
            //     return(false);
            // }
            return (num1>=0);
        }
    }
}