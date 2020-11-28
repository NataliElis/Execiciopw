using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio
{
    public class ViagemModel : PageModel
    {
    
            protected string transporte;

            public string Transporte
            {
                get { return transporte; }
                set { transporte = value; }
            }
            protected int pesomala;

            public int Pesomala
        {
                get { return pesomala; }
                set { pesomala = value; }
            }
            protected string data;

            public string Data
            {
                get { return data; }
                set { data = value; }
            }

            protected string local;

            public string Local
            {
                get { return local; }
                set { local = value; }
            }


            public ViagemModel()
            {
                Transporte = "Aviao";
                Pesomala =23;
            Data = "Fim do mes";
                Local = "Egito";


            }
        }
    }