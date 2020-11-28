using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Ingresso
    {
        private string tipo;
        public string Tipo { get => tipo; set => tipo = value; }
        private int valor;
        public int Valor { get => valor; set => valor = value; }
        private string cor;
        public string Cor { get => cor; set => cor = value; }
        private string material;
        public string Material { get => material; set => material = value; }

        public void Entreterimento(){}
        public void Diverção(){}
    }
}
