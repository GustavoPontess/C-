using System;
using System.Collections;

namespace Lista_de_exercicios
{
    public class Pilha
    {
        private Stack _S1;

        public Pilha()
        {
            _S1 = new Stack(); // Pilha
        }
        public Pilha(int num)
        {
            _S1 = new Stack(num); // Pilha
        }
        public void Inserir(int num)
        {
            _S1.Push(num);
        }
        public void Inserir(string num)
        {
            _S1.Push(num);
        }
        public void Inserir(ArrayList num)
        {
            foreach (var item in num)
            {
                _S1.Push(item);
            }
        }
        public int SomaElementos()
        {
            try
            {
                int soma = 0;
                foreach (var item in _S1)
                {
                    soma += (int)item;
                }
                return soma;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return -1;
            }
        }
        public void RemoveAll(int num)
        {
            Stack AuxStack = new Stack();
            foreach (var item in _S1)
            {
                if (num != (int)item)
                {
                    AuxStack.Push(item);
                }
            }
            _S1 = AuxStack;
        }
        public void ContOcorrencia(int num)
        {
            int cont = 0;
            foreach (var item in _S1)
            {
                if (num == (int)item)
                {
                    cont++;
                }
            }
            Console.WriteLine($"Hã {cont} ocorrencias do numero {num} na coleção.");
        }
        public float MediaAritmetica(int soma)
        {
            return soma / _S1.Count;
        }
        public void Imprimir()
        {
            foreach (var num in _S1)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }
        public void ImprimirRevForeach()
        {
            // Cast(type) converte cada elemento do array do tipo objeto para o tipo especificado.
            int[] Numeros = _S1.Cast<int>().ToArray();

            foreach (int num in Numeros.Reverse())
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }
        public void ImprimirRevSemReverse()
        {
            // Cast(type) converte cada elemento do array do tipo objeto para o tipo especificado.
            int[] Numeros = _S1.Cast<int>().ToArray();

            for (int i = _S1.Count - 1; i >= 0; i--)
            {
                Console.Write($"{Numeros[i]}, ");
            }
            Console.WriteLine();
        }
        public void ImprimirImpaForeach()
        {
            int cont = 0;
            foreach (var item in _S1)
            {
                if (cont % 2 != 0)
                {
                    Console.Write($"{item}, ");
                }
                cont++;
            }
            Console.WriteLine();
        }
        public void ImprimirElementosForeach()
        {
            foreach (var item in _S1)
            {
                if ((int)item % 2 != 0)
                {
                    Console.Write($"{item}, ");
                }
            }
            Console.WriteLine();
        }
        public void ImprimirMetForeach()
        {
            int cont = 0;
            foreach (var item in _S1)
            {
                if (cont != 13)
                {
                    Console.Write($"{item}, ");
                    cont++;
                }
            }
            Console.WriteLine();
        }
        public int QuantosPositivos()
        {
            int soma = 0;
            foreach (var item in _S1)
            {
                if ((int)item > 0)
                {
                    soma++;
                }
            }
            return soma;
        }
    }
}