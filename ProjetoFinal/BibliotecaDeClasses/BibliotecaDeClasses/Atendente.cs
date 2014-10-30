using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Atendente : Pessoa
    {
        int matricula;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}