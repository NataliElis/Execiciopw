using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Celular
    {
        private string modelo;
        public string Modelo { get => modelo; set => modelo = value; }
        private string marca;
        public string Marca { get => marca; set => marca = value; }
        private string tamanho;
        public string Tamanho { get => tamanho; set => tamanho = value; }
        private bool pelicula;
        public bool Pelicula { get => pelicula; set => pelicula = value; }

        public void Ligar() {}
        public void Fotografar() {}
    }
}
