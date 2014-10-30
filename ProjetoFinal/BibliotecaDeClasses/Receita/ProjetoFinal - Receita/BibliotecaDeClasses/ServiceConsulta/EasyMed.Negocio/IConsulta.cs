using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BibliotecaDeClasses;

namespace ServiceConsulta.EasyMed.Negocio
{
    interface IConsulta
    {
        void CadastrarConsulta(Consulta c);
        void AlterarConsulta();
        void ExcluirConsulta(Consulta c);
        List<Consulta> ListarConsultas();
    }
}