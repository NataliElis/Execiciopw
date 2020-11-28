using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio
{
    public class ChuveiroModel : PageModel
    {
        protected int potencia;

        public int Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }
        protected string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        protected int tensao ;

        public int Tensao
        {
            get { return tensao ; }
            set { tensao = value; }
        }
        protected string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }




        public ChuveiroModel()

        {
            Marca = "Lorenzetti";
            Potencia = 4500;
            Tensao = 220;
            Modelo = "Maxi ducha";

        }
    }
}