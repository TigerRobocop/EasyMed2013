using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Endereco
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string logradouro;

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        string pais;

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        string complemento;

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

    }
}