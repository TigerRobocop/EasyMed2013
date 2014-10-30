using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BibliotecaDeClasses;
using ServiceConsulta.EasyMed.Negocio;
using ServiceConsulta.EasyMed.Fachada;
using ServiceConsulta.Util;
using System.Data.SqlClient;
using System.Data;

namespace ServiceConsulta.EasyMed.Service
{
    /// <summary>
    /// Summary description for ServiceConsulta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class ServiceConsulta : System.Web.Services.WebService
    {
        [WebMethod]
        public void CadastrarConsulta(Consulta c)
        {
            ConsultaFachada fachada = new ConsultaFachada();
            fachada.CadastrarConsulta(c);
        }

        [WebMethod]
        public List<Consulta> pacienteTriagem(Consulta c)
        {
            ConsultaFachada fachada = new ConsultaFachada();
            return fachada.pacienteTriagem(c);
        }

        [WebMethod]
        public void setMedicoConsulta(Consulta c)
        {
            ConsultaFachada fachada = new ConsultaFachada();
            fachada.setMedicoConsulta(c);
        }

        [WebMethod]
        public int registrarDiagnostico(Consulta c)
        {
            ConsultaFachada fachada = new ConsultaFachada();
            int diagnosticoID = fachada.registrarDiagnostico(c);
            return diagnosticoID;
        }

        [WebMethod]
        public void finalizarConsulta(Consulta c)
        {
            ConsultaFachada fachada = new ConsultaFachada();
            fachada.finalizarConsulta(c);
        }

        [WebMethod]
        public List<Consulta> listarHistoricoConsultas(Consulta c)
        {
            ConsultaFachada fachada = new ConsultaFachada();
            return fachada.listarHistoricoConsultas(c);
        }

        [WebMethod]
        public List<Medico> listarMedicosList()
        {
            ConsultaFachada fachada = new ConsultaFachada();
            return fachada.listarMedicosList();
        }

        [WebMethod]
        public Medico loginMedico(Medico m)
        {
            ConsultaFachada fachada = new ConsultaFachada();
            Medico retorno = new Medico();
            retorno = fachada.loginMedico(m);
            return retorno;
        }



        //[WebMethod]
        //public List<Consulta> listarConsulta()
        //{
        //    ConsultaFachada fachada = new ConsultaFachada();
        //    return fachada.ListarConsultas();
        //}



    }

}

