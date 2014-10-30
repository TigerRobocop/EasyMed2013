using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Medicamento
    {
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        string nomeGenerico;

        public string NomeGenerico
        {
            get { return nomeGenerico; }
            set { nomeGenerico = value; }
        }

        string nomeComercial;

        public string NomeComercial
        {
            get { return nomeComercial; }
            set { nomeComercial = value; }
        }

        string composicao;

        public string Composicao
        {
            get { return composicao; }
            set { composicao = value; }
        }

        string contraIndicacoes;

        public string ContraIndicacoes
        {
            get { return contraIndicacoes; }
            set { contraIndicacoes = value; }
        }

        string dosagem;

        public string Dosagem
        {
            get { return dosagem; }
            set { dosagem = value; }
        }

        string indicacoes;

        public string Indicacoes
        {
            get { return indicacoes; }
            set { indicacoes = value; }
        }

        string fabricante;

        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        string tipo;


        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}