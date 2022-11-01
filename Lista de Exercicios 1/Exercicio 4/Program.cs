namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Faça um algoritmo que leia o ano de nascimento de uma pessoa e calcule sua idade,
            // considerando o ano atual. Para verificar se já fez aniversário no ano atual pergunte se a
            // pessoa já fez aniversário, sendo que ela pode entrar com a informação "S"(sim) ou "N"
            // (não). Com isto é possível se ter maior precisão sobre a idade. Verifique também se a
            // pessoa já tem idade para conseguir Carteira de Habilitação (18 anos ou mais) e imprima a
            // mensagem referente a esta checagem. Imprima a idade da pessoa

            //Declarando as variaveis
            string ano, anoAtual = DateTime.Now.ToString("yyyy");
            char resposta;
            int idade = 0;

            //solicitando entrada de dados
            Console.WriteLine("Digite seu ano de nascimento:");
            //Armazenando entrada de dados
            ano = Console.ReadLine() ?? string.Empty;
            //Solicitando entrada de dados
            Console.WriteLine("já fez aniversário esse ano? S(sim) N(não)");
            //Armazenando entrada de dados
            resposta = Convert.ToChar(Console.ReadLine()!.ToUpper());

            //Usando o Switch para separar os casos
            switch (resposta)
            {
                case 'S': //caso ele tenha feito aniversario nesse ano 
                    idade = int.Parse(anoAtual) - int.Parse(ano);
                    break;
                case 'N': //caso nao tenha feito aniversario esse ano ira sutrair um ano
                    idade = int.Parse(anoAtual) - int.Parse(ano)-1;
                    break;
                default:
                    Console.WriteLine("Resposta Invalida");
                    break;
            }

            //Conferindo se e elegivel para tirar carteirae imprimindo resultado
            if(idade>=18){
                Console.WriteLine($"Sua idade é: {idade} e esta elegivel para tirar a CNH");
            }else{
                Console.WriteLine($"Sua idade é: {idade} e não esta elegivel para tirar a CNH");
            }

            //O ReadKey método aguarda, ou seja, os blocos no thread que emite o ReadKey método,
            //até que um caractere ou tecla de função seja pressionado.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}