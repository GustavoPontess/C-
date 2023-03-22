namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            palavra = Console.ReadLine();
            Console.WriteLine(Inversao(palavra, palavra.Length));
        }
        static string Inversao(string palavra, int num)
        {
            if (num <= 0)
            {
                if ((palavra.Length - 1) % 2 == 0)
                {
                    return palavra.Remove(0, (palavra.Length - 1) / 2);
                }
                return palavra.Remove(0, palavra.Length / 2);
            }
            else
            {
                string caracter = Convert.ToString(palavra[num - 1]);
                palavra += caracter;
                return Inversao(palavra, num - 1);
            }
        }
    }
}