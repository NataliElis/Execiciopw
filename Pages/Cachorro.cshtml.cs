using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio
{
    public class CachorroModel : PageModel
    {
        protected string raca;

        public string Raca
        {
            get { return raca; }
            set { raca = value; }
        }
        protected string porte;

        public string Porte
        {
            get { return porte; }
            set { porte = value; }
        }
        protected int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        protected bool guia ;

        public bool Guia
        {
            get { return guia ; }
            set {  guia= value; }
        }




        public CachorroModel()
        {
            Raca = "Golden";
            Porte="Grande";
            Idade = 07;

        }
    }
}