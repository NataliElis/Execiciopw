
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio
{
    public class IngressoModel : PageModel
    {
        protected string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        protected int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        protected string cor;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        protected string material;

        public string Material
        {
            get { return material; }
            set { material = value; }
        }


        public IngressoModel()
        {
            Tipo = "Teatro";
            Valor =35;
            Cor = "Branco";
            Material = "Papel";

        }
    }
}