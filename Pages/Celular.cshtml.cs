using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio
{
    public class CelularModel : PageModel
    {
        protected string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        protected string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        protected string tamanho;

        public string Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        protected bool pelicula;

        public bool Pelicula
        {
            get { return pelicula; }
            set { pelicula = value; }
        }

        public CelularModel()
        {
            Marca = "Sansung";
            Modelo = "S8";
            Tamanho = "Grande";
            Pelicula = true;
        }
    }
}