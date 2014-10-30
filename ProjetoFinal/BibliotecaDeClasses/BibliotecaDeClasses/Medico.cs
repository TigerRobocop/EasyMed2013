using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Medico : Pessoa
    {
        string crm;

        public string Crm
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

        string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}