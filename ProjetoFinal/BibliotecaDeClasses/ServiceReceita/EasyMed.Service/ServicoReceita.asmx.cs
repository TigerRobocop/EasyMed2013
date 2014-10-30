using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServiceReceita.EasyMed.Negocio;
using BibliotecaDeClasses;
using ServiceReceita.Util;
using System.Data.SqlClient;

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
            int receitaID = negocio.CadastrarReceita(r);
            return receitaID;
        }

        [WebMethod]
        public List<Receita> BuscarReceita(Receita filtro)
        {
            NReceita negocio = new NReceita();
            return negocio.BuscarReceita(filtro);
        }

        [WebMethod]
        public List<ReceitaMedicamento> listarMedicamentosReceita(ReceitaMedicamento filtro)
        {
            List<ReceitaMedicamento> retorno = new List<ReceitaMedicamento>();

            const string strMedicamentosReceita = @"SELECT receita_medicamento.NUMERO_RECEITA AS numeroreceita, receita.ID_PACIENTE AS idpaciente, receita_medicamento.CODIGO_MEDICAMENTO AS codmedicamento, 
                         medicamento.Nome_Generico AS nomegenerico, medicamento.Nome_Comercial AS nomecomercial, medicamento.Composicao AS composicao, medicamento.Contra_Ind AS contraindicacao, 
                         medicamento.Dosagem AS dosagem, medicamento.Indicações AS indicacoes, medicamento.Fabricante AS fabricante, receita_medicamento.Instrucoes AS recinstrucoes, receita_medicamento.QUANTIDADE AS recquantidade, 
                         receita_medicamento.DOSAGEM AS recdosagem, receita_medicamento.TEMPO_TRATAMENTO AS rectempotratamento, consulta.NUMERO_PRONTUARIO AS numeroprontuario
                         FROM receita_medicamento INNER JOIN
                         medicamento ON receita_medicamento.CODIGO_MEDICAMENTO = medicamento.Codigo INNER JOIN
                         receita ON receita_medicamento.NUMERO_RECEITA = receita.NUMERO INNER JOIN
                         consulta ON receita.NUMERO = consulta.numero_receita
						 where receita.ID_PACIENTE = @idpaciente and receita.numero = @numeroreceita";


            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strMedicamentosReceita, conex.sqlConn);
                comm.Parameters.AddWithValue("@idpaciente", filtro.Receita.Paciente.Id);
                comm.Parameters.AddWithValue("@numeroreceita", filtro.Receita.Numero);

                SqlDataReader DbReader = comm.ExecuteReader();

                while (DbReader.Read())
                {
                    ReceitaMedicamento recMed = new ReceitaMedicamento();
                    Paciente p = new Paciente();                    
                    Receita r = new Receita();
                    Medicamento med = new Medicamento();
                    

                   

                    r.Numero = DbReader.GetInt32(DbReader.GetOrdinal("numeroreceita"));
                    p.Id = DbReader.GetInt32(DbReader.GetOrdinal("idpaciente"));
                    r.Paciente = p;
                    recMed.Receita = r;

                    med.Codigo = DbReader.GetInt32(DbReader.GetOrdinal("codmedicamento"));
                    med.NomeComercial = DbReader.GetString(DbReader.GetOrdinal("nomecomercial"));
                    med.Composicao = DbReader.GetString(DbReader.GetOrdinal("composicao"));
                    med.ContraIndicacoes = DbReader.GetString(DbReader.GetOrdinal("contraindicacao")); ;
                    med.Dosagem = DbReader.GetString(DbReader.GetOrdinal("dosagem")); ;
                    med.Indicacoes = DbReader.GetString(DbReader.GetOrdinal("indicacoes")); ;
                    med.Fabricante = DbReader.GetString(DbReader.GetOrdinal("fabricante")); ;
                    recMed.Medicamento = med;

                    recMed.Instrucoes = DbReader.GetString(DbReader.GetOrdinal("recinstrucoes")); ;
                    recMed.Quantidade = DbReader.GetString(DbReader.GetOrdinal("recquantidade")); ;
                    recMed.Dosagem = DbReader.GetString(DbReader.GetOrdinal("recdosagem")); ;
                    recMed.TempoTratamento = DbReader.GetString(DbReader.GetOrdinal("rectempotratamento")); ;


                    retorno.Add(recMed);
                }

                DbReader.Close();
                comm.Dispose();

                conex.fecharConexao();

            }
            catch (Exception ex)
            {

                throw new Exception("DAO: " + ex.Message);
            }


            return retorno;
        }

        [WebMethod]
        public List<Medicamento> ListarMedicamento(Medicamento filtro)
        {
            List<Medicamento> ListarMedicamento = new List<Medicamento>();
            string strListarMedicamento = " SELECT * FROM MEDICAMENTO where 1=1";
            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();
                string strBuscaTipo = "";
                string strBuscaNomeComercial = "";
                string strBuscaNomeGenerico = "";

                if (!string.IsNullOrEmpty(filtro.Tipo))
                {
                    strBuscaTipo = " and tipo like '%" + filtro.Tipo + "%'";
                }
                if (!string.IsNullOrEmpty(filtro.NomeComercial))
                {
                    strBuscaNomeComercial = " and Nome_Comercial like '%" + filtro.NomeComercial + "%'";
                }
                if (!string.IsNullOrEmpty(filtro.NomeGenerico))
                {
                    strBuscaNomeGenerico = " and Nome_Generico like '%" + filtro.NomeGenerico + "%'";
                }



                SqlCommand comm = new SqlCommand(strListarMedicamento + strBuscaTipo + strBuscaNomeComercial + strBuscaNomeGenerico, conex.sqlConn);

                SqlDataReader DbReader = comm.ExecuteReader();

                //lendo o resultado da receita
                while (DbReader.Read())
                {
                    Medicamento m = new Medicamento();

                    //acessando os dados


                    m.Codigo = DbReader.GetInt32(DbReader.GetOrdinal("CODIGO"));
                    m.NomeGenerico = DbReader.GetString(DbReader.GetOrdinal("NOME_GENERICO"));
                    m.NomeComercial = DbReader.GetString(DbReader.GetOrdinal("NOME_COMERCIAL"));
                    m.ContraIndicacoes = DbReader.GetString(DbReader.GetOrdinal("CONTRA_IND"));
                    m.Dosagem = DbReader.GetString(DbReader.GetOrdinal("DOSAGEM"));
                    m.Indicacoes = DbReader.GetString(DbReader.GetOrdinal("INDICAÇÕES"));
                    m.Fabricante = DbReader.GetString(DbReader.GetOrdinal("FABRICANTE"));
                    m.Tipo = DbReader.GetString(DbReader.GetOrdinal("TIPO"));
                    m.Composicao = DbReader.GetString(DbReader.GetOrdinal("COMPOSICAO"));

                    ListarMedicamento.Add(m);
                }

                DbReader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }
            return ListarMedicamento;
        }

        [WebMethod]
        public void registrarReceitaConsulta(Consulta c)
        {
            string strRegistrarReceitaConsulta = @" UPDATE CONSULTA SET NUMERO_RECEITA = @RECEITA WHERE NUMERO_PRONTUARIO = @NUMERO_PRONTUARIO ";


            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strRegistrarReceitaConsulta, conex.sqlConn);
                comm.Parameters.AddWithValue("@RECEITA", c.Receita.Numero);
                comm.Parameters.AddWithValue("@NUMERO_PRONTUARIO", c.NumeroProntuario);

                comm.ExecuteNonQuery();
                comm.Dispose();

                conex.fecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }

        }
    }
}
