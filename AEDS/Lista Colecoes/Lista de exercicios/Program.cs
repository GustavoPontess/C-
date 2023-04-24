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
08  -- Questão 08, 09 e 10
11  -- Questão 11
12  -- Questão 12
13  -- Questão 13, 14 e 15
16  -- Questão 16
17  -- Questão 17
18  -- Sair");
            Console.Write("Digite um numero do menu: ");
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

            for (int i = 1; i < 100; i += 2)
            {
                List.Inserir(i);
                Que.Inserir(i);
                Sta.Inserir(i);
            }
            Console.Clear();
            Console.WriteLine("===== ArrayList =====");
            List.Imprimir();
            Console.WriteLine(List.SomaElementosFor());
            Console.WriteLine("\n=====   Queue   =====");
            Que.Imprimir();
            Console.WriteLine(Que.SomaElementos());
            Console.WriteLine("\n=====   Stack   =====");
            Sta.Imprimir();
            Console.WriteLine(Sta.SomaElementos());

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao4()
        {
            Console.WriteLine("====>> Questão 4");
            Lista List = new Lista();
            Fila Que = new Fila();
            Pilha Sta = new Pilha();

            for (int i = 0; i < 100; i += 2)
            {
                List.Inserir(i);
                Que.Inserir(i);
                Sta.Inserir(i);
            }
            Console.Clear();
            Console.WriteLine("===== ArrayList =====");
            List.Imprimir();
            Console.WriteLine(List.SomaElementosWhile());
            Console.WriteLine("\n=====   Queue   =====");
            Que.Imprimir();
            Console.WriteLine(Que.SomaElementos());
            Console.WriteLine("\n=====   Stack   =====");
            Sta.Imprimir();
            Console.WriteLine(Sta.SomaElementos());

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao5()
        {
            Console.WriteLine("====>> Questão 5");
            Lista List = new Lista();
            Fila Que = new Fila();
            Pilha Sta = new Pilha();

            for (int i = 0; i < 100; i++)
            {
                List.Inserir(i);
                Que.Inserir(i);
                Sta.Inserir(i);
            }
            Console.Clear();
            Console.WriteLine("===== ArrayList =====");
            List.Imprimir();
            Console.WriteLine(List.SomaElementosDoWhile());
            Console.WriteLine("\n=====   Queue   =====");
            Que.Imprimir();
            Console.WriteLine(Que.SomaElementos());
            Console.WriteLine("\n=====   Stack   =====");
            Sta.Imprimir();
            Console.WriteLine(Sta.SomaElementos());

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao6()
        {
            Console.WriteLine("====>> Questão 6");
            Lista List = new Lista();
            Fila Que = new Fila();
            Pilha Sta = new Pilha();

            for (int i = 0; i < 100; i += 2)
            {
                List.Inserir(i);
                Que.Inserir(i);
                Sta.Inserir(i);
            }
            Console.Clear();
            Console.WriteLine("===== ArrayList =====");
            List.Imprimir();
            Console.WriteLine(List.SomaElementosForeach());
            Console.WriteLine("\n=====   Queue   =====");
            Que.Imprimir();
            Console.WriteLine(Que.SomaElementos());
            Console.WriteLine("\n=====   Stack   =====");
            Sta.Imprimir();
            Console.WriteLine(Sta.SomaElementos());

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao7()
        {
            Console.WriteLine("====>> Questão 7");
            Lista List = new Lista();
            Fila Que = new Fila();
            Pilha Sta = new Pilha();

            ArrayList entrada = new ArrayList() { 5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5 };

            List.Inserir(entrada);
            Que.Inserir(entrada);
            Sta.Inserir(entrada);

            Console.Clear();
            Console.WriteLine("===== ArrayList =====");
            List.Imprimir();
            List.RemoveAll(5);
            List.RemoveAll(13);
            List.Imprimir();
            Console.WriteLine("\n=====   Queue   =====");
            Que.Imprimir();
            Que.RemoveAll(5);
            Que.RemoveAll(13);
            Que.Imprimir();
            Console.WriteLine("\n=====   Stack   =====");
            Sta.Imprimir();
            Sta.RemoveAll(5);
            Sta.RemoveAll(13);
            Sta.Imprimir();

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao8()
        {
            Console.WriteLine("====>> Questão 8, 9 e 10");
            Lista List = new Lista();
            Fila Que = new Fila();
            Pilha Sta = new Pilha();

            Console.WriteLine("Digite N numeros inteiros, Digite FIM para terminar.");
            string? leitura = Console.ReadLine();
            while (leitura != "FIM")
            {
                List.Inserir(int.Parse(leitura));
                Que.Inserir(int.Parse(leitura));
                Sta.Inserir(int.Parse(leitura));
                leitura = Console.ReadLine();
            }
            Console.Clear();
            List.Imprimir();
            Console.WriteLine("===== ArrayList =====");
            Console.WriteLine($"Soma: {List.SomaElementosFor()} | Media: {List.MediaAritmetica(List.SomaElementosFor())}");
            Console.WriteLine($"Soma: {List.SomaElementosForeach()} | Media: {List.MediaAritmetica(List.SomaElementosForeach())}");
            Console.WriteLine("\n=====   Queue   =====");
            Console.WriteLine($"Soma: {Que.SomaElementos()} | Media: {Que.MediaAritmetica(Que.SomaElementos())}");
            Console.WriteLine("\n=====   Stack   =====");
            Console.WriteLine($"Soma: {Sta.SomaElementos()} | Media: {Sta.MediaAritmetica(Que.SomaElementos())}");

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }

        static void Questao11()
        {
            Console.WriteLine("====>> Questão 11");
            Lista List = new Lista();
            Fila Que = new Fila();
            Pilha Sta = new Pilha();

            ArrayList entrada = new ArrayList() { 1, 2, "AED", new Queue(), "teste", 3.14 };

            List.Inserir(entrada);
            Que.Inserir(entrada);
            Sta.Inserir(entrada);

            Console.WriteLine("===== ArrayList =====");
            Console.WriteLine($"Soma: {List.SomaElementosFor()}");
            Console.WriteLine("\n=====   Queue   =====");
            Console.WriteLine($"Soma: {Que.SomaElementos()}");
            Console.WriteLine("\n=====   Stack   =====");
            Console.WriteLine($"Soma: {Sta.SomaElementos()}");

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao12()
        {
            Console.WriteLine("====>> Questão 12");
            Lista List = new Lista();
            Fila Que = new Fila();
            Pilha Sta = new Pilha();

            for (int i = 2; i < 25; i++)
            {
                List.Inserir(i);
                Que.Inserir(i);
                Sta.Inserir(i);
            }

            Console.WriteLine("===== ArrayList =====");
            Console.WriteLine("\n===== Usando For =====");
            List.ImprimirFor();
            List.ImprimirReverso();
            List.ImprimirImpares();
            List.ImprimirElementosImpares();
            List.ImprimirMetade();
            Console.WriteLine("\n===== Usando Foreach =====");
            List.Imprimir();
            List.ImprimirRevForeach();
            List.ImprimirImpaForeach();
            List.ImprimirElementosForeach();
            List.ImprimirMetForeach();
            Console.WriteLine("\n=====   Queue   =====");
            Que.Imprimir();
            Que.ImprimirRevForeach();
            Que.ImprimirImpaForeach();
            Que.ImprimirElementosForeach();
            Que.ImprimirMetForeach();
            Console.WriteLine("\n=====   Stack   =====");
            Sta.Imprimir();
            Sta.ImprimirRevForeach();
            Sta.ImprimirImpaForeach();
            Sta.ImprimirElementosForeach();
            Sta.ImprimirMetForeach();

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao13()
        {
            Console.WriteLine("====>> Questão 13, 14 e 15");
            Lista List = new Lista();
            Fila Que = new Fila();
            Pilha Sta = new Pilha();

            int n = 0;
            Random r = new Random();
            Console.Write("Informe a quantidade de numeros que deseja gerar: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List.Inserir(r.Next(0, 100));
                Que.Inserir(r.Next(0, 100));
                Sta.Inserir(r.Next(0, 100));
            }

            Console.WriteLine("===== ArrayList =====");
            List.Imprimir();
            List.ImprimirRevSemReverse();
            Console.WriteLine($"Soma: {List.SomaElementosForeach()}");
            Console.WriteLine("\n=====   Queue   =====");
            Que.Imprimir();
            Que.ImprimirRevSemReverse();
            Console.WriteLine($"Soma: {Que.SomaElementos()}");
            Console.WriteLine("\n=====   Stack   =====");
            Sta.Imprimir();
            Sta.ImprimirRevSemReverse();
            Console.WriteLine($"Soma: {Sta.SomaElementos()}");

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao16()
        {
            Console.WriteLine("====>> Questão 16");
            Lista List = new Lista();
            Fila Que = new Fila();
            Pilha Sta = new Pilha();

            ArrayList entrada = new ArrayList() { -5, 13, -19, 31, -3, -7, -11, 5, -57, 13, 5 };

            List.Inserir(entrada);
            Que.Inserir(entrada);
            Sta.Inserir(entrada);
            

            Console.WriteLine("===== ArrayList =====");
            Console.WriteLine($"Soma: {List.QuantosPositivos()}");
            Console.WriteLine("\n=====   Queue   =====");
            Console.WriteLine($"Soma: {Que.QuantosPositivos()}");
            Console.WriteLine("\n=====   Stack   =====");
            Console.WriteLine($"Soma: {Sta.QuantosPositivos()}");

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }
        static void Questao17()
        {
             Console.WriteLine("====>> Questão 17");
            Lista List = new Lista();
            Fila Que = new Fila();
            Pilha Sta = new Pilha();

            ArrayList entrada = new ArrayList() { 5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5 };

            List.Inserir(entrada);
            Que.Inserir(entrada);
            Sta.Inserir(entrada);

            Console.Clear();
            Console.WriteLine("===== ArrayList =====");
            List.ContOcorrencia(5);
            List.ContOcorrencia(13);
            Console.WriteLine("\n=====   Queue   =====");
            Que.ContOcorrencia(5);
            Que.ContOcorrencia(13);
            Console.WriteLine("\n=====   Stack   =====");
            Sta.ContOcorrencia(5);
            Sta.ContOcorrencia(13);
            Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
            // basic use of "Console.ReadKey()" method
            Console.ReadKey();
            Console.Clear();
        }


    }
}