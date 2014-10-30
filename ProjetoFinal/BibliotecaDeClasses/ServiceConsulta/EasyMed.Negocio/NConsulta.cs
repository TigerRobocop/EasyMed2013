using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BibliotecaDeClasses;
using ServiceConsulta.EasyMed.DAO;

namespace ServiceConsulta.EasyMed.Negocio
{
    public class NConsulta : IConsulta
    {
        public void CadastrarConsulta(Consulta c)
        {
            DAOConsulta dados = DAOConsulta.getInstancia();


            //validações

            dados.CadastrarConsulta(c);
        }          


        public List<Consulta> pacienteTriagem(Consulta c)
        {
            DAOConsulta dados = DAOConsulta.getInstancia();
            return dados.pacienteTriagem(c);
        }

        
        public void setMedicoConsulta(Consulta c)
        {
            DAOConsulta dados = DAOConsulta.getInstancia();
            dados.setMedicoConsulta(c);
        }

       
        public int registrarDiagnostico(Consulta c)
        {
            DAOConsulta dados = DAOConsulta.getInstancia();
            int diagnosticoID = dados.registrarDiagnostico(c);
            return diagnosticoID;
            
        }

      
        public void finalizarConsulta(Consulta c)
        {
            DAOConsulta dados = DAOConsulta.getInstancia();
            dados.finalizarConsulta(c);
        }

       
        public List<Consulta> listarHistoricoConsultas(Consulta c)
        {
            DAOConsulta dados = DAOConsulta.getInstancia();
            List<Consulta> retorno = dados.listarHistoricoConsultas(c);
            return retorno;
        }

      
        public List<Medico> listarMedicosList()
        {
            DAOConsulta dados = DAOConsulta.getInstancia();
            List<Medico> retorno = dados.listarMedicosList();
            return retorno;
        }

        
        public Medico loginMedico(Medico m)
        {
            DAOConsulta dados = DAOConsulta.getInstancia();
            Medico retorno = new Medico();
            retorno = dados.loginMedico(m);

            return retorno;

        }

        //public void ExcluirConsulta(Consulta c)
        //{
        //    DAOConsulta dados = DAOConsulta.getInstancia();
        //    dados.ExcluirConsulta(c);
        //}

        //public List<Consulta> ListarConsultas()
        //{
        //    DAOConsulta dados = new DAOConsulta();
        //    return dados.ListarConsultas();
        //}

    }
}