using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio
{
    public class AniversarioModel : PageModel
    {
        protected string convite;

        public string Convite
        {
            get { return convite; }
            set { convite = value; }
        }
        protected int comida; 

        public int Comida
        {
            get { return comida; }
            set { comida = value; }
        }
       protected int convidados;

        public int Convidados
        {
            get { return convidados; }
            set { convidados = value; }
        }
        protected int idade;

        public int Idade
        {
            get { return idade; }
            set { idade= value; }
        }

        public AniversarioModel()
        {
            Convite ="Amigos";
            Comida =170;
            Convidados = 30;
            Idade = 43;
        }
        }
    

}