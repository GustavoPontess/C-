using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_5
{
    public class Conta // Classe Conta
    {
        //Declarando os atributos da classe
        private int _numconta { get; private set; } //Usando Auto Properties
        private string _nome { get; set; } //Usando Auto Properties
        private double _valor;

        //Criando o construtor padrão do objeto
        public Conta() { }
        //Criando um novo construtor usando o recurso de sobrecarga
        public Conta(int numconta, string nome)
        {
            _numconta = numconta;
            _nome = nome;
        }
        //Criando um construtor usando o recurso de sobrecarga e referenciando
        //outro construtor em um construtor
        public Conta(double valor) : this(numconta, nome)
        {
            _valor = valor;
        }
    }
}