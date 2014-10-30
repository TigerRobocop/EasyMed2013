using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Paciente : Pessoa
    {
        string nomePai;

        public string NomePai
        {
            get { return nomePai; }
            set { nomePai = value; }
        }
        string nomeMae;

        public string NomeMae
        {
            get { return nomeMae; }
            set { nomeMae = value; }
        }

        string responsavel;

        public string Responsavel
        {
            get { return responsavel; }
            set { responsavel = value; }
        }

        string raca;

        public string Raca
        {
            get { return raca; }
            set { raca = value; }
        }
        string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}