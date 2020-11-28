using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio
{
    public class CebolaModel : PageModel
    {
        protected string cor;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        protected int peso;

        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        protected string tamanho;

        public  string Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        protected string sabor;

        public string Sabor 
        {
            get { return sabor; }
            set { sabor = value; }
        }


        public CebolaModel()
        {
            Tamanho ="Pequeno";
            Peso = 150;
            Cor = "Roxa";
            Sabor = "Suave";
        }
    }
}