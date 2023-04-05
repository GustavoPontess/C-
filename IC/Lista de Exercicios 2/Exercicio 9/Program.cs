namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, 
            // mandou digitar uma linha para cada mercadoria com o preço de
            // compra e de venda de cada uma. A última linha contém preço de compra igual a 0. Escreva um programa que:
            // a) Determine e escreva quantas mercadorias proporcionaram:
            // i) Lucro < 10%
            // ii) 10% <= lucro <= 20%
            // iii) Lucro > 20%
            // b) Determine e escreva o valor total de compra e de venda de todas as mercadorias, assim como o lucro total.  

            //variaveis
            double compra = 1, venda = 0, lucro = 0, tCompra = 0, tVenda = 0;
            int l20 = 0, l1020 = 0, l10 = 0;
            while (compra != 0)
            {
                Console.WriteLine("Digete o valor de compra e de venda respectivamente:");
                compra = double.Parse(Console.ReadLine()!);
                venda = double.Parse(Console.ReadLine()!);
                Console.Clear();
                if (compra != 0){
                    tCompra += compra;
                    tVenda += venda;
                    lucro = ((venda - compra) * 100) / venda;
                    if (lucro > 20){
                        l20++;
                    }
                    else if (lucro >= 10 && lucro <= 20){
                        l1020++;
                    }
                    else{
                        l10++;
                    }
                }
            }
            lucro = tVenda - tCompra;
            Console.WriteLine(@$"Quantidade de mercadorias com Lucro acima de 20%: {l20:F2}
Quantidade de mercadorias com Lucro entre 20% e 10%: {l1020:F2}
Quantidade de mercadorias com Lucro a baixo de 10%: {l10:F2}

Total de compra: {tCompra:F2}
Total de venda: {tVenda:F2}
Lucro total: {lucro:F2}");
        }
    }
}