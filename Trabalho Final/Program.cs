using System;
using System.IO;
using System.Text;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando variaveis
            bool sair = true; // ira manter o programa em loop enquando for true
            int linha = 31, coluna = 5; // definindo o tamanho da matriz 
            string[] produtos = new string[] { }; // declarando vetor de produtor como vazio que 
            //ira receber os produtos apos importar os produtos ou toda vez que for chamada
            string[,] vendasMes = new string[linha, coluna]; // vendasMes matriz que ira receber as vendas feitas no mes
            do //Estrutura de repetição qeu vai manter o codigo em loop ate o usuario selecionar a opção 6 do menu
            {
                switch (menu()) 
                { //O switch chama o menu e espera o retorno para direcionar o usuario para oq ele deseja fazer
                    case 1: // caso o usuario escolha a opção 1 do menu
                        // chamar função
                        produtos = importarProdutos();
                        if (produtos.Length == 0) // caso o tamanho do vetor de produtos seja igual a zero quer dizer que ouve falha ao importar os produtos
                        {
                            Console.WriteLine("Falha ao importar os produtos!");
                        }
                        else // caso seja difereten importou os produtos com sucesso 
                        {
                            Console.WriteLine("Produtos importados com sucesso!");
                        }
                        break;
                    case 2:// caso o usuario escolha a opção 2 do menu
                        // chamar função
                        vendasMes = registrarVenda(produtos, vendasMes);
                        Console.Clear();
                        break;
                    case 3: // caso o usuario escolha a opção 3 do menu
                        // chamar função
                        relatorioVendas(vendasMes);
                        Console.Clear();
                        break;
                    case 4: // caso o usuario escolha a opção 4 do menu
                        // chamar função
                        produtos = importarProdutos();
                        relatorioEstoque(produtos);
                        Console.Clear();
                        break;
                    case 5: // caso o usuario escolha a opção 5 do menu
                        // chamar função
                        criarArquivoVendas(produtos, vendasMes);
                        Console.Clear();
                        break;
                    case 6: // caso o usuario escolha a opção 6 do menu
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
        { //procedimento que imprime o menu para o usuario 
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
        private static string[] importarProdutos()
        {
            string[] produtos;
            string produto = "";
            StreamReader sr = new StreamReader("dbProdutos.txt"); // abrindo arquivo para leitura
            String line = sr.ReadLine()!; // lendo a priemira linha
            while (line != null) // estrutura de repetição para ler todo o arquivo ate encontrar uma linha que senha == a nulo
            {
                produto += line; // pega todo o conteudo da linha e concatena na variavel de produtos
                line = sr.ReadLine()!; // faz a leitura da proxima linha
            }
            sr.Close(); // fecha o arquivo 
            produtos = produto.Split(';'); // pega toda a linha contendo a leitura do arquivo e separa usando ";" como separador e joga para um vetor produtos
            Console.Clear(); // limpa a tela
            return (produtos); // retorna o vetor contendo os produtos
        }
        private static string[,] registrarVenda(string[] produtos, string[,] vendas)
        {
            int id = 0, dia = 0, prod = 0, total = 0, quantidade = 0;
            string[] to;
            string[,] vendasMes = vendas;
            do // so vai sair do loop quando o usuario pressionar uma tecla diferente de enter caso contrario ira permitir 
            { //que ele faça um novo registro de vensa
                bool pass = true; // variavel para garantir que que ele preencha os campos certos
                Console.Clear();
                do // estrutura de repetição que so ira aceitar o valor digitado pelo usuario 
                { // se estiver dentro de 1 e 4 
                    Console.WriteLine("====Registrar Venda====");
                    Console.Write("Digite o N° do produto: ");
                    try // colocando tratamento de exceção para caso o usuario digite algo diferente de numeros
                    { 
                        id = int.Parse(Console.ReadLine()!);
                    }
                    catch (System.Exception)
                    {
                        id = 5; // caso digite qualquer coisa que nao seja numero ira colocar o id como 5 nao ira passar no if seguinte
                        // fazendo com que mostre a mesagem de digitte um numero valido;
                    }
                    if (id >= 1 && id <= 4)
                    { // o usuario digitando um valor valido ira trocar o pass pra false fazendo com que se incerre a repetição
                        // do primeiro campo;
                        pass = false;
                        for (int i = 0; i < produtos.Length; i += 3) // ira percorrer todo o vetor de produtos que foi passado por parametro
                        {
                            if (produtos[i].Contains($"id: {id - 1}")) // ate encontrar a posição no vetor que contenha (id: 2) ou oq o usuario tenha digitado;
                            { // e id -1 pois os id dos produtos começão em 0
                                prod = i; // salva na variavel prod a posição do vetor que corresponda ao id do produto;
                                to = produtos[prod + 2].Split(':'); // variavel to ira armazenar o nome total e a quantidade em estoque que o produto tem
                                total = int.Parse(to[1]); // ira pegar o posição 1 do vetor to que conten o total de produtos
                            }
                        }
                    }
                    else
                    { // caso o id escolhido pelo usuario nao esteja entre 1 e 4 imprimir a mensagem no console
                        Console.Clear();
                        Console.WriteLine("Dige um numero valido!! 1 a 4");
                    }
                } while (pass); // caso tenha preenchido o numero do produto correto ira sair da repetição
                Console.Clear();

                pass = true;
                do
                {
                    Console.WriteLine("====Registrar Venda====");
                    Console.Write("Digite dia do mês: ");
                    try // colocando tratamento de exceção para caso o usuario digite algo diferente de numeros
                    {
                        dia = int.Parse(Console.ReadLine()!);
                    }
                    catch (System.Exception)
                    {
                        dia = 32; //caso o usuario digite algo que nao sejam numeros ira trocar setar o dia para 32
                        // fazendo com que nao passe no if seguinte assim exibindo a mensagem de o dia nao e valido
                    }
                    if (dia <= 31 && dia >= 1) // verificando se a data digitada e valida estando entre 1 e 31
                    {
                        pass = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("O dia do mês não e valido!!");
                    }

                } while (pass);
                Console.Clear();

                pass = true;
                do
                {
                    Console.WriteLine("====Registrar Venda====");
                    Console.Write("Quatidade de vendas: ");
                    try // colocando tratamento de exceção para caso o usuario digite algo diferente de numeros
                    {
                        quantidade = int.Parse(Console.ReadLine()!);
                    }
                    catch (System.Exception)
                    {
                        quantidade = total+1; 
                        // caso o usuario digite qualquer coisa que nao seja numero nao ira passar no proximo if
                        // pois estou atribuindo a variavel de quantidade o proprio total +1
                        // fazendo com que assim monstre a mensagem de erro quantidade maior que quantidade em estoque;
                    }
                    Console.Clear();

                    if (quantidade <= total) // verificando se a quantidade vendida no dia nao ultrapassa o total em estoque 
                    {
                        vendasMes[(dia - 1), id] = Convert.ToString(quantidade); // salvando o quantidade na matriz; sendo a dia -1 pois a matriz comessa em 0, e o id que representa a coluna do produto na matriz
                        pass = false;
                        StreamWriter sw = new StreamWriter("dbProdutos.txt", false, Encoding.ASCII); // abrindo arquivo para gravação
                        for (int x = 0; x < 12; x += 3) // estrutura para repetir a mesma quantidade que o vetor de produtos tem 
                        { // o for pula de 3 em 3 pois os multiplos de 3 representam o inicio dos dados de um produto
                            if (prod == x) // se x for igual a posição do id que foi alterado ele ira gravar o novo valor
                            {
                                sw.WriteLine($"{produtos[prod]};{produtos[prod + 1]};total: {total - quantidade};");
                            }
                            else // caso nao ele mantem os valores que nao foram alterados
                            {
                                sw.WriteLine($"{produtos[x]};{produtos[x + 1]};{produtos[x + 2]};");
                            }
                        }
                        sw.Close();
                        produtos = importarProdutos(); // chamando a função importaProdutos para atualizar o vetor de produtos de acordo com o que foi salvo
                    }
                    else // caso a qauntidade vendida seja maior que a em estoque 
                    {
                        Console.WriteLine("Quantidade de vendas maior que quantidade em estoque!");
                        Console.WriteLine($"Total em estoque: {total}");
                    }

                } while (pass);

                Console.WriteLine("Venda registrada pressione <Esc> para voltar ao menu ou <Enter> para registrar uma nova venda...");
            } while (Console.ReadKey().Key == ConsoleKey.Enter); // espera o usuario escolher se quer cadastrar novo produto ou voltar ao menu
            return (vendasMes); // retorna a matriz de vendas no mes
        }
        private static void relatorioVendas(string[,] vendasMes) // recebe a matriz de vendas no mes e imprime no console
        {
            int linha = 31, coluna = 5;
            do
            {
                Console.WriteLine($"Dia/produto\t| Produto A \t| Produto B \t| Produto C \t| Produto D\t|");
                for (int i = 0; i < linha; i++)
                {
                    vendasMes[i, 0] = $"Dia {i + 1}\t";
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
        private static void relatorioEstoque(string[] produtos)
        {
            do
            {
                int cont = 0, linha = 4, coluna = 2;
                string[,] prod = new string[linha, coluna]; // criando uma matriz que vai receber os valores para imprimir

                for (int i = 1; i < produtos.Length; i += 3) // repetição que pega todos os nomes dos produtos 
                {// a repetição pula de 3 em 3 por isso precisamos de uma variavel auxiliar para nao estourar o tamanho da matriz
                    prod[cont, 0] = produtos[i];
                    cont++;
                }
                cont = 0;
                for (int i = 2; i < produtos.Length; i += 3) // repetição que pega a quantidade dos produtos
                {
                    prod[cont, 1] = produtos[i];
                    cont++;
                }
                for (int i = 0; i < linha; i++)  // repetição que imprime a matriz com os valores em estoque
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
            int linha = 31, prod1 = 0, prod2 = 0, prod3 = 0, prod4 = 0;
            for (int i = 0; i < linha; i++) // repetição para passar por todas as linhas
            {
                if (vendasMes[i, 1] != null) // verifico se o valor da minha linha na posição 1 que equivale ao produto um nao e nullo
                {
                    prod1 += int.Parse(vendasMes[i, 1]); // caso nao seja nullo ira converter para int e somar para me dar o total de vendas daquele produto
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
            StreamWriter sw = new StreamWriter("totalVendas.txt", false, Encoding.ASCII); // abro o arquivo para escrita
            sw.WriteLine($"{produtos[1]};total:{prod1};");
            sw.WriteLine($"{produtos[4]};total:{prod2};");
            sw.WriteLine($"{produtos[7]};total:{prod3};");
            sw.WriteLine($"{produtos[10]};total:{prod4};"); // escrevo em cada linha o nome do produto e o total;
            sw.Close();
        }
    }
}
