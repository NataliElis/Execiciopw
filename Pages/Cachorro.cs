using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Cachorro
    {
        private string raca;
        public string Raca { get =>  raca; set => raca = value; }
        private string porte;
        public string Porte { get => porte; set => porte = value; }
        private int idade;
        public int Idade { get => idade; set => idade = value; }
        private bool guia;
        public bool Guia { get => guia; set => guia = value; }

        public void Segurança() {}
        public void Lealdade() {}
    }
}
