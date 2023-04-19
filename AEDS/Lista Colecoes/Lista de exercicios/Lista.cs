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
        private int _n;

        public Lista()
        {
            _elementos = new ArrayList();
            _n = 0;
        }

        public Lista(int num)
        {
            _elementos = new ArrayList(num);
            _n = 0;
        }

        public void Inserir(int num)
        {
            _elementos.Add(num);
        }
        public void Inserir(string num)
        {
            _elementos.Add(
                
            );
        }

        public void Imprimir()
        {
            foreach (var num in _elementos)
            {
                Console.Write($"{num}, ");
            }
        }
    }
}