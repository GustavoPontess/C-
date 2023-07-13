using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Lista_de_exercicios
{
    public class Lista
    {
        private ArrayList _elementos;

        public Lista()
        {
            _elementos = new ArrayList();
        }

        public Lista(int num)
        {
            _elementos = new ArrayList(num);
        }

        public void Inserir(int num)
        {
            _elementos.Add(num);
        }
        public void Inserir(string num)
        {
            _elementos.Add(num);
        }
        public void Inserir(ArrayList num)
        {
            _elementos.AddRange(num);
        }

        public int SomaElementosFor()
        {
            try
            {
                int soma = 0;
                for (int i = 0; i < _elementos.Count; i++)
                {
                    soma += (int)_elementos[i];
                }
                return soma;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return -1;
            }
        }
        public int SomaElementosWhile()
        {
            int soma = 0, i = 0;
            while (i < _elementos.Count)
            {
                soma += (int)_elementos[i];
                i++;
            }
            return soma;
        }
        public int SomaElementosDoWhile()
        {
            int soma = 0, i = 0;
            do
            {
                soma += (int)_elementos[i];
                i++;
            } while (i < _elementos.Count);
            return soma;
        }

        public int SomaElementosForeach()
        {
            int soma = 0;
            foreach (var item in _elementos)
            {
                soma += (int)item;
            }
            return soma;
        }

        public void RemoveAll(int num)
        {
            while (_elementos.Contains(num))
            {
                _elementos.Remove(num);
            }
        }

        public void ContOcorrencia(int num)
        {
            ArrayList aux = new ArrayList();
            int cont = 0;
            aux = _elementos;
            while (aux.Contains(num))
            {
                aux.Remove(num);
                cont++;
            }
            Console.WriteLine($"Hã {cont} ocorrencias do numero {num} na coleção.");
        }

        public float MediaAritmetica(int soma)
        {
            return soma / _elementos.Count;
        }
        public void Imprimir()
        {
            foreach (var num in _elementos)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }
        public void ImprimirFor()
        {
            for (int i = 0; i < _elementos.Count; i++)
            {
                Console.Write($"{_elementos[i]}, ");
            }
            Console.WriteLine();
        }
        public void ImprimirReverso()
        {
            _elementos.Reverse();
            for (int i = 0; i < _elementos.Count; i++)
            {
                Console.Write($"{_elementos[i]}, ");
            }
            _elementos.Reverse();
            Console.WriteLine();
        }
        public void ImprimirImpares()
        {
            for (int i = 1; i < _elementos.Count; i += 2)
            {
                Console.Write($"{_elementos[i]}, ");
            }
            Console.WriteLine();
        }
        public void ImprimirElementosImpares()
        {
            for (int i = 0; i < _elementos.Count; i++)
            {
                if (((int)_elementos[i] % 2) != 0)
                {
                    Console.Write($"{_elementos[i]}, ");

                }
            }
            Console.WriteLine();
        }
        public void ImprimirMetade()
        {
            for (int i = 0; i < 13; i++)
            {
                Console.Write($"{_elementos[i]}, ");
            }
            Console.WriteLine();
        }

        public void ImprimirRevForeach()
        {
            _elementos.Reverse();
            foreach (var item in _elementos)
            {
                Console.Write($"{item}, ");
            }
            _elementos.Reverse();
            Console.WriteLine();
        }
        public void ImprimirRevSemReverse()
        {
            // Cast(type) converte cada elemento do array do tipo objeto para o tipo especificado.
            int[] Numeros = _elementos.Cast<int>().ToArray();

            for (int i = _elementos.Count - 1; i >= 0; i--)
            {
                Console.Write($"{Numeros[i]}, ");
            }
            Console.WriteLine();
        }
        public void ImprimirImpaForeach()
        {
            int cont = 0;
            foreach (var item in _elementos)
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
            foreach (var item in _elementos)
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
            foreach (var item in _elementos)
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
            foreach (var item in _elementos)
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