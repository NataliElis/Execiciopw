using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Aniversário
    {
        private string convite;
        public string Convite {get => convite; set => convite = value;}
        private string comida;
        public string Comida { get => comida; set => comida = value; }
        private int convidados;
        public int Convidados { get => convidados; set => convidados = value; }
        private int data;
        public int Data { get => data; set => data = value; }

        public void Festejar(){}
        public void Diverção(){}
    }
}
