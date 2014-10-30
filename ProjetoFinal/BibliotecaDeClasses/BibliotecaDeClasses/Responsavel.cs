using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Responsavel : Pessoa
    {
        string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        string parentesco;

        public string Parentesco
        {
            get { return parentesco; }
            set { parentesco = value; }
        }
    }
}