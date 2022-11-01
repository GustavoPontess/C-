namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. A prefeitura de uma cidade fez uma pesquisa entre os seus habitantes, coletando 
            // dados sobre o salário e número de filhos. Faça um procedimento que leia esses dados 
            // para um número não determinado de pessoas, calcule e exiba a média de salário da população
            // (a condição de parada pode ser um flag ou a quantidade N). Faça um programa que acione o 
            // procedimento.
            //

            mediaSalarial();
        }

        static void mediaSalarial()
        {
            //Declarando variaveis
            double salario = 0;
            int cont = 0, numeroDeFilhos;
            string read = "S";

            do
            {
                Console.Clear();
                Console.WriteLine("Digite o seu Salario: ");
                salario += double.Parse(Console.ReadLine()!);
                Console.Clear();
                Console.WriteLine("Digite o numedo de filhos: ");
                numeroDeFilhos = int.Parse(Console.ReadLine()!);
                Console.Clear();
                cont++;
                Console.WriteLine("Deseja continuar? <S> sim <N> não");
                read = Convert.ToString(Console.ReadLine()!);

            } while (read != "N");
            Console.Clear();
            Console.WriteLine($"A média de salário da população e: R${(salario/cont):F2}");
        }
    }
}