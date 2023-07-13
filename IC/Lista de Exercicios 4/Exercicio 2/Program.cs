namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Faça um procedimento que receba e preencha um vetor com as notas de uma turma de 10 alunos. 
            // Faça um outro procedimento que receba um vetor preenchido com as notas, calcule a média da 
            // turma e conte quantos alunos obtiveram nota acima da média. Esse procedimento deve exibir
            // a média e o resultado da contagem. Faça um programa que declare as devidas variáveis e 
            // acione os procedimentos.

            //Declarando variaveis
            int x = 10, cont = 0;
            double[] notas = new double[x];
            double media = 0;

            //passando o vetor para o procedimento menu para preenchimento das notas
            menu(notas, x);
            calcula(notas, x, media, cont);
        }
        // Criando um procedimento para preenchimento das notas
        static void menu(double[] notas, int x)
        {
            Random R = new Random();
            for (int i = 0; i < x; i++)
            {
                Console.Write($"Digite a nota do {i + 1}° aluno: ");
                //notas[i] = double.Parse(Console.ReadLine()!); //Preenchimento manual das notas
                notas[i] = R.Next(0, 10); // preenchimento automatico e aleatorio das notas
                Console.WriteLine(notas[i]);
            }
        }
        // Criando procedimento para calcular a media das notas e quais alunos estao acima da medio
        static void calcula(double[] notas, int x, double media, int cont)
        {
            for (int i = 0; i < x; i++)
            {
                media += notas[i];
            }
            media /= x;
            for (int i = 0; i < x; i++)
            {
                if (notas[i] >= media)
                {
                    cont++;
                }
            }
            Console.WriteLine($"A media da turma e: {media};\nA quantidade de alunos acima da media e: {cont}");
        }
    }
}