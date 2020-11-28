using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Carro
    {
        private string marca;
        public string Marca { get => marca; set => marca = value; }
         private string cor;
        public string Cor { get => cor; set => cor = value; }
        private bool suporte_bicicleta;
        public bool Suporte_bicicleta { get => suporte_bicicleta; set => suporte_bicicleta = value; }
        private int potencia;
        public int Potencia { get => potencia; set => potencia = value; }


        
        public void Trasporte() {}
        public void Agilidade() {}
    }
}
