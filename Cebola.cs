using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Cebola
    {
        private string cor;
        public string Cor { get => cor; set => cor = value; }
        private int peso;
        public int Peso { get => peso; set => peso = value; }
        private string tamanho;
        public string Tamanho { get => tamanho; set => tamanho = value; }
        private string sabor;
        public string Sabor { get => sabor; set => sabor = value; }

        public void Temperar () {}
        public void Lacrimejar () {}
    }
}
