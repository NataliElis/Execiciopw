using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Porta
    {
        private string tipo;
       public string Tipo { get => tipo; set => tipo = value; }
        private int tamanho;
        public int Tamanho { get => tamanho; set => tamanho = value; }
        private string cor;
        public string Cor { get => cor; set => cor = value; }
        private bool senha;
        public bool Senha { get => senha; set => senha = value; }

        public void Proteger() { }
        public void Decoração() { }
    }
}
