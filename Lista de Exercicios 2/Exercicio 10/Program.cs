namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. Em uma eleição presidencial existem quatro candidatos. Os votos são informados através de códigos. 
            // Os dados utilizados para a contagem dos votos obedecem à seguinte codificação:
            // 1,2,3,4 = voto para os respectivos candidatos;
            // 5 = voto nulo;
            // 6 = voto em branco;
            // 
            // Elabore um algoritmo que leia o código do candidado em um voto. Calcule e escreva:
            // - total de votos para cada candidato;
            // - total de votos nulos;
            // - total de votos em branco.
            // 
            // Como finalizador do conjunto de votos, tem-se o valor 0.        

            int op = 1, c1 = 0, c2 = 0, c3 = 0, c4 = 0, nulo = 0, votob = 0;

            while (op != 0)
            {
                Console.WriteLine("Informe o candidado de sua preferncia sendo \n 1 - C1; \n 2 - C2; \n 3 - C3; \n 4 - C4; \n 5 - voto nulo; \n 6 - voto branco");
                op = int.Parse(Console.ReadLine()!);
                switch (op)
                {
                    case 1:
                        c1++;
                        break;

                    case 2:
                        c2++;
                        break;

                    case 3:
                        c3++;
                        break;

                    case 4:
                        c4++;
                        break;

                    case 5:
                        votob++;
                        break;

                    case 6:
                        nulo++;
                        break;
                    default:
                        Console.WriteLine("Este numero de canditado nao existe!");
                        break;
                }
                Console.Clear();
            }

            Console.WriteLine("C1: {0}", c1);
            Console.WriteLine("C2: {0}", c2);
            Console.WriteLine("C3: {0}", c3);
            Console.WriteLine("C4: {0}", c4);
            Console.WriteLine("nulos: {0}", nulo);
            Console.WriteLine("Votos em branco: {0}", votob);
        }
    }
}