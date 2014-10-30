using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BibliotecaDeClasses;
using ServiceAdmin.EasyMed.Negocio;

namespace ServiceAdmin.EasyMed.Fachada
{
    public class AdminFachada : InAdmin
    {
        NAdmin negocio = new NAdmin();
        public void CadastrarMedico(Medico m,Endereco e)
        {
            negocio.CadastrarMedico(m, e);
        }

        public void ExcluirMedico(Medico m)
        {
            negocio.ExcluirMedico(m);
        }

        public List<Medico> ListarMedico()
        {
           return negocio.ListarMedico();
        }

        public List<Medico> FiltroMedico(string crm, string rg, string nome)
        {
            return negocio.FiltroMedico(crm, rg, nome);
        }
         public void EditarMedico(Medico m, Endereco e)
        {
            negocio.EditarMedico(m, e);
        }

        public List<Medico> listaMedico(int idMedico)
        {
           return negocio.listaMedico(idMedico);
        }
        public List<Endereco> listaEndereco(int idEndereco)
        {
            return negocio.listaEndereco(idEndereco);
        }
    }
}