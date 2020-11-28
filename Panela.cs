using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Panela
    {
        private string tipo;
        public string Tipo { get => tipo; set => tipo = value; }
        private bool tampa;
        public bool Tampa { get => tampa; set => tampa = value; }

        private string tamanho;
        public string Tamanho{ get => tamanho; set => tamanho = value; }
        private int peso;
        public int Peso { get => peso; set => peso = value; }

        

        public void Fritar(){}
        public void Acessar(){}
    }
}
