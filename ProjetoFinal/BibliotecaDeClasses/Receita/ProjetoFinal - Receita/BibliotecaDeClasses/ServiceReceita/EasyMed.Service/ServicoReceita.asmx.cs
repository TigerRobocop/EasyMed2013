using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServiceReceita.EasyMed.Negocio;
using BibliotecaDeClasses;

namespace ServiceReceita.EasyMed.Service
{
    /// <summary>
    /// Summary description for ServicoReceita
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicoReceita : System.Web.Services.WebService
    {

        [WebMethod]
        public int CadastrarReceita(Receita r)
        {
            NReceita negocio = new NReceita();

           return negocio.CadastrarReceita(r);
            
        }

        [WebMethod]
        public List<Receita> BuscarReceita(Receita filtro)
        {
            NReceita negocio = new NReceita();
            return negocio.BuscarReceita(filtro);
        }

        [WebMethod]
        public List<Medicamento> ListarMedicamentos(Medicamento filtro)
        {
            NReceita negocio = new NReceita();
            return negocio.ListarMedicamentos(filtro);
        }
        [WebMethod]
        public void alterarStatusReceita(Receita r)
        {
            NReceita negocio = new NReceita();
            negocio.alterarStatusReceita(r);
        }
    }
}
