using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BibliotecaDeClasses;

namespace ServiceReceita.EasyMed.Negocio
{
    interface IReceita
    {
        int CadastrarReceita(Receita r);
        void AlterarReceita(Receita r);
        void ExcluirReceita(Receita r);
        List<Receita> ListarReceitas();
        List<Receita> BuscarReceita(Receita r);

    }
}