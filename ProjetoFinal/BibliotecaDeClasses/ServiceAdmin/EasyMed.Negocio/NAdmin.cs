using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BibliotecaDeClasses;
using ServiceAdmin.EasyMed.DAO;
using System.Web.UI.WebControls;

namespace ServiceAdmin.EasyMed.Negocio
{
    public class NAdmin : InAdmin
    {
        
        DAOAdmin dados = new DAOAdmin();
        public void CadastrarMedico(Medico m,Endereco e)
        {
            //VALIDANDO OS MÉDICOS
            if (m.Nome == "")
            {
                throw new Exception("Atenção campo NOME é obrigatório!");
            }
            else if (m.Crm == "")
            {
                throw new Exception("Atenção campo CRM é obrigatório!");
            }
            else if (m.Login == "")
            {
                throw new Exception("Atenção campo USUÁRIO é obrigatório!");
            }
            else if (m.Senha == "")
            {
                throw new Exception("Atenção campo SENHA é obrigatório!");
            }
            else if (m.Telefone == "")
            {
                throw new Exception("Atenção campo TELEFONE é obrigatório!");
            }
            else if (m.Especializacao == "")
            {
                throw new Exception("Atenção campo ESPECIALIZAÇÃO é obrigatório!");
            }
            else if (m.Telefone == "(  )    -")
            {
                throw new Exception("Atenção campo TELEFONE é obrigatório!");
            }
            else if (m.Telefone == "(  )    -")
            {
                throw new Exception("Atenção campo TELEFONE é obrigatório!");
            }
            else if (m.Rg == " -   -")
            {
                throw new Exception("Atenção campo RG é obrigatório!");
            }
            
            //VALIDA ENDEREÇO

            if (e.Bairro == "")
            {
                throw new Exception("Atenção campo BAIRRO é obrigatório!");
            }
            else if (e.Cidade == "")
            {
                throw new Exception("Atenção campo CIDADE é obrigatório!");
            }
            else if (e.Complemento == "")
            {
                throw new Exception("Atenção campo COMPLEMENTO é obrigatório!");
            }
            else if (e.Logradouro == "")
            {
                throw new Exception("Atenção campo LOGRADOURO é obrigatório!");
            }
            else if (e.Numero == 0)
            {
                throw new Exception("Atenção campo NÚMERO é obrigatório!");
            }
            else if (e.Pais == "")
            {
                throw new Exception("Atenção campo PAÍS é obrigatório!");
            }
            else if (e.Uf == "")
            {
                throw new Exception("Atenção campo UF é obrigatório!");
            }

                dados.CadastrarMedico(m, e);
        }


        public void ExcluirMedico(Medico m)
        {
            dados.ExcluirMedico(m);
        }

        public List<Medico> ListarMedico()
        {
           return dados.ListarMedico();
        }
        public List<Medico> FiltroMedico(string crm, string rg, string nome)
        {
               if (crm == "" && rg == "" && nome == "")
                {
                    throw new Exception("Atenção um campo é obrigatório!");
                }

            return dados.FiltroMedico(crm, rg, nome);
        }

       

        public void EditarMedico(Medico m, Endereco e)
        {
            //VALIDANDO OS MÉDICOS
            if (m.Nome == "")
            {
                throw new Exception("Atenção campo NOME é obrigatório!");
            }
            else if (m.Crm == "")
            {
                throw new Exception("Atenção campo CRM é obrigatório!");
            }
            else if (m.Login == "")
            {
                throw new Exception("Atenção campo USUÁRIO é obrigatório!");
            }
            else if (m.Senha == "")
            {
                throw new Exception("Atenção campo SENHA é obrigatório!");
            }
            else if (m.Telefone == "")
            {
                throw new Exception("Atenção campo TELEFONE é obrigatório!");
            }
            else if (m.Especializacao == "")
            {
                throw new Exception("Atenção campo ESPECIALIZAÇÃO é obrigatório!");
            }
            else if (m.Telefone == "(  )    -")
            {
                throw new Exception("Atenção campo TELEFONE é obrigatório!");
            }
            else if (m.Telefone == "(  )    -")
            {
                throw new Exception("Atenção campo TELEFONE é obrigatório!");
            }
            else if (m.Rg == " -   -")
            {
                throw new Exception("Atenção campo RG é obrigatório!");
            }

            //VALIDA ENDEREÇO

            if (e.Bairro == "")
            {
                throw new Exception("Atenção campo BAIRRO é obrigatório!");
            }
            else if (e.Cidade == "")
            {
                throw new Exception("Atenção campo CIDADE é obrigatório!");
            }
            else if (e.Complemento == "")
            {
                throw new Exception("Atenção campo COMPLEMENTO é obrigatório!");
            }
            else if (e.Logradouro == "")
            {
                throw new Exception("Atenção campo LOGRADOURO é obrigatório!");
            }
            else if (e.Numero == 0)
            {
                throw new Exception("Atenção campo NÚMERO é obrigatório!");
            }
            else if (e.Pais == "")
            {
                throw new Exception("Atenção campo PAÍS é obrigatório!");
            }
            else if (e.Uf == "")
            {
                throw new Exception("Atenção campo UF é obrigatório!");
            }

            dados.EditarMedico(m, e);
        }

        public List<Medico> listaMedico(int idMedicos)
        {
            return dados.listaMedico(idMedicos);
        }
        public List<Endereco> listaEndereco(int idEnderecos)
        {
            return dados.listaEndereco(idEnderecos);
        }
    }
}