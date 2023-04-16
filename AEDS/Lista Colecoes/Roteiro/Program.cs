using System;
using System.Collections;
namespace Roteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Crie o ArrayList AL1 sem definir a capacidade inicial.
            Console.WriteLine("\n=============QUESTAO 1==================\n");
            ArrayList AL1 = new ArrayList();

            // 2. Imprima a capacidade e a quantidade de elementos.
            Console.WriteLine("\n=============QUESTAO 2==================\n");
            Console.WriteLine($"AL1.Capacity = {AL1.Capacity} | AL1.Count = {AL1.Count}");

            // 3. Adicione os números 19, 7 e 11.
            Console.WriteLine("\n=============QUESTAO 3==================\n");
            AL1.Add(19);
            AL1.Add(7);
            AL1.Add(11);

            // 4. Imprima a capacidade e a quantidade de elementos.
            Console.WriteLine("\n=============QUESTAO 4==================\n");
            Console.WriteLine($"AL1.Capacity = {AL1.Capacity} | AL1.Count = {AL1.Count}");

            // 5. Adicione os números 5, 7 e 17.
            Console.WriteLine("\n=============QUESTAO 5==================\n");
            // podemos inserir um array de itens de uma só vez usando o método AddRange():
            int[] numeros = new int[] { 5, 7, 17 };
            AL1.AddRange(numeros);

            // 6. Imprima a capacidade e a quantidade de elementos.
            Console.WriteLine("\n=============QUESTAO 6==================\n");
            Console.WriteLine($"AL1.Capacity = {AL1.Capacity} | AL1.Count = {AL1.Count}");
            // https://pt.stackoverflow.com/questions/419075/tamanho-de-uma-lista-de-lista-usando-list-capacity
            // Explica a relação de capacidade e quantidade de itens

            // 7. Imprima os elementos do ArrayList usando o comando foreach.
            Console.WriteLine("\n=============QUESTAO 7==================\n");
            foreach (var numero in AL1)
            {
                Console.WriteLine(numero);
            }

            // 8. Adicione o número 5 nas posições 0, 2 e 10. Ocorreu algum problema? 
            Console.WriteLine("\n=============QUESTAO 8==================\n");
            // Se sim, anote qual foi o motivo e resolva esse problema.

            // Pelo que entendi do erro o Arraylist so aceita adicionar elementos ao final da lista,
            // mesmo que tenha uma capacidade maior que a quantidade.
            AL1[0] = 5;
            AL1.Insert(2, 5); //Insere um objeto na posição passada por parâmetro. Ocorre uma exceção se a 
            // posição não existir. 

            // Adicionando elementos vazios até que a posição 10 seja alcançada
            while (AL1.Count < 11)
            {
                AL1.Add(null);
            }
            AL1[10] = 5;

            // 9. Imprima os elementos do ArrayList usando o comando for.
            Console.WriteLine("\n=============QUESTAO 9==================\n");
            for (int i = 0; i < AL1.Count; i++)
            {
                Console.WriteLine(AL1[i]);
            }

            // 10. Imprima a primeira e a última posição que contém o número 7.
            Console.WriteLine("\n=============QUESTAO 10==================\n");
            Console.WriteLine($"Primeira: {AL1.IndexOf(7)} | Ultima: {AL1.LastIndexOf(7)}");

            // 11. Imprima todas as posições que contém o número 5.
            Console.WriteLine("\n=============QUESTAO 11==================\n");
            for (int i = 0; i < AL1.Count; i++)
            {
                // (int)AL1[i] => Converter Objeto em Int com o TypeCasting 
                if (AL1[i] != null && (int)AL1[i] == 5)
                {
                    Console.WriteLine($"Posições: {i}");
                }
            }

            //12. Adicione os números 5, 23, 47, 5 e 5.
            Console.WriteLine("\n=============QUESTAO 12==================\n");
            int[] numeros1 = new int[] { 5, 23, 47, 5, 5 };
            AL1.AddRange(numeros1);

            //13. Imprima os elementos do ArrayList usando o comando while.
            Console.WriteLine("\n=============QUESTAO 13==================\n");
            int n = 0;
            while (AL1.Count > n)
            {
                Console.WriteLine(AL1[n]);
                n++;
            }

            // 14. Imprima as posições do número 5 retornada pelos métodos: BinarySeach(),
            // IndexOf() e LastIndexOf()
            Console.WriteLine("\n=============QUESTAO 14==================\n");
            Console.WriteLine($"BinarySearch: {AL1.BinarySearch(5)} | IndexOf: {AL1.IndexOf(5)} | LastIndexOf: {AL1.LastIndexOf(5)}");

            // 15. Ordene os elementos do ArrayList.
            Console.WriteLine("\n=============QUESTAO 15==================\n");
            AL1.Sort();

            // 16. Imprima os elementos do ArrayList (use o comando que você desejar).
            Console.WriteLine("\n=============QUESTAO 16==================\n");
            foreach (var item in AL1)
            {
                Console.WriteLine(item);
            }

            // 17. Remova o número 23.
            Console.WriteLine("\n=============QUESTAO 17==================\n");
            AL1.Remove(23);

            // 18. Imprima os elementos do ArrayList (use o comando que você desejar).
            Console.WriteLine("\n=============QUESTAO 18==================\n");
            foreach (var item in AL1)
            {
                Console.WriteLine(item);
            }

            // 19. Remova o elemento da posição 7.
            Console.WriteLine("\n=============QUESTAO 19==================\n");
            AL1.RemoveAt(7);

            // 20. Imprima os elementos do ArrayList (use o comando que você desejar).
            Console.WriteLine("\n=============QUESTAO 20==================\n");
            foreach (var item in AL1)
            {
                Console.WriteLine(item);
            }
            // 21. Remova os elementos das posições 2, 3 e 4.
            Console.WriteLine("\n=============QUESTAO 21==================\n");
            AL1.RemoveRange(2, 3);

            // 22. Imprima os elementos do ArrayList (use o comando que você desejar).
            Console.WriteLine("\n=============QUESTAO 22==================\n");
            foreach (var item in AL1)
            {
                Console.WriteLine(item);
            }

            // 23. Inverta os elementos do ArrayList.
            Console.WriteLine("\n=============QUESTAO 23==================\n");
            AL1.Reverse();

            // 24. Imprima os elementos do ArrayList (use o comando que você desejar).
            Console.WriteLine("\n=============QUESTAO 24==================\n");
            foreach (var item in AL1)
            {
                Console.WriteLine(item);
            }

            // 25. Remova todos os elementos do ArrayList.
            Console.WriteLine("\n=============QUESTAO 25==================\n");
            AL1.Clear();

            // 26. Imprima os elementos do ArrayList (use o comando que você desejar).
            Console.WriteLine("\n=============QUESTAO 26==================\n");
            foreach (var item in AL1)
            {
                Console.WriteLine(item);
            }

            // 27. Imprima a capacidade e a quantidade de elementos
            Console.WriteLine("\n=============QUESTAO 27==================\n");
            Console.WriteLine($"AL1.Capacity = {AL1.Capacity} | AL1.Count = {AL1.Count}");
        }
    }
}