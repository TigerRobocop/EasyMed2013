using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDeClasses;

namespace ServiceAdmin.EasyMed.Negocio
{
    interface InAdmin
    {
        void CadastrarMedico(Medico m, Endereco e);
        void EditarMedico(Medico m, Endereco e);
        void ExcluirMedico(Medico m);
        List<Medico> ListarMedico();
    }
}
