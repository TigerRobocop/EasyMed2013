using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Pessoa
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        Endereco endereco;

        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
    }
}