namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questão 7
            // Faça um programa em portugol para ler uma conta corrente(sempre
            // com 3 dígitos) e imprimir seu dígito verificador que é calculado da
            // seguinte maneira:
            // a) Some o número da conta com seu inverso(CDU +UDC);
            // b) Multiplicar cada dígito da soma por sua posição, sendo que a
            // posição das centenas é 1, das dezenas é 2 e das unidades é 3;
            // c) Somar cada uma das multiplicações;
            // d) O dígito verificador é o último dígito da soma anterior.

            //Declaração de variavel
            int centena, dezena, unidade, udc, cdu, soma, multiplicacao;
            //Solicitar a entrada de dados
            Console.WriteLine("Degite um numero inteiro com 3 dígitos:");
            //Leitura da entrada de dados convertendo a entrada para um inteiro
            cdu = int.Parse(Console.ReadLine() ?? string.Empty);

            //Seperando a centena
            centena = cdu / 100;
            //Separando a dezena
            dezena = (cdu % 100) / 10;
            //Separando a unidade
            unidade = cdu % 10;
            //Invertendo o numero
            udc = unidade * 100 + dezena * 10 + centena;
            //somando cdu+udc
            soma = int.Parse(Convert.ToString(cdu+udc).Substring(Convert.ToString(cdu+udc).Length -3));
            //Seperando a centena
            centena = soma / 100;
            //Separando a dezena
            dezena = (soma % 100) / 10;
            //Separando a unidade
            unidade = soma % 10;

            multiplicacao = (centena * 1) + (dezena * 2) + (unidade * 3);

            Console.WriteLine("O digito verificador e: "+Convert.ToString(multiplicacao).Substring(Convert.ToString(multiplicacao).Length -1));
            Console.ReadKey(true);        
        }
    }
}