namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Adaptar o programa acima para que ele calcule o percentual dos valores positivos, 
            //negativos e zeros em relação ao total de valores fornecidos.     

            //Declarando variaveis 
            int positivos = 0, negativos = 0, zeros = 0;
            string[] valores;
            //solicitando entrada de dados
            Console.WriteLine("Digite uma sequência de valores inteiros separados por barra: ");
            //Armazenando entrada de dados, separando com split, jogando os dados em uma matriz unidirecional
            valores = Console.ReadLine()!.Split(' ');
            //Limpando o console
            Console.Clear();
            //Pegando cafa valor da matriz e comparando para saber se e ==0, menor que 0 para negativos ou positivos
            foreach (var val in valores)
            {
                if (int.Parse(val) == 0)
                {
                    zeros++; 
                }
                else if (int.Parse(val) < 0)
                {
                    negativos++;
                }
                else
                {
                    positivos++;
                }
            }
            //Imprimindo valores para o usuario
            Console.WriteLine($"Quantidade de zeros digitados: {zeros}, Equivalem a {(zeros*100)/int.Parse(valores.Length.ToString())}%\nQuantidade de numeros negativos: {negativos} , Equivalem a {(negativos*100)/int.Parse(valores.Length.ToString())}%\nQuantidade de numeros positivos: {positivos}, Equivalem a {(positivos*100)/int.Parse(valores.Length.ToString())}%");

            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);       
        }
    }
}