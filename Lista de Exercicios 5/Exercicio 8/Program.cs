using System;
using System.IO;
using System.Text;

namespace Exercicio_8
{
    class Program
    {
        // 8. Crie um programa que leia a quantidade de veículos que uma locadora de veículos possui e 
        // o valor que ela cobra por cada aluguel, mostrando as informações pedidas a seguir:
        // - Sabendo-se que um terço dos veículos são alugados por mês, exiba o faturamento anual da locadora
        // - Quando o cliente atrasa a entrega, é cobrada uma multa de 20% sobre o valor do aluguel. Sabendo que 
        // um décimo dos veículos alugados no mês é devolvido com atraso, calcule o valor ganho com multas no mês
        // - Sabe-se ainda que 2% dos veículos precisam de manutenção ao longo do ano. Calcule o valor gasto com a
        // manutenção anual, sabendo que o valor gasto em média com a manutenção é de R$ 600,00.
        // Além de mostrar os resultados na tela, grave em um arquivo chamado resultado.txt. Cada valor deverá ser armazenado em uma linha.
        static void Main(string[] args)
        {
            int quantidade = 0, valor = 0, fatAnual = 0;
            double mulMes = 0, manuAnual = 0;
            Console.Write("Digite a quantidade de veiculos: ");
            quantidade = int.Parse(Console.ReadLine()!);
            Console.Write("Digite o valor do aluguel: ");
            valor = int.Parse(Console.ReadLine()!);

            fatAnual = ((quantidade * valor) * 12) / 3;
            mulMes = ((quantidade * 0.2) * valor) / 10;
            manuAnual = ((0.02 * quantidade) * 600) * 12;

            Console.WriteLine($"faturamento anual: R${fatAnual:F2}");
            Console.WriteLine($"valor ganho com multas no mês: R${mulMes:F2}");
            Console.WriteLine($"valor gasto com a manutenção anual: R${manuAnual:F2}");

            StreamWriter sw = new StreamWriter("resultado.txt", false, Encoding.ASCII);
            sw.WriteLine($"faturamento anual: R${fatAnual:F2}");
            sw.WriteLine($"valor ganho com multas no mes: R${mulMes:F2}");
            sw.WriteLine($"valor gasto com a manutencao anual: R${manuAnual:F2}");
            sw.Close();
        }
    }
}
