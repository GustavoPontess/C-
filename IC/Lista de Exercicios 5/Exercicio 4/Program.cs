namespace Exercicio_4
{
    class Program
    {
        // 4. Implemente um programa que abra o arquivo texto e conte a quantidade de caracteres ‘a’ que estão presentes 
        // nele. Imprima a quantidade na tela.
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("exemplo.txt");
            String line = sr.ReadLine()!;
            int cont = 0;
            while (line != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == 'a'|| line[i] == 'A')
                    {
                        cont++;
                    }
                }
                line = sr.ReadLine()!;
            }
            sr.Close();
            Console.WriteLine($"No arquivo temos {cont} letras A");
        }
    }
}
