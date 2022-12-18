using System;
using System.IO;
using System.Text;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = true;
            int linha = 31, coluna = 5;
            string[] produtos = new string[] { };
            string[,] vendasMes = new string[linha,coluna];
            do
            {
                switch (menu())
                {
                    case 1:
                        // chamar função
                        produtos = importarProdutos();
                        if (produtos.Length == 0)
                        {
                            Console.WriteLine("Falha ao importar os produtos!");
                        }
                        else
                        {
                            Console.WriteLine("Produtos importados com sucesso!");
                        }
                        break;
                    case 2:
                        // chamar função
                        vendasMes = registrarVenda(produtos, vendasMes);
                        Console.Clear();
                        break;
                    case 3:
                        // chamar função
                        relatorioVendas(vendasMes);
                        Console.Clear();
                        break;
                    case 4:
                        // chamar função
                        relatorioEstoque();
                        Console.Clear();
                        break;
                    case 5:
                        // chamar função
                        criarArquivoVendas(produtos, vendasMes);
                        Console.Clear();
                        break;
                    case 6:
                        // chamar função
                        Console.WriteLine("Adeus!");
                        sair = false;
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!!");
                        break;
                }
            } while (sair);
        }

        private static int menu()
        {
            int op = 0;
            Console.WriteLine(@"
================MENU=============
1 -- Importar arquivo de produtos
2 -- Registrar venda
3 -- Relatório de vendas
4 -- Relatório de estoque
5 -- Criar arquivo de vendas
6 -- Sair");
            Console.Write("Digite um numero: ");
            op = int.Parse(Console.ReadLine()!);
            Console.Clear();
            return (op);
        }

        private static string[] importarProdutos()
        {
            string[] produtos;
            string produto = "";
            int cont = 1;
            StreamReader sr = new StreamReader("dbProdutos.txt");
            String line = sr.ReadLine()!;
            while (line != null)
            {
                produto += line;
                line = sr.ReadLine()!;
                Console.WriteLine($"Importando produto {cont}° ...");
                cont++;
            }
            sr.Close();
            produtos = produto.Split(';');
            Console.Clear();
            return (produtos);
        }

        private static string[,] registrarVenda(string[] produtos, string[,] vendas)
        {
            int id = 0, dia = 0, prod = 0, total = 0, quantidade = 0;
            string[] to;
            string[,] vendasMes = vendas;
            do
            {
                Console.Clear();
                bool pass = true;
                Console.Clear();
                do
                {
                    try
                    {
                        Console.WriteLine("====Registrar Venda====");
                        Console.Write("Digite o N° do produto: ");
                        id = int.Parse(Console.ReadLine()!);
                        if (id >= 1 && id <= 4)
                        {
                            pass = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Dige um numero valido!! 1 a 4");
                        }

                        for (int i = 0; i < produtos.Length; i += 3)
                        {
                            if (produtos[i].Contains($"id: {id - 1}"))
                            {
                                prod = i;
                                to = produtos[prod + 2].Split(':');
                                total = int.Parse(to[1]);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        throw new ArgumentException("O valor informado não é válido.");
                    }
                } while (pass);
                Console.Clear();

                pass = true;
                do
                {
                    try
                    {
                        Console.WriteLine("====Registrar Venda====");
                        Console.Write("Digite dia do mês: ");
                        dia = int.Parse(Console.ReadLine()!);
                        if (dia <= 31 && dia >= 1)
                        {
                            pass = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("O dia do mês não e valido!!");
                        }
                    }
                    catch (System.Exception)
                    {
                        throw new ArgumentException("O valor informado não é válido.");
                    }

                } while (pass);
                Console.Clear();

                pass = true;
                do
                {
                    try
                    {
                        Console.WriteLine("====Registrar Venda====");
                        Console.Write("Quatidade de vendas: ");
                        quantidade = int.Parse(Console.ReadLine()!);
                        Console.Clear();

                        if (quantidade <= total)
                        {
                            vendasMes[(dia - 1), id] = Convert.ToString(quantidade);
                            pass = false;
                            StreamWriter sw = new StreamWriter("dbProdutos.txt", false, Encoding.ASCII);
                            for (int x = 0; x < 12; x += 3)
                            {
                                if (prod == x)
                                {
                                    sw.WriteLine($"{produtos[prod]};{produtos[prod + 1]};total: {total - quantidade};");
                                }
                                else
                                {
                                    sw.WriteLine($"{produtos[x]};{produtos[x + 1]};{produtos[x + 2]};");
                                }
                            }
                            sw.Close();
                            produtos = importarProdutos();
                        }
                        else
                        {
                            Console.WriteLine("Quantidade de vendas maior que quantidade em estoque!");
                            Console.WriteLine(total);

                        }
                    }
                    catch (System.Exception)
                    {
                        throw new ArgumentException("O valor informado não é válido.");
                    }

                } while (pass);

                Console.WriteLine("Venda registrada pressione <Esc> para voltar ao menu ou <Enter> para registrar uma nova venda...");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
            return (vendasMes);
        }

        private static void relatorioVendas(string[,] vendasMes)
        {
            int linha = 31, coluna = 5;
            do
            {
                for (int i = 0; i < linha; i++)
                {
                    vendasMes[i, 0] = $"Dia {i + 1}\t";
                }
                Console.WriteLine($"Dia/produto\t| Produto A \t| Produto B \t| Produto C \t| Produto D\t|");
                for (int i = 0; i < linha; i++)
                {
                    for (int j = 0; j < coluna; j++)
                    {
                        if (j != 0)
                        {
                            Console.Write($"\t{vendasMes[i, j]}\t|");
                        }
                        else
                        {
                            Console.Write($"{vendasMes[i, j]}\t|");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Pressione <Esc> para voltar ao menu ou <Enter> para mostrar o relatorio novamente...");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }
        private static void relatorioEstoque()
        {
            do
            {
                int cont = 0, linha = 4, coluna = 2;
                string[] produtos;
                string[,] prod = new string[linha, coluna];
                string produto = "";
                StreamReader sr = new StreamReader("dbProdutos.txt");
                String line = sr.ReadLine()!;
                while (line != null)
                {
                    produto += line;
                    line = sr.ReadLine()!;
                }
                sr.Close();
                produtos = produto.Split(';');
                for (int i = 1; i < produtos.Length; i += 3)
                {
                    prod[cont, 0] = produtos[i];
                    cont++;
                }
                cont = 0;
                for (int i = 2; i < produtos.Length; i += 3)
                {
                    prod[cont, 1] = produtos[i];
                    cont++;
                }
                for (int i = 0; i < linha; i++)
                {
                    for (int j = 0; j < coluna; j++)
                    {
                        Console.Write($"{prod[i, j]}\t|");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Pressione <Esc> para voltar ao menu ou <Enter> para mostrar o relatorio novamente...");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        private static void criarArquivoVendas(string[] produtos, string[,] vendasMes)
        {
            int coluna = 5, prod1 = 0, prod2 = 0, prod3 = 0, prod4 = 0;
            for (int i = 0; i < coluna; i++)
            {
                if (vendasMes[i, 1] != null)
                {
                    prod1 += int.Parse(vendasMes[i, 1]);
                }
                if (vendasMes[i, 2] != null)
                {
                    prod2 += int.Parse(vendasMes[i, 2]);
                }
                if (vendasMes[i, 3] != null)
                {
                    prod3 += int.Parse(vendasMes[i, 3]);
                }
                if (vendasMes[i, 4] != null)
                {
                    prod4 += int.Parse(vendasMes[i, 4]);
                }
            }
            StreamWriter sw = new StreamWriter("totalVendas.txt", false, Encoding.ASCII);
            sw.WriteLine($"{produtos[1]};total:{prod1};");
            sw.WriteLine($"{produtos[4]};total:{prod2};");
            sw.WriteLine($"{produtos[7]};total:{prod3};");
            sw.WriteLine($"{produtos[10]};total:{prod4};");
            sw.Close();
        }
    }
}
