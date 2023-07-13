using System;
using System.Collections;

namespace Lista_de_exercicios
{
    public class Fila
    {
        private Queue _Q1;

        public Fila()
        {
            _Q1 = new Queue(); // Fila
        }
        public Fila(int num)
        {
            _Q1 = new Queue(num); // Fila
        }
        public void Inserir(int num)
        {
            _Q1.Enqueue(num);
        }
        public void Inserir(string num)
        {
            _Q1.Enqueue(num);
        }
        public void Inserir(ArrayList num)
        {
            foreach (var item in num)
            {
                _Q1.Enqueue(item);
            }
        }
        public int SomaElementos()
        {
            try
            {
                int soma = 0;
                foreach (var item in _Q1)
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
            Queue AuxQue = new Queue();
            foreach (var item in _Q1)
            {
                if (num != (int)item)
                {
                    AuxQue.Enqueue(item);
                }
            }
            _Q1 = AuxQue;
        }
        public void ContOcorrencia(int num)
        {
            int cont = 0;
            foreach (var item in _Q1)
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
            return soma / _Q1.Count;
        }
        public void Imprimir()
        {
            foreach (var num in _Q1)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }
        public void ImprimirRevForeach()
        {
            // Cast(type) converte cada elemento do array do tipo objeto para o tipo especificado.
            int[] Numeros = _Q1.Cast<int>().ToArray();

            foreach (int num in Numeros.Reverse())
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }
        public void ImprimirRevSemReverse()
        {
            // Cast(type) converte cada elemento do array do tipo objeto para o tipo especificado.
            int[] Numeros = _Q1.Cast<int>().ToArray();

            for (int i = _Q1.Count-1; i >= 0; i--)
            {
                Console.Write($"{Numeros[i]}, ");
            }
            Console.WriteLine();
        }
        public void ImprimirImpaForeach()
        {
            int cont = 0;
            foreach (var item in _Q1)
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
            foreach (var item in _Q1)
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
            foreach (var item in _Q1)
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
            foreach (var item in _Q1)
            {
                if ((int)item > 0)
                {
                    soma ++;
                }
            }
            return soma;
        }
    }
}