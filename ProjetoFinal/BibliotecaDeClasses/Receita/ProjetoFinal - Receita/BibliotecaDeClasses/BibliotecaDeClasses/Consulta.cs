using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses
{
    public class Consulta
    {
        int numeroProntuario;

        public int NumeroProntuario
        {
            get { return numeroProntuario; }
            set { numeroProntuario = value; }
        }

        Paciente paciente;

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        Medico medico;

        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        Enfermeiro enfermeiro;

        public Enfermeiro Enfermeiro
        {
            get { return enfermeiro; }
            set { enfermeiro = value; }
        }

        DadosVitais dadosVitais;

        public DadosVitais DadosVitais
        {
            get { return dadosVitais; }
            set { dadosVitais = value; }
        }

        Diagnostico diagnostico;

        public Diagnostico Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        Receita receita;

        public Receita Receita
        {
            get { return receita; }
            set { receita = value; }
        }

        DateTime dataConsulta;

        public DateTime DataConsulta
        {
            get { return dataConsulta; }
            set { dataConsulta = value; }
        }

        string observacoes;

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        int situacao;

        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
    }
}
