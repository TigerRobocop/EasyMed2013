using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Medico : Pessoa
    {
        int crm;

        public int Crm
        {
            get { return crm; }
            set { crm = value; }
        }
        string especializacao;

        public string Especializacao
        {
            get { return especializacao; }
            set { especializacao = value; }
        }
    }
}