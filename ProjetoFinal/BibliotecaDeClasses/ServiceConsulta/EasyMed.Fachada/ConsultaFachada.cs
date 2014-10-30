using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceConsulta.EasyMed.Negocio;
using BibliotecaDeClasses;

namespace ServiceConsulta.EasyMed.Fachada
{
    public class ConsultaFachada : IConsulta
    {
        public void CadastrarConsulta(Consulta c)
        {
            NConsulta negocio = new NConsulta();
            negocio.CadastrarConsulta(c);
        }

        public List<Consulta> pacienteTriagem(Consulta c)
        {
            NConsulta negocio = new NConsulta();
            return negocio.pacienteTriagem(c);
        }


        public void setMedicoConsulta(Consulta c)
        {
            NConsulta negocio = new NConsulta();
            negocio.setMedicoConsulta(c);
        }


        public int registrarDiagnostico(Consulta c)
        {
            NConsulta negocio = new NConsulta();
            int diagnosticoID = negocio.registrarDiagnostico(c);
            return diagnosticoID;
        }


        public void finalizarConsulta(Consulta c)
        {
            NConsulta negocio = new NConsulta();
            negocio.finalizarConsulta(c);
        }


        public List<Consulta> listarHistoricoConsultas(Consulta c)
        {
            NConsulta negocio = new NConsulta();
            return negocio.listarHistoricoConsultas(c);
        }

        public List<Medico> listarMedicosList()
        {
            NConsulta negocio = new NConsulta();
            return negocio.listarMedicosList();
        }


        public Medico loginMedico(Medico m)
        {
            NConsulta negocio = new NConsulta();
            Medico retorno = new Medico();
            retorno = negocio.loginMedico(m);

            return retorno;
        }

        //public void ExcluirConsulta(Consulta c)
        //{

        //}

        //public List<Consulta> ListarConsultas()
        //{
        //    NConsulta negocio = new NConsulta();
        //    return negocio.ListarConsultas();
        //}
    }
}