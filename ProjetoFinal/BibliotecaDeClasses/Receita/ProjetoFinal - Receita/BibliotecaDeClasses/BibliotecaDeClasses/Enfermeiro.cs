using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Enfermeiro : Pessoa
    {
        int coren;

        public int Coren
        {
            get { return coren; }
            set { coren = value; }
        }
    }
}