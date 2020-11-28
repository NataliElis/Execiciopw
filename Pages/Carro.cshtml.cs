using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio
{
    public class CarroModel : PageModel
    {
        protected string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        protected string cor;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        protected bool suporte_bicicleta;

        public bool Suporte_bicicleta
        {
            get { return suporte_bicicleta; }
            set { suporte_bicicleta = value; }
        }
        protected int potencia;

        public int Potencia
        {
            get { return potencia; }
            set { potencia= value; }
        }

        public CarroModel()
        {
            Cor = "Preto";
            Marca = "Ford";
            Potencia = 300;

        }
    }
}