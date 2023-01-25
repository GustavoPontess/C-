using System;
using System.Globalization;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();
            bool sair = true;
            Console.Clear();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine()!;
            Console.Write("Preço: ");
            prod.Preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Quantidade:");
            prod.Quantidade = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Clear();
            do //Estrutura de repetição qeu vai manter o codigo em loop ate o usuario selecionar a opção 6 do menu
            {
                switch (menu())
                { //O switch chama o menu e espera o retorno para direcionar o usuario para oq ele deseja fazer
                    case 1: // caso o usuario escolha a opção 1 do menu
                        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                        prod.AdicionarProdutos(int.Parse(Console.ReadLine()!));
                        break;
                    case 2:// caso o usuario escolha a opção 2 do menuaa
                        Console.Write("Digite o número de produtos a ser removido do estoque: ");
                        prod.RemoverProdutos(int.Parse(Console.ReadLine()!));
                        break;
                    case 3: // caso o usuario escolha a opção 3 do menu
                        Console.Write(prod);
                        Console.WriteLine("\npressione qualquer tecla para voltar ao menu...");
                        // basic use of "Console.ReadKey()" method
                        Console.ReadKey();
                        break;
                    case 4: // caso o usuario escolha a opção 3 do menu
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
        { //procedimento que imprime o menu para o usuario 
            int op = 0;
            Console.Clear();
            Console.WriteLine(@"
================MENU=============
1 -- Adicionar Produto
2 -- Remover Produto
3 -- Dados do Produto
4 -- Sair");
            Console.Write("Digite um numero: ");
            try //colocando tratamento de exeção para caso o usuario digite algo que nao seja numeros
            {
                op = int.Parse(Console.ReadLine()!);
            }
            catch (System.Exception)
            {
                op = 9;
                // caso o usuario digite letra ou qualquer outra coisa que gere erro ira trocar para 9 e exiber a mensagem
                // de opção invalida
            }
            Console.Clear();
            return (op); //retorna a opção que o usuario escolheu
        }
    }
}