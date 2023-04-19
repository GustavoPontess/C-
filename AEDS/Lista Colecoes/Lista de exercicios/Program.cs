using System;
using System.Collections;
namespace Lista_de_exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = true;
            do
            {
                switch (menu())
                {
                    case 1:
                        Console.Clear();
                        Questao1();
                        break;
                    case 2:
                        Console.Clear();
                        Questao2();
                        break;
                    case 3:
                        Console.Clear();
                        Questao3();
                        break;
                    case 4:
                        Console.Clear();
                        Questao4();
                        break;
                    case 5:
                        Console.Clear();
                        Questao5();
                        break;
                    case 6:
                        Console.Clear();
                        Questao6();
                        break;
                    case 7:
                        Console.Clear();
                        Questao7();
                        break;
                    case 8:
                        Console.Clear();
                        Questao8();
                        break;
                    case 9:
                        Console.Clear();
                        Questao9();
                        break;
                    case 10:
                        Console.Clear();
                        Questao10();
                        break;
                    case 11:
                        Console.Clear();
                        Questao11();
                        break;
                    case 12:
                        Console.Clear();
                        Questao12();
                        break;
                    case 13:
                        Console.Clear();
                        Questao13();
                        break;
                    case 14:
                        Console.Clear();
                        Questao14();
                        break;
                    case 15:
                        Console.Clear();
                        Questao15();
                        break;
                    case 16:
                        Console.Clear();
                        Questao16();
                        break;
                    case 17:
                        Console.Clear();
                        Questao17();
                        break;
                    case 18:
                        Console.WriteLine("Adeus!");
                        sair = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção invalida!!");
                        Console.ResetColor();
                        break;
                }
            } while (sair);
        }

        static int menu()
        {
            int op = 0;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
──────▄▀▄─────▄▀▄
─────▄█░░▀▀▀▀▀░░█▄
─▄▄──█░░░░░░░░░░░█──▄▄
█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█");
            Console.ResetColor();
            Console.WriteLine(@"
=========MENU==========
01  -- Questão 01
02  -- Questão 02
03  -- Questão 03
04  -- Questão 04
05  -- Questão 05
06  -- Questão 06
07  -- Questão 07
08  -- Questão 08
09  -- Questão 09
10  -- Questão 10
11  -- Questão 11
12  -- Questão 12
13  -- Questão 13
14  -- Questão 14
15  -- Questão 15
16  -- Questão 16
17  -- Questão 17
18  -- Sair");
            Console.Write("Digite o numero da questão: ");
            try //colocando tratamento de exeção para caso o usuario digite algo que nao seja numeros
            {
                op = int.Parse(Console.ReadLine()!);
            }
            catch (System.Exception)
            {
                op = 20;
                // caso o usuario digite letra ou qualquer outra coisa que gere erro ira trocar para 20 e exiber a mensagem
                // de opção invalida
            }
            Console.Clear();
            return (op); //retorna a opção que o usuario escolheu
        }

        static void Questao1()
        {
            Console.WriteLine("====>> Questão 1");

            Lista List = new Lista(10);
            Fila Que = new Fila(10);
            Pilha Sta = new Pilha(10);

            int entrada = 0;
            Console.WriteLine("Digite 10 numeros:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}° Numero: ");
                entrada = int.Parse(Console.ReadLine()!);

                List.Inserir(entrada);
                Que.Inserir(entrada);
                Sta.Inserir(entrada);
            }
            Console.Clear();
            Console.WriteLine("===== ArrayList =====");
            List.Imprimir();
            Console.WriteLine("\n=====   Queue   =====");
            Que.Imprimir();
            Console.WriteLine("\n=====   Stack   =====");
            Sta.Imprimir();

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }

        static void Questao2()
        {
            Console.WriteLine("====>> Questão 2");
            Lista List = new Lista(10);
            Fila Que = new Fila(10);
            Pilha Sta = new Pilha(10);

            string entrada = "";
            Console.WriteLine("Digite 10 Palavras:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}° String: ");
                entrada = Console.ReadLine()!;

                List.Inserir(entrada);
                Que.Inserir(entrada);
                Sta.Inserir(entrada);
            }
            Console.Clear();
            Console.WriteLine("===== ArrayList =====");
            List.Imprimir();
            Console.WriteLine("\n=====   Queue   =====");
            Que.Imprimir();
            Console.WriteLine("\n=====   Stack   =====");
            Sta.Imprimir();

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao3()
        {
            Console.WriteLine("====>> Questão 3");
            Lista List = new Lista();
            Fila Que = new Fila();
            Pilha Sta = new Pilha();

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao4()
        {
            Console.WriteLine("====>> Questão 4");
            ArrayList Elementos = new ArrayList(10);
            Queue Q1 = new Queue(10); // Fila
            Stack S1 = new Stack(10); // Pilha

            Random R = new Random();
            int numero = 0, Soma = 0, j = 0;

            for (int i = 0; i < 10; i++)
            {
                numero = R.Next(0, 100);
                if (numero % 2 == 0)
                {
                    Elementos.Add(numero);
                    Q1.Enqueue(numero); // Adiciona um elemento ao final do Queue 
                    S1.Push(numero); //Adiciona um elemento ao topo da Pilha
                }
                else { i--; }
            }

            Console.WriteLine("===== ArrayList =====");
            foreach (var num in Elementos)
            {
                Console.Write($"{num}, ");
            }
            while (j < Elementos.Count)
            {
                Soma += (int)Elementos[j];
                j++;
            }
            Console.WriteLine($" || Soma = {Soma}");
            Soma = 0; j = 0;

            Console.WriteLine("\n=====   Queue   =====");
            foreach (var num in Q1)
            {
                Console.Write($"{num}, ");
                Soma += (int)num;
            }
            Console.WriteLine($" || Soma = {Soma}");
            Soma = 0;

            Console.WriteLine("\n=====   Stack   =====");
            foreach (var num in S1)
            {
                Console.Write($"{num}, ");
                Soma += (int)num;
            }
            Console.WriteLine($" || Soma = {Soma}");

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao5()
        {
            Console.WriteLine("====>> Questão 5");
            ArrayList Elementos = new ArrayList(10);
            Queue Q1 = new Queue(10); // Fila
            Stack S1 = new Stack(10); // Pilha

            Random R = new Random();
            int Soma = 0, j = 0;

            for (int i = 0; i < 10; i++)
            {
                Elementos.Add(R.Next(0, 100));
                Q1.Enqueue(R.Next(0, 100)); // Adiciona um elemento ao final da Queue
                S1.Push(R.Next(0, 100)); // Adiciona um elemento ao topo da pilha
            }

            Console.WriteLine("===== ArrayList =====");
            foreach (var num in Elementos)
            {
                Console.Write($"{num}, ");
            }

            do
            {
                Soma += (int)Elementos[j];
                j++;
            }
            while (j < Elementos.Count);


            Console.WriteLine($" || Soma = {Soma}");
            Soma = 0; j = 0;

            Console.WriteLine("\n=====   Queue   =====");
            foreach (var num in Q1)
            {
                Console.Write($"{num}, ");
                Soma += (int)num;
            }
            Console.WriteLine($" || Soma = {Soma}");
            Soma = 0;

            Console.WriteLine("\n=====   Stack   =====");
            foreach (var num in S1)
            {
                Console.Write($"{num}, ");
                Soma += (int)num;
            }
            Console.WriteLine($" || Soma = {Soma}");

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao6()
        {
            Console.WriteLine("====>> Questão 6");
            ArrayList Elementos = new ArrayList(10);
            Queue Q1 = new Queue(10); // Fila
            Stack S1 = new Stack(10); // Pilha

            Random R = new Random();
            int numero = 0, Soma = 0;

            for (int i = 0; i < 10; i++)
            {
                numero = R.Next(0, 100);
                if (numero % 2 == 0)
                {
                    Elementos.Add(numero);
                    Q1.Enqueue(numero); // Adiciona um elemento ao final do Queue
                    S1.Push(numero); // Adiciona um elemento ao topo da Pilha
                }
                else { i--; }
            }

            Console.WriteLine("===== ArrayList =====");
            foreach (var num in Elementos)
            {
                Console.Write($"{num}, ");
                Soma += (int)num;
            }
            Console.WriteLine($" || Soma = {Soma}");
            Soma = 0;

            Console.WriteLine("\n=====   Queue   =====");
            foreach (var num in Q1)
            {
                Console.Write($"{num}, ");
                Soma += (int)num;
            }
            Console.WriteLine($" || Soma = {Soma}");
            Soma = 0;

            Console.WriteLine("\n=====   Stack   =====");
            foreach (var num in S1)
            {
                Console.Write($"{num}, ");
                Soma += (int)num;
            }
            Console.WriteLine($" || Soma = {Soma}");

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao7()
        {
            Console.WriteLine("====>> Questão 7");

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao8()
        {

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao9()
        {

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao10()
        {

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao11()
        {

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao12()
        {

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao13()
        {

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao14()
        {

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao15()
        {

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao16()
        {

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao17()
        {

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }

        
    }
}