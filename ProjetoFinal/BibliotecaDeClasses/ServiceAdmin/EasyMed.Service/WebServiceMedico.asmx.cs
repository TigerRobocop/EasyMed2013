using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BibliotecaDeClasses;
using ServiceAdmin.EasyMed.Fachada;

namespace ServiceAdmin.EasyMed.Service
{
    /// <summary>
    /// Summary description for WebServiceMedico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMedico : System.Web.Services.WebService
    {

        [WebMethod]
        public void CadastrarMedico(Medico m, Endereco e)
        {
            AdminFachada fachada = new AdminFachada();

            fachada.CadastrarMedico(m,e);
        }

        [WebMethod]
        public List<Medico> listarMedico()
        {
            AdminFachada fachada = new AdminFachada();
            return fachada.ListarMedico();
        }

        [WebMethod]
        public void excluirMedico(Medico m)
        {
            AdminFachada fachada = new AdminFachada();
             fachada.ExcluirMedico(m);
        }

        [WebMethod]
        public List<Medico> filtroMedico(string crm, string rg, string nome)
        {
            AdminFachada fachada = new AdminFachada();
           return fachada.FiltroMedico(crm,rg,nome);
        }
        [WebMethod]
        public void editarMedico(Medico m, Endereco e)
        {
            AdminFachada fachada = new AdminFachada();
            fachada.EditarMedico(m,e);
        }
        [WebMethod]
        public List<Medico> listaMedico(int idMedico)
        {
            AdminFachada fachada = new AdminFachada();
            return fachada.listaMedico(idMedico);
        }
        [WebMethod]
        public List<Endereco> listaEndereco(int idEndereco)
        {
            AdminFachada fachada = new AdminFachada();
            return fachada.listaEndereco(idEndereco);
        }

    }
}
