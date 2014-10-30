using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class AnalistaEstoque : Pessoa
    {
        int matricula;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        string cpf;
        //public string cpf { get; set; }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}