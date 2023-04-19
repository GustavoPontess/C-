using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Lista_de_exercicios
{
    public class Fila
    {
        private Queue _Q1;

        public Fila(){
           _Q1 = new Queue(); // Fila
        }
        public Fila(int num){
           _Q1 = new Queue(num); // Fila
        }
        public void Inserir(int num){
            _Q1.Enqueue(num);
        }
        public void Inserir(string num){
            _Q1.Enqueue(num);
        }
        public void Imprimir(){
            foreach (var num in _Q1)
            {
                Console.Write($"{num}, ");
            }
        }
    }
}