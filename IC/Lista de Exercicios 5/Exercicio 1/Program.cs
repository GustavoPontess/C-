namespace Exercicio_1
{
    class Program
    {
        // 1. Faça um programa para ler uma frase e contar quantos caracteres são espaços em brancos.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase");
            string palavra = Console.ReadLine()!;
            int cont = 0;
            for (int i = 0; i < palavra.Length; i++)
            { // ira percorrer a frase
                if (palavra[i] == ' ')
                {
                    cont++;
                }
            }

            if (cont == 0)
            {
                Console.WriteLine("Não tem espaços");
            }else { 
                Console.WriteLine($"O número de espaços é: {cont}"); 
            }
        }
    }
}
