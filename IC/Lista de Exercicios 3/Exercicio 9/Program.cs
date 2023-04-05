namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. Faça uma função que lê um número indeterminado de notas de alunos, calcula e retorna 
            // a média das notas dos alunos aprovados (nota maior ou igual a 6). Faça um programa que lê
            // o número de alunos e imprime a média retornada pela função.
            
            Console.WriteLine($"A media das notas dos alunos aprovados e: {media()}");
        }

        //Criando uma função que tem como retorno um double
        static double media(){
            int cont=0;
            double total=0, nota;
            do
            {
                Console.WriteLine("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine()!);
                if(nota>=6){
                    cont++;
                    total+=nota;
                }
                Console.WriteLine("Press <Enter> to continue or <Esc> to exit...");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);  
            Console.Clear();
            return(total/cont);
        }
    }
}