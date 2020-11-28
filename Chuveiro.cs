using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Chuveiro
    {
        private int potencia;
        public int Potencia { get => potencia; set => potencia = value; }
        private string marca;
        public string Marca { get => marca; set => marca = value; }
        private int tencao;
        public int Tencao { get => tencao; set => tencao = value; }
        private string modelo;
        public string Modelo { get => modelo; set => modelo = value; }

        public void Higiene() { }
        public void Conforto() { }
    }
}
