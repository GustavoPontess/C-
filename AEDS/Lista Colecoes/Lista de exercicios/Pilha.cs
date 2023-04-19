using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Lista_de_exercicios
{
    public class Pilha
    {
        private Stack _s1;

        public Pilha()
        {
            _s1 = new Stack(); // Pilha
        }
        public Pilha(int num)
        {
            _s1 = new Stack(num); // Pilha
        }
        public void Inserir(int num){
            _s1.Push(num);
        }
        public void Inserir(string num){
            _s1.Push(num);
        }
        public void Imprimir(){
            foreach (var num in _s1)
            {
                Console.Write($"{num}, ");
            }
        }
    }
}