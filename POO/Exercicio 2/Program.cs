namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando variavel do tipo class Pessoa
            Pessoa user1, user2;
            string result = "";
            Console.Clear();
            // Instanciando a classe e criando um objeto user usando o comando new.
            user1 = new Pessoa();
            user2 = new Pessoa();
            // Solicitando entrada de dados
            Console.WriteLine("Qual o seu nome?");
            // Acessando um atributo do objeto e atribuindo o nome da pessoa
            user1.Nome = Console.ReadLine()!;
            Console.WriteLine("Qual a sua idade?");
            user1.Idade = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Qual o seu nome?");
            // Acessando um atributo do objeto e atribuindo o nome da pessoa
            user2.Nome = Console.ReadLine()!;
            Console.WriteLine("Qual a sua idade?");
            user2.Idade = int.Parse(Console.ReadLine()!);
            if (user1.Idade > user2.Idade)
            {
                result = user1.Nome;
            }else{
                result = user2.Nome ;
            }

            Console.WriteLine($"Pessoa mais velha: {result}");
        }
    }
}