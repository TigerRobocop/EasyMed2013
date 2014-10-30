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

        List<Consulta> pacienteTriagem(Consulta c);

        void setMedicoConsulta(Consulta c);

        int registrarDiagnostico(Consulta c);

        void finalizarConsulta(Consulta c);

        List<Consulta> listarHistoricoConsultas(Consulta c);

        List<Medico> listarMedicosList();

        Medico loginMedico(Medico m);
    }
}