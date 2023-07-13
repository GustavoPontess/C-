namespace Exercicio_3
{
    class Program
    {
        // 3. O código de César é uma das mais simples e conhecidas técnicas de criptografia.
        // É um tipo de substituição na qual cada letra do texto é substituída por outra, que se 
        // apresenta no alfabeto abaixo dela um número fixo de vezes. Por exemplo, com uma troca de 
        // três posições, ‘A’
        // seria substituído por ‘D’, ‘B’ se tornaria ‘E’, e assim por diante. Implemente um 
        // programa que faça uso desse Código de César (3 posições), entre com uma string e 
        // retorne a string codificada.
        // Exemplo:
        // String: a ligeira raposa marrom saltou sobre o cachorro cansado
        // Nova string: D OLJHLUD UDSRVD PDUURP VDOWRX VREUH R FDFKRUUR FDQVDGR
        static void Main(string[] args)
        {
            // int Tamanho = 10; // Numero de digitos da senha
            // string senha = string.Empty;
            // for (int i = 0; i < Tamanho; i++)
            // {
            //     Random r = new Random();
            //     int codigo = Convert.ToInt32(r.Next(48, 122).ToString());
            //     Console.WriteLine($"Codigo: {codigo}");
            //     if ((codigo >= 48 && codigo <= 57) || (codigo >= 97 && codigo <= 122))
            //     {
            //         string _char = ((char)codigo).ToString();
            //         Console.WriteLine($"char: {_char}");
            //         if (!senha.Contains(_char))
            //             senha += _char;
            //         else
            //             i--;
            //     }
            //     else i--;
            //     Console.WriteLine("===================");
            // }
            // Console.WriteLine($"senha: {senha}");
            Console.Write("Digite uma frase para ser criptografada: ");
            string palavra = Console.ReadLine()!;
            Console.Clear();
            string cesar = string.Empty;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] != ' '){
                    int letra = ((char)palavra[i]);
                    letra += 3;
                    cesar += ((char)letra).ToString();
                }else{
                    cesar += " ";
                }
            }
            // if(cesar.ToUpper() == "D OLJHLUD UDSRVD PDUURP VDOWRX VREUH R FDFKRUUR FDQVDGR"){
            //     Console.WriteLine("Deu certo");
            // }
            Console.WriteLine(@$"String:      {palavra}
Nova string: {cesar}");
        }
    }
}
