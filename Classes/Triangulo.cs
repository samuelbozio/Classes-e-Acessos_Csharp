using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Produto
    {

        private string _nome;

        public int MyProperty { get; set; }
        public double Preco { get; private set; }
        private int _quantidade;

        public Produto(string nome, double valor, int quantidade)
        {
            _nome = nome;
            Preco = valor;
            _quantidade = quantidade;
        }

       public string Nome
        {
            get => _nome;
                
            set {
                _nome = value;
            }
        }


    }
}
