namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Faça um procedimento que recebe as 3 notas de um aluno 
            // por parâmetro e uma letra.Se a letra for ‘A’, o procedimento calcula 
            // e escreve a média aritmética das notas do aluno, se for ‘P’, calcula e 
            // escreve a sua média ponderada(pesos: 5, 3 e 2).Faça um programa que leia 
            // 3 notas de N alunos e acione o procedimento para cada aluno. (N deve ser lido do teclado)

            //Declarando variaveis
            int nota0 = 0, nota1 = 0, nota2 = 0;
            char letra = ' ';

            //chamando procedimento entradaDeDados passando referencia do endereçõ de memoria das variaveis
            entradaDeDados(ref nota0, ref nota1, ref nota2, ref letra);

            //chamando procedimento calculo e passando parametros
            calculo(nota0, nota1, nota2, letra);
        }

        static void entradaDeDados(ref int nota0, ref int nota1, ref int nota2, ref char letra)
        {
            Console.WriteLine($"Digite a 1° nota: ");
            nota0 = int.Parse(Console.ReadLine()!);
            Console.Clear();
            Console.WriteLine($"Digite a 2° nota: ");
            nota1 = int.Parse(Console.ReadLine()!);
            Console.Clear();
            Console.WriteLine($"Digite a 3° nota: ");
            nota2 = int.Parse(Console.ReadLine()!);
            Console.Clear();
            Console.WriteLine(@"Qual calculo deseja fazer?
A = média aritmética
P = média ponderada");
            letra = Convert.ToChar(Console.ReadLine()!);
        }
        static void calculo(int nota0 = 0, int nota1 = 0, int nota2 = 0, char letra = ' ')
        {
            double calculo = 0, p1 = 5, p2 = 3, p3 = 2;
            switch (letra)
            {
                case 'A':
                    calculo = (nota0 + nota1 + nota2) / 3;
                    Console.WriteLine($"A média aritmética e: {calculo}");
                    break;
                case 'P':
                    calculo = ((nota0 * p1) + (nota1 * p2) + (nota2 * p3)) / (p1 + p2 + p3);
                    Console.WriteLine($"A média ponderada e: {calculo}");
                    break;
                default:
                    Console.WriteLine("Opção escolhida e invalida!!");
                    break;
            }
        }
    }
}