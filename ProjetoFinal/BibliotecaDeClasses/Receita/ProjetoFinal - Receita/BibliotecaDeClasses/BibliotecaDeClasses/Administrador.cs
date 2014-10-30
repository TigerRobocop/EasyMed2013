using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Administrador : Pessoa
    {
        string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}