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

        public void AlterarConsulta()
        {

        }

        public void ExcluirConsulta(Consulta c)
        {
            DAOConsulta dados = DAOConsulta.getInstancia();
            dados.ExcluirConsulta(c);
        }

        public List<Consulta> ListarConsultas()
        {
            DAOConsulta dados = new DAOConsulta();
            return dados.ListarConsultas();
        }

    }
}