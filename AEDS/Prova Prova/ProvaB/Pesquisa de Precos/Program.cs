using System;
namespace Pesquisa_de_Preco
{
    class Program
    {
        static void Main(string[] args)
        {
            int quatidade = int.Parse(Console.ReadLine());
            string estados = string.Empty;
            for (int i = 0; i < quatidade; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');
                string alcool = string.Empty;
                string gasolina = string.Empty;
                foreach (char c in dados[1])
                {
                    if (c == '.')
                    {
                        alcool += ",";
                    }
                    else
                    {
                        alcool += Convert.ToString(c);
                    }
                }
                foreach (char c in dados[2])
                {
                    if (c == '.')
                    {
                        gasolina += ",";
                    }
                    else
                    {
                        gasolina += Convert.ToString(c);
                    }
                }
                double A = Convert.ToDouble(alcool);
                double G = (Convert.ToDouble(gasolina) * 0.7);
                if (A <= G)
                {
                    estados += dados[0] + " ";
                }
            }
            if (estados != string.Empty)
            {
                string[] res = estados.Split(' ');
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("*");
            }

        }
    }
}