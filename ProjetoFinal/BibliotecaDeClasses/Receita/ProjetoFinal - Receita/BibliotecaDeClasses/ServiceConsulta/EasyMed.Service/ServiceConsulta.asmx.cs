using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BibliotecaDeClasses;
using ServiceConsulta.EasyMed.Negocio;
using ServiceConsulta.EasyMed.Fachada;
using ServiceConsulta.Util;
using System.Data.SqlClient;

namespace ServiceConsulta.EasyMed.Service
{
    /// <summary>
    /// Summary description for ServiceConsulta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class ServiceConsulta : System.Web.Services.WebService
    {
        [WebMethod]
        public void CadastrarConsulta(Consulta c)
        {
            ConsultaFachada fachada = new ConsultaFachada();
            fachada.CadastrarConsulta(c);
        }

        [WebMethod]
        public List<Consulta> listarConsulta()
        {
            ConsultaFachada fachada = new ConsultaFachada();
            return fachada.ListarConsultas();
        }

        [WebMethod]
        public List<Consulta> pacienteTriagem(Consulta c)
        {
            List<Consulta> retorno = new List<Consulta>();
            const string strBuscarPacienteTriagem = @" SELECT consulta.data_consulta as dataconsulta, consulta.NUMERO_PRONTUARIO as no_prontuario, consulta.ENFERMEIRO as id_enfermeiro, enfermeiro.Nome as enfermeiro_nome, 
                                                      consulta.PACIENTE as id_paciente, paciente.Nome as paciente_nome, paciente.DATA_NASCIMENTO as datanascimento, paciente.NOME_MAE as nomemae, paciente.NOME_PAI as nomepai, 
                                                     dados_vitais.ID as id_dadosvitais, dados_vitais.PRESSAO as pressao, dados_vitais.PULSO as pulso, dados_vitais.TEMPERATURA as temperatura, dados_vitais.RESPIRACAO as respiracao

                                                      FROM 
                                                        consulta 
                                                      INNER JOIN 
                                                        dados_vitais ON consulta.DADOS_VITAIS = dados_vitais.ID 
                                                      INNER JOIN 
                                                        enfermeiro ON consulta.ENFERMEIRO = enfermeiro.ID 
                                                      INNER JOIN paciente ON consulta.PACIENTE = paciente.ID";

            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strBuscarPacienteTriagem, conex.sqlConn);

                SqlDataReader DbReader = comm.ExecuteReader();

                while (DbReader.Read())
                {
                    Consulta con = new Consulta();
                    Enfermeiro f = new Enfermeiro();
                    Paciente p = new Paciente();
                    DadosVitais dv = new DadosVitais();

                    con.DataConsulta = DbReader.GetDateTime(DbReader.GetOrdinal("dataconsulta"));
                    con.NumeroProntuario = DbReader.GetInt32(DbReader.GetOrdinal("no_prontuario"));

                    f.Id = DbReader.GetInt32(DbReader.GetOrdinal("id_enfermeiro"));
                    f.Nome = DbReader.GetString(DbReader.GetOrdinal("enfermeiro_nome"));
                    con.Enfermeiro = f;

                    //DbReader.GetInt32(DbReader.GetOrdinal());   DbReader.GetString(DbReader.GetOrdinal()); ,, , 
                    p.Id = DbReader.GetInt32(DbReader.GetOrdinal("id_paciente"));
                    p.Nome = DbReader.GetString(DbReader.GetOrdinal("paciente_nome"));
                    p.DataNascimento = DbReader.GetDateTime(DbReader.GetOrdinal("datanascimento"));
                    p.NomeMae = DbReader.GetString(DbReader.GetOrdinal("nomemae"));
                    p.NomePai = DbReader.GetString(DbReader.GetOrdinal("nomepai"));
                    con.Paciente = p;

                    dv.Id = DbReader.GetInt32(DbReader.GetOrdinal("id_dadosvitais"));
                    dv.Pressao = DbReader.GetString(DbReader.GetOrdinal("pressao"));
                    dv.Pulso = DbReader.GetString(DbReader.GetOrdinal("pulso"));
                    dv.Respiracao = DbReader.GetString(DbReader.GetOrdinal("respiracao"));
                    dv.Temperatura = DbReader.GetString(DbReader.GetOrdinal("temperatura"));
                    con.DadosVitais = dv;
                    
                    retorno.Add(con);
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
        public void setMedicoConsulta(Consulta c){
            string strSetMedico = " UPDATE CONSULTA SET Medico = @Medico WHERE Numero_prontuario = @numero_prontuario ";

            GerenciadorConexao conex = new GerenciadorConexao();
            conex.abrirConexao();

            SqlCommand comm = new SqlCommand(strSetMedico, conex.sqlConn);

            comm.Parameters.AddWithValue("@Medico", c.Medico.Id);
            comm.Parameters.AddWithValue("@Numero_prontuario", c.NumeroProntuario);

            comm.ExecuteNonQuery();
            comm.Dispose();

            conex.fecharConexao();
        }

        [WebMethod]
        public void finalizarConsulta(Consulta c)
        {
            Diagnostico d = new Diagnostico();

            string strRegistarDiagnostico = @" INSERT INTO DIAGNOSTICO (INFORMACOES, DATA)
                                            VALUES (@INFORMACOES, @DATA);
                                            SELECT CAST(scope_identity() AS int) ";

            string strFinalizarConsulta = @" UPDATE CONSULTA SET RECEITA = @RECEITA, DIAGNOSTICO = @DIAGNOSTICO, SITUACAO = FINALIZADO
                                            WHERE NUMERO_PRONTUARIO = @NUMERO_PRONTUARIO ";


            //registrar diagnostico antes de finalizar
            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strRegistarDiagnostico, conex.sqlConn);
                comm.Parameters.AddWithValue("@INFORMACOES", d.Informacoes);
                comm.Parameters.AddWithValue("@DATA", DateTime.Now);

                comm.ExecuteNonQuery();

                d.Id = (Int32)comm.ExecuteScalar();

                comm.Dispose();

                conex.fecharConexao();

                c.Diagnostico = d;
            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }


            //agora finalizar esta consulta

            Receita r = new Receita();
            r.Numero = 1;

            c.Receita = r;

            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strFinalizarConsulta, conex.sqlConn);
                comm.Parameters.AddWithValue("@RECEITA", c.Receita.Numero);
                comm.Parameters.AddWithValue("@DIAGNOSTICO", c.Diagnostico.Id);
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
