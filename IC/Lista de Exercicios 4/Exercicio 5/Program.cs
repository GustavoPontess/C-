namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Faça uma função que sorteie 3 números (entre 10 e 50) e retorne em um vetor. 
            // Depois crie um procedimento que leia as tentativas do usuário para acertar um 
            // destes números. O programa só deve parar quando o usuário acertar um número sorteado.

            leTentativa(sorteia());
        }
        //Criando uma função que retorna um vetor
        static int[] sorteia()
        {
            int numVetor = 3;
            int[] numSort = new int[numVetor];
            Random R = new Random();

            for (int i = 0; i < numVetor; i++)
            {
                numSort[i] = R.Next(10, 50);
            }
            return (numSort);
        }
        //Crinado um procedimento que ira ler as tentativas do usuario
        static void leTentativa(int[] numSort)
        {
            bool pass = true;
            // foreach (var item in numSort)
            // {
            //     Console.WriteLine(item);
            // }
            do
            {
                Console.Write("Tente acerta um dos treis numeros sorteados de 10 a 50: ");
                int num = int.Parse(Console.ReadLine()!);
                foreach (var item in numSort)
                {
                    if (num == item)
                    {
                        pass = false;
                    }
                }
                if (pass)
                {
                    Console.WriteLine("Tente outra vez");
                }
            } while (pass);
            Console.WriteLine("Parabéns!!! Você acertou o numero.");
        }
    }
}