using System;
using System.IO;
using System.Text;

namespace Exercicio_9
{
    class Program
    {
        // 9. Crie um programa que receba dados de vários alunos (Matricula e Telefone) e armazene em um 
        // arquivo texto. Crie no mesmo programa uma opção de ler dados de um arquivo já armazenado dados de alunos.
        static void Main(string[] args)
        {
            bool sair = true;
            do
            {
                switch (menu())
                {
                    case 1:
                        cadastrar();
                        Console.Clear();
                        break;
                    case 2:
                        leitura();
                        break;
                    case 3:
                        Console.WriteLine("Adeus!");
                        sair = false;
                        break;
                    default:
                        Console.WriteLine("Opção invalida!!");
                        break;
                }
            } while (sair);
        }

        static int menu()
        {
            int op = 0;
            Console.WriteLine(@"=======MENU=======
1 -- Cadastrar
2 -- Ver Cadastros
3 -- Sair");
            op = int.Parse(Console.ReadLine()!);
            Console.Clear();
            return (op);
        }

        static void cadastrar()
        {
            StreamWriter sw = new StreamWriter("resultado.txt", true, Encoding.ASCII);
            char op = ' ';
            string gravar = string.Empty, matricula = string.Empty, telefone = string.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine("====Cadastrar Aluno====");
                Console.Write("Digite o N° de matricula: ");
                matricula = Console.ReadLine()!;
                Console.Clear();
                Console.WriteLine("====Cadastrar Aluno====");
                Console.Write("Digite o N° de Telefone: ");
                telefone = Console.ReadLine()!;
                Console.Clear();
                Console.WriteLine("====Cadastrar Aluno====");
                gravar = $"Matricula: {matricula} | Telefone: {telefone}";
                sw.WriteLine(gravar);
                Console.WriteLine("Dados gravados com sucesso!\nDeseja continuar? <Y> sim <N> não");
                op = Convert.ToChar(Console.ReadLine()!);

            } while (op == 'Y');
            sw.Close();
        }

        static void leitura()
        {
            do
            {
                StreamReader sr = new StreamReader("resultado.txt");
                String line = sr.ReadLine()!;
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine()!;
                }
                sr.Close();
                Console.WriteLine("Pressione <Esc> para voltar ao menu...");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
            Console.Clear();
        }
    }
}
