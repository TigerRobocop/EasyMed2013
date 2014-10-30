using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Farmaceutico : Pessoa
    {
        int cff;

        public int Cff
        {
            get { return cff; }
            set { cff = value; }
        }
    }
}