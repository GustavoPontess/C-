namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Faça um algoritmo que leia um vetor N[20]. A seguir, encontre o menor elemento do
            // vetor N e a sua posição dentro do vetor, mostrando: “O menor elemento de N é”, M, “e sua 
            // posição dentro do vetor é:”,P.

            //Declarando variaveis
            int tV = 20, M = 0, P = 0;
            int[] N = new int[tV];
            //int[] valores = new int[20]{10,2,30,24,33,53,23,55,38,10,22,34,1,66,73,88,39,29,43,39};
            for (int i = 0; i < tV; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° valor:");
                N[i] = int.Parse(Console.ReadLine()!);
                //N[i] = valores[i];
                if (i == 0)
                {
                    M = N[i];
                    P = i;
                }
                if(M>N[i]){
                    M = N[i];
                    P=i;
                }
            }
            Console.WriteLine($"O menor elemento de N é: {M}, e sua posição dentro do vetor é: {P}");                                                         
        }
    }
}