namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Faça um procedimento que preencha 2 vetores X e Y com 10 elementos cada um 
            // (ocupando as posições de 0 a 9 em cada vetor). Faça um outro procedimento que receba 
            // dois vetores preenchidos e gera um novo vetor com os elementos desses 2 vetores intercalados 
            // de tal forma que nas posições ímpares do novo vetor estejam os elementos do primeiro vetor e
            // nas posições pares os elementos do segundo vetor recebido por parâmetro. Faça um
            // procedimento que receba e exiba o conteúdo de um vetor. Faça um programa que faça as 
            // devidas declarações e acione os módulos para exemplificar o seu uso.

            int tVetor = 10;
            int[] X = new int[tVetor];
            int[] Y = new int[tVetor];
            preencher(X, Y);
            intercalar(X, Y);
        }

        //Criando um procedimento que ira preencher dois vetores X e Y com 10 elementos
        static void preencher(int[] X, int[] Y)
        {
            Random R = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = R.Next(0, 100);
                Y[i] = R.Next(0, 100);
            }
        }
        //Criando um procedimento que gera um novo vetor com os elementos desses 2 vetores intercalados
        static void intercalar(int[] X, int[] Y)
        {
            int[] Z = new int[(X.Length + Y.Length)];
            int contX = 0, contY = 0;
            for (int i = 0; i < Z.Length; i++){
                if (i % 2 == 0){
                    Z[i] = Y[contY]; //posição pares recebendo os valores do vetor Y
                    contY++;
                }else{
                    Z[i] = X[contX]; //posições impares recebendo os valores do vetor X
                    contX++;
                }
            }
            imprimeVetor(Z);
        }
        //Criar um procedimento que recebe um vetor e exibe o seu conteudo
        static void imprimeVetor(int[] vetorX){
            for(int i = 0; i<vetorX.Length; i++){
                Console.WriteLine($"Posição: {i+1}° - {vetorX[i]}");
            }
        }
    }
}