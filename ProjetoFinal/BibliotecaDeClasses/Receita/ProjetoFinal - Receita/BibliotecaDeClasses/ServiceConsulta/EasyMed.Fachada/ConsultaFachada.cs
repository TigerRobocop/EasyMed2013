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

        public void AlterarConsulta()
        {

        }

        public void ExcluirConsulta(Consulta c)
        {

        }

        public List<Consulta> ListarConsultas()
        {
            NConsulta negocio = new NConsulta();
            return negocio.ListarConsultas();
        }
    }
}