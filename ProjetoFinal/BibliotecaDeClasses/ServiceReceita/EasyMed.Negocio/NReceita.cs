using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using BibliotecaDeClasses;
using ServiceReceita.EasyMed.DAO;
using ServiceReceita.Util;



namespace ServiceReceita.EasyMed.Negocio
{
    public class NReceita : IReceita
    {
        public int CadastrarReceita(Receita r)
        {

            DAOReceita dados = DAOReceita.getInstancia();

           
            if (r.Paciente == null)
            {
                throw new Exception("Paciente deve ser informado");
            }

            
            if (r.Medico == null)
            {
                throw new Exception("Médico deve ser informado");
            }
           
            int receitaID = dados.CadastrarReceita(r);

            //List<ReceitaMedicamento> receitaParcial = null;
            //r.ListaMedicamentos = receitaParcial;

            return receitaID;

        }

        public void AlterarReceita(Receita r)
        {

        }

        public void ExcluirReceita(Receita r)
        {
            DAOReceita dados = new DAOReceita();

            if (!ReceitaExistente(r))
            {
                throw new Exception("Receita inexistente");
            }

            dados.ExcluirReceita(r);
        }
        public List<Receita> ListarReceitas()
        {
            List<Receita> listaReceita = new List<Receita>();
            
            return listaReceita;
        }

        public List<Receita> BuscarReceita(Receita filtro)
        {
            DAOReceita dados = new DAOReceita();
            return dados.BuscarReceita(filtro);

        }

        //metodo privado - ver 
        private bool ReceitaExistente(Receita r)
        {
            bool retorno = false;
            const string strReceitaExiste = " SELECT * FROM RECEITA ";

            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strReceitaExiste, conex.sqlConn);

                SqlDataReader DbReader = comm.ExecuteReader();

                while (DbReader.Read())
                {
                    retorno = true;
                    break;
                }

                DbReader.Close();
                comm.Dispose();
                conex.fecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception("Negócio: " + ex.Message);
            }
            return retorno;
        }
    }
}