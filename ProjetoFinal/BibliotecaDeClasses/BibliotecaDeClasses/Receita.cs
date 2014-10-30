using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDeClasses
{
    public class Receita
    {
        int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        Paciente paciente;

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        //responsavel??

        Medico medico;

        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        List<ReceitaMedicamento> listaMedicamentos;

        public List<ReceitaMedicamento> ListaMedicamentos
        {
            get { return listaMedicamentos; }
            set { listaMedicamentos = value; }
        }

        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        
        
    }
}