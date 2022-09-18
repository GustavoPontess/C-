namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Um hotel com 75 apartamentos deseja fazer uma promoção especial de final de semana,
            // concedendo um desconto de 25% na diária. Com isto, espera aumentar sua taxa de
            // ocupação de 50 para 80%. Sendo dado o valor normal da diária, calcular e imprimir:
            // a) o valor da diária promocional;
            // b) o valor total arrecadado com 80% de ocupação e diária promocional;
            // c) o valor total arrecadado com 50% de ocupação e diária normal;
            // d) a diferença entre estes dois valores.            

            //Declarando as variaveis
            double diariaPromo, mediaPromo, mediaSemPromo, diariaNormal, lucroOuPreju;

            //Solicitando entrada de dados
            Console.WriteLine("Digite o valor da diaria:");
            //Armazenando entrada de dados
            diariaNormal = double.Parse(Console.ReadLine()?? string.Empty);

            //Calculando a diaria promocional
            diariaPromo = 0.75 * diariaNormal;
            //Calculando o total arrecadado com 80% de ocupação e diária promocional
            //!!!!nao entendi muito bem como calcular
            mediaPromo = (0.8*75)*8*diariaPromo;
            //Calculando o total arrecadado com 50% de ocupação e diária normal
            //!!!!nao entendi muito bem como calcular
            mediaSemPromo = (0.5*75)*8*diariaNormal;
            //Calculando a diferença entre a ocupação normal e a promocional
            lucroOuPreju = mediaPromo - mediaSemPromo;

            //Imprimindo o resultado 
            Console.WriteLine($"O valor da diaria com promoção e: {diariaPromo}");
            Console.WriteLine($"O valor total arrecadado com 80% de ocupação e diária promocional e: {mediaPromo:F2}");
            Console.WriteLine($"O valor total arrecadado com 50% de ocupação e diária normal: {mediaSemPromo:F2}");
            Console.WriteLine($"O valor da diferença entre a ocupação normal e a promocional e: {lucroOuPreju:F2}");

            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}