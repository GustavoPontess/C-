namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, potencia;
            numero = int.Parse(Console.ReadLine());
            potencia = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculo(numero, potencia));
        }
        static int Calculo(int numero, int potencia)
        {
            if (potencia <= 1)
            {
                return numero;
            }
            else
            {
                return Calculo(numero + numero, potencia - 1);
            }
        }
    }
}
