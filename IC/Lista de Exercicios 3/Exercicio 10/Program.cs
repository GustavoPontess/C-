namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. Faça uma função que recebe a idade de um nadador por parâmetro e retorna a 
            // categoria desse nadador de acordo com a tabela abaixo.

            // Idade(anos)   Categoria
            // ==========    =========
            // 5 a 7           F
            // 8 a 10          E
            // 11 a 13         D
            // 14 a 15         C
            // 16 a 17         B
            // > 18            A

            // Faça um programa que lê a idade de um nadador e imprime a categoria retornada pela função.

            //Declarando variaveis
            int idade;
            Console.WriteLine("Digite a idade do nadador: ");
            idade = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"\n O nadador {categoria(idade)}");
        }

        //Criando um função que recebe por parametro um int e retorna uma string 
        static string categoria(int x){

            string res="esta na categoria ";
            if(x>=5 && x<=7){
                res += "F";
            }else if(x>=8 && x<=10){
                res += "E";
            }else if(x>=11 && x<=13){
                res += "D";
            }else if(x>=14 && x<=15){
                res += "C";
            }else if(x>=16 && x<=17){
                res += "B";
            }else if(x>=18){
                res += "A";  
            }else{
                res = "não possui idade minima para a competição!";
            }
            return(res);
        }
    }
}