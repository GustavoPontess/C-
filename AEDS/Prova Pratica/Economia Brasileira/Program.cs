using System;
namespace Economia_Brasileira
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine()); quantidade--;
            string respostas = Console.ReadLine();
            int cont = 0;

            foreach (char caracter in respostas)
            {
                if (caracter == '1') // considera não satisfatorio
                {
                    --cont;
                }else if (caracter == '0'){ // considera satisfatorio
                    ++cont;
                }
            }

            if(cont<=0){
                Console.WriteLine("N");
            }else{
                Console.WriteLine("Y");
            }
        }
    }
}