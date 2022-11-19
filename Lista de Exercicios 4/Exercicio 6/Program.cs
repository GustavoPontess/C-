namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Em uma cidade, sabe-se hipoteticamente que, em outubro de 2022, não ocorreu temperatura 
            // inferior a 15°C, nem superior a 40°C. Faça um programa que armazene as temperaturas de cada dia 
            // de outubro em um vetor (de 31 posições), calcule e imprima:
            // - A menor e a maior temperatura ocorrida;
            // - A temperatura média;
            // - O número de dias nos quais a temperatura foi inferior a temperatura média.

            int tVetor = 31, temp = 0, menorTemp=40, maiorTemp=15, media=0, total=0;
            bool pass = true;
            int[] tempOutubro = new int[tVetor];
            Random R = new Random();

            for (int i = 0; i < tVetor; i++)
            {
                do
                {
                    pass = true;
                    Console.WriteLine($"Digite a temperatura do {i + 1}° dia");
                    //temp = int.Parse(Console.ReadLine()!);
                    temp = R.Next(15,40);
                    if (temp>=15 && temp<=40)
                    {
                        tempOutubro[i] = temp;
                        if(menorTemp>temp){
                            menorTemp = temp;
                        }else if(maiorTemp<temp){
                            maiorTemp = temp;
                        }
                        total+=temp;
                        pass = false;
                        Console.WriteLine("Temperatura registrada");
                    }else{
                        Console.WriteLine("A temperatura do mes de Outubro\nnão deve ser inferior a 15°C e\nnem superior a 40°C");
                    }
                } while (pass);
            }
            Console.Clear();
            // foreach (var item in tempOutubro)
            // {
            //     Console.WriteLine($"Temperatura: {item}");
            // }
            media = total/31;
            total = 0;
            foreach (var item in tempOutubro)
            {
                if (item<media)
                {
                    total++;
                }
            }
            Console.WriteLine($"A menor temperatura do mes foi: {menorTemp}°C, e a maior foi: {maiorTemp}°C;\nTendo uma temperatura media de: {media}°C\nQuantidade de dias com a temperatura a baixo da media: {total}.");
        }
    }
}