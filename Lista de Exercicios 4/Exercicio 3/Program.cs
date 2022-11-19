namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Faça um procedimento que preencha um vetor X de 10 elementos. A seguir faça uma função 
            // que receba um vetor preenchido, teste e copie todos os valores negativos deste vetor para 
            // um novo vetor (sem deixar elementos vazios entre os valores copiados), retornando este 
            // vetor como resultado. Faça um procedimento que recebe e exibe o conteúdo de um vetor. 
            // Faça um programa que faça as devidas declarações e acione os módulos para exemplificar o seu uso.

            preencher();
            
        }
        //Criando um Procedimento que preenche um vetor X com valores aleatorios positivos e negativos que vao de 0 a 100
        static void preencher()
        {
            int vT = 10;
            int[] X = new int[vT];
            Random R = new Random();
            for (int i = 0; i < vT; i++)
            {
                if (i % 2 == 0)
                {
                    X[i] = R.Next(0, 100);
                }
                else
                {
                    X[i] = (R.Next(0, 100)) * -1;
                }
            }
            int[] vetorX = separaNumber(X, vT);
            imprimeVetor(vetorX);

        }
        //Criando uma função que recebe um vetor preenchido e ira separar os numeros positivos e negativos;
        static int[] separaNumber(int[] X, int vT){
            int y = 0, cont = 0;
            for (int i = 0; i < vT; i++){
                if(X[i]<0){
                    y++;
                }
            }
            int[] numNegativo = new int[y];
            for (int i = 0; i < vT; i++){
                if(X[i]<0){
                    numNegativo[cont] = X[i];
                    cont++;
                }
            }
            return(numNegativo);
        }
        //Criar um procedimento que recebe um vetor e exibe o seu conteudo
        static void imprimeVetor(int[] vetorX){
            for(int i = 0; i<vetorX.Length; i++){
                Console.WriteLine($"Valor: {vetorX[i]}, posição: {i+1}°");
            }
        }
    }
}