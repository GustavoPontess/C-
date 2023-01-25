using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_4
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int x)
        {
            Quantidade += x;
        }

        public void RemoverProdutos(int x)
        {
            Quantidade -= x;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Preço: R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, Quantidade: {Quantidade}, Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}