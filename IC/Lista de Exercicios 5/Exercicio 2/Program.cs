namespace Exercicio_2
{
    class Program
    {
        // 2. Faça um programa que receba do usuário uma frase e imprima a frase sem as vogais.
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string palavra = Console.ReadLine()!;
            char[] delimitadores = new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};
            string[] strings = palavra.Split(delimitadores);
            foreach (string s in strings)
            {
                Console.Write(s);
            }
        }
    }
}
