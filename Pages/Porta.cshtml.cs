using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio
{
    public class PortaModel : PageModel
    {
        protected string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        protected int tamanho;

        public int Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        protected string cor;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        protected bool senha;

        public bool Senha

       {
            get { return senha; }
            set { senha = value; }
        }



        public PortaModel()
        { 
            Tipo = "Madeira";
            Tamanho = 72;
            Cor = "Branca";
           
        }
    }
}