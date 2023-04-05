namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7.Faça um procedimento que recebe a média final de um aluno, identifica e exibe o seu conceito, 
            // conforme a tabela abaixo. Faça um programa que leia a média de N alunos, acionando o 
            // procedimento para cada um deles. (N deve ser lido do teclado)

            // Nota Conceito
            // ====     =======
            // Até 39   F
            // 40 a 59  E
            // 60 a 69  D
            // 70 a 79  C
            // 80 a 89  B
            // > 90     A

            //Declarando variaveis
            int N = 0, media=0;

            Console.WriteLine("Quantas notas serão lançadas? ");
            N = int.Parse(Console.ReadLine()!);
            Console.Clear();

            for (var i = 0; i < N; i++)
            {
                Console.WriteLine("Digite a media das notas do aluno: ");
                //Chamando o procedimento conceito passando a entrada de dados como parametro
                media = int.Parse(Console.ReadLine()!);
                conceito(media);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        //Criando procedimento que ira receber um parametro do tipo int que ira definir qual o seu conceito
        //baseado na media da sua nota
        static void conceito(int x){

            string res = "O conceito do aluno e: ";
            if(x<=39){
                res += "F";
            }else if(x>=60 && x<=69){
                res += "E";
            }else if(x>=40 && x<=59){
                res += "D";
            }else if(x>=70 && x<=79){
                res += "C";
            }else if(x>=80 && x<=89){
                res += "B";
            }else{
                res += "A";
            }
            Console.WriteLine($"\n{res}\n");
        }

    }
}