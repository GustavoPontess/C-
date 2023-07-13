namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o salário e 
            // número de filhos de cada habitante. A prefeitura deseja saber:
            // a) média do salário da população;
            // b) média do número de filhos;
            // c) maior salário;
            // d) percentual de pessoas com salário até R$100,00.
            // O final da leitura de dados se dará com a entrada de um salário negativo.     

            // Declarando entrada de dados
            double salario, medSalarioPopulacao = 0, medNumeroFilhos = 0, maiorSalario = 0, percentual = 0;
            int nFilhos = 0, cont = 0;

            Console.WriteLine(@"===========================
Prefeitura de BeloHorizonte
    Pesquisa do IBGE       
===========================");
            do
            {
                //Solicitando entrada de dados
                Console.Write($"Digite o valor do salario: ");
                salario = double.Parse(Console.ReadLine()!);
                Console.Write("Digite a quantidade de filhos: ");
                nFilhos = int.Parse(Console.ReadLine()!);
                Console.Clear();
                if (salario > 0)
                {
                    cont++;

                    if (salario > maiorSalario)
                    {
                        maiorSalario = salario;
                    }

                    if (salario <= 100)
                    {
                        percentual++;
                    }

                    medSalarioPopulacao += salario;

                    medNumeroFilhos += nFilhos;
                }
            } while (salario > 0);

            medNumeroFilhos /= cont;
            medSalarioPopulacao /= cont;
            percentual = (percentual * 100) / cont;
            Console.WriteLine(@"=====================================================
             Prefeitura de BeloHorizonte
                  Pesquisa do IBGE     
=====================================================");
            Console.WriteLine(@$"================RESULTADO=DA=PESQUISA================
Media do Salario da População: {medSalarioPopulacao:F2}
média do número de filhos: {medNumeroFilhos:F2}
maior salário: R${maiorSalario:F2}
percentual de pessoas com salário até R$100,00: {percentual}%");
        }
    }
}