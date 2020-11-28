using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio.Pages
{
    public class Porta
    {
        private string transporte;
        public string Transporte { get => transporte; set => transporte = value; }
        private int pesomala;
        public int Pesomala { get => pesomala; set => pesomala = value; }
        private string data;
        public string Data { get => data; set => data = value; }
        private string local;
        public string Local { get => local; set => local = value; }

        public void Experiencia() { }
        public void Turismo() { }
    }
}
