namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. Leia a velocidade máxima permitida em uma avenida e a velocidade com que o motorista
            // estava dirigindo nela. Se o motorista estiver dentro do limite de velocidade, imprima a
            // mensagem “Motorista respeitou a lei”. Se o motorista tiver ultrapassado a velocidade
            // máxima permitida, calcule e imprima o valor da multa a ser cobrada, sabendo que os
            // valores a serem cobrados são os seguintes:
            // - 50 reais se o motorista ultrapassar em até 10km/h a velocidade permitida (ex: se a
            // velocidade máxima for 50km/h e o motorista estiver a 60km/h ou a 56km/h);
            // - 100 reais, se o motorista ultrapassar de 11 a 30 km/h a velocidade permitida;
            // - 200 reais, se estiver acima de 30km/h da velocidade permitida.
            
            //Declarando variaveis
            int veloMax, velo;

            //Solicitando entrada de dados
            Console.WriteLine("Digite a velocidade maxima permitida:");
            //Armazenando a entrada de dados
            veloMax = int.Parse(Console.ReadLine() ?? string.Empty);
            //Solicitando entrada de dados
            Console.WriteLine("Digite a velocidade com que o motorista estava dirigindo");
            //Armazenando entrada de dados
            velo = int.Parse(Console.ReadLine() ?? string.Empty);

            //Calculando e imprimindo o valor da multa
            if(velo<=veloMax){
                Console.WriteLine($"Motorista respeitou a lei, velocidade de: {velo}Km/h");
            }else if(velo>veloMax && velo<=(veloMax+10)){
                Console.WriteLine($"Motorista desrespeitou a lei, velocidade de: {velo}Km/h, multa de R$50 reais");
            }else if(velo>(veloMax+10) && velo<=(veloMax+30)){
                Console.WriteLine($"Motorista desrespeitou a lei, velocidade de: {velo}Km/h, multa de R$100 reais");
            }else{
                Console.WriteLine($"Motorista desrespeitou a lei, velocidade de: {velo}Km/h, multa de R$200 reais");
            }


            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
