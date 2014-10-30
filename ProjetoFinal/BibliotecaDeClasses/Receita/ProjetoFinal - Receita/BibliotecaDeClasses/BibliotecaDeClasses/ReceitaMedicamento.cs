using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses
{
    public class ReceitaMedicamento
    {
        Medicamento medicamento;

        public Medicamento Medicamento
        {
            get { return medicamento; }
            set { medicamento = value; }
        }

        Receita receita;

        public Receita Receita
        {
            get { return receita; }
            set { receita = value; }
        }

        string instrucoes;

        public string Instrucoes
        {
            get { return instrucoes; }
            set { instrucoes = value; }
        }

        string quantidade;

        public string Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        string dosagem;

        public string Dosagem
        {
            get { return dosagem; }
            set { dosagem = value; }
        }

        string tempoTratamento;

        public string TempoTratamento
        {
            get { return tempoTratamento; }
            set { tempoTratamento = value; }
        }


    }
}
