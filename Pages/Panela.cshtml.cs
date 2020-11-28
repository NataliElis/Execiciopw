using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio
{
    public class PanelaModel : PageModel
    {
        protected string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        protected bool tampa;

        public bool Tampa
        {
            get { return tampa; }
            set { tampa = value; }
        }
        protected string tamanho;

        public string Tamanho
        {
            get { return tamanho; }
            set { tamanho= value; }
        }
        protected int peso;

        public int Peso

        {
            get { return peso; }
            set { peso = value; }
        }



        public PanelaModel()
        {
            Tipo = "Barro";
            Tampa = true;
            Tamanho = "Grande";
            Peso =6;
          
           

        }
    }
}