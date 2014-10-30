using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceConsulta.EasyMed.Negocio;
using BibliotecaDeClasses;
using ServiceConsulta.Util;
using System.Data.SqlClient;

namespace ServiceConsulta.EasyMed.DAO
{
    public class DAOConsulta : IConsulta
    {
        private static DAOConsulta instancia;

        public static DAOConsulta getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DAOConsulta();
            }
            return instancia;
        }

        public void CadastrarConsulta(Consulta c)
        {
            const string strCadastrarConsulta = @" INSERT INTO CONSULTA (medico, enfermeiro, paciente, dados_vitais, data_consulta, observacoes, situacao)
                                                VALUES
                                                (@medico, @enfermeiro, @paciente, @dados_vitais, @data_consulta, @observacoes, @situacao)";

            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();


                Paciente p = new Paciente();
                Medico m = new Medico();
                Enfermeiro f = new Enfermeiro();
                DadosVitais dv = new DadosVitais();
                
                SqlCommand comm = new SqlCommand(strCadastrarConsulta, conex.sqlConn);

                comm.Parameters.AddWithValue("@medico", m.Id);
                comm.Parameters.AddWithValue("@enfermeiro", f.Id);
                comm.Parameters.AddWithValue("@paciente", p.Id);
                comm.Parameters.AddWithValue("@dados_vitais", dv.Id);
                comm.Parameters.AddWithValue("@data_consulta", c.DataConsulta);
                comm.Parameters.AddWithValue("@observacoes", c.Observacoes);
                comm.Parameters.AddWithValue("@situacao", c.Situacao);

                comm.ExecuteNonQuery();
                comm.Dispose();

                conex.fecharConexao();
                
            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }

        }

        public List<Consulta> pacienteTriagem(Consulta c)
        {
            List<Consulta> retorno = new List<Consulta>();
            const string strBuscarPacienteTriagem = @" SELECT consulta.data_consulta as dataconsulta, consulta.NUMERO_PRONTUARIO as no_prontuario, consulta.ENFERMEIRO as id_enfermeiro, enfermeiro.Nome as enfermeiro_nome, 
                                                      consulta.PACIENTE as id_paciente, paciente.Nome as paciente_nome, paciente.DATA_NASCIMENTO as datanascimento, paciente.NOME_MAE as nomemae, paciente.NOME_PAI as nomepai, paciente.sexo as sexo,
                                                     dados_vitais.ID as id_dadosvitais, dados_vitais.PRESSAO as pressao, dados_vitais.PULSO as pulso, dados_vitais.TEMPERATURA as temperatura, dados_vitais.RESPIRACAO as respiracao,
                                                     consulta.observacoes as observacoes

                                                      FROM 
                                                        consulta 
                                                      INNER JOIN 
                                                        dados_vitais ON consulta.DADOS_VITAIS = dados_vitais.ID 
                                                      INNER JOIN 
                                                        enfermeiro ON consulta.ENFERMEIRO = enfermeiro.ID 
                                                      INNER JOIN paciente ON consulta.PACIENTE = paciente.ID
                                                       WHERE consulta.situacao = 2";

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
                    con.Observacoes = DbReader.GetString(DbReader.GetOrdinal("observacoes"));

                    f.Id = DbReader.GetInt32(DbReader.GetOrdinal("id_enfermeiro"));
                    f.Nome = DbReader.GetString(DbReader.GetOrdinal("enfermeiro_nome"));
                    con.Enfermeiro = f;


                    p.Id = DbReader.GetInt32(DbReader.GetOrdinal("id_paciente"));
                    p.Nome = DbReader.GetString(DbReader.GetOrdinal("paciente_nome"));
                    p.DataNascimento = DbReader.GetDateTime(DbReader.GetOrdinal("datanascimento"));
                    p.NomeMae = DbReader.GetString(DbReader.GetOrdinal("nomemae"));
                    p.NomePai = DbReader.GetString(DbReader.GetOrdinal("nomepai"));
                    p.Sexo = DbReader.GetString(DbReader.GetOrdinal("sexo"));
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

        public void setMedicoConsulta(Consulta c)
        {
            string strSetMedico = " UPDATE CONSULTA SET Medico = @Medico WHERE Numero_prontuario = @numero_prontuario;  ";

            GerenciadorConexao conex = new GerenciadorConexao();
            conex.abrirConexao();

            SqlCommand comm = new SqlCommand(strSetMedico, conex.sqlConn);

            comm.Parameters.AddWithValue("@Medico", c.Medico.Id);
            comm.Parameters.AddWithValue("@Numero_prontuario", c.NumeroProntuario);

            comm.ExecuteNonQuery();
            comm.Dispose();

            conex.fecharConexao();
        }

        public int registrarDiagnostico(Consulta c)
        {
            //Diagnostico d = new Diagnostico();
            //c.Diagnostico = d;
            int diagnosticoID = 0;

            string strRegistarDiagnostico = @" INSERT INTO DIAGNOSTICO (INFORMACOES, DATA)
                                            VALUES (@INFORMACOES, @DATA);
                                            SELECT CAST(scope_identity() AS int); "; //pega a chave gerada neste insert


            //registrar diagnostico antes de finalizar
            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strRegistarDiagnostico, conex.sqlConn);
                comm.Parameters.AddWithValue("@INFORMACOES", c.Diagnostico.Informacoes);
                comm.Parameters.AddWithValue("@DATA", DateTime.Now);
                diagnosticoID = (Int32)comm.ExecuteScalar(); //executa a query do insert e pega a chave gerada

                comm.Dispose();

                conex.fecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }

            return diagnosticoID;
        }

        public void finalizarConsulta(Consulta c)
        {

            string strFinalizarConsulta = @" UPDATE CONSULTA SET NUMERO_RECEITA = @RECEITA, DIAGNOSTICO = @DIAGNOSTICO, SITUACAO = 4
                                            WHERE NUMERO_PRONTUARIO = @NUMERO_PRONTUARIO ";


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

        public List<Consulta> listarHistoricoConsultas(Consulta c)
        {
            List<Consulta> retorno = new List<Consulta>();
            const string strListarHistoricoConsulta = @" SELECT consulta.DATA_CONSULTA as dataconsulta, consulta.NUMERO_PRONTUARIO AS numeroprontuario, 
                                                        paciente.ID as pacienteid, paciente.Nome AS nomepaciente, medico.Nome AS nomemedico, consulta.OBSERVACOES AS obstriagem, diagnostico.Informacoes AS diagnostico,
														situacao.situacao as situacaoconsulta, receita.NUMERO as numeroreceita
                                                        FROM consulta 
                                                        INNER JOIN medico ON consulta.MEDICO = medico.ID 
                                                        INNER JOIN paciente ON consulta.PACIENTE = paciente.ID 
                                                        left JOIN diagnostico ON consulta.diagnostico = diagnostico.ID
														inner join situacao on consulta.situacao = situacao.id
														left join receita on consulta.numero_receita = receita.NUMERO
						                                where consulta.paciente = @pacienteid ;";
            //--and consulta.Situacao = 4


            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strListarHistoricoConsulta, conex.sqlConn);
                comm.Parameters.AddWithValue("@pacienteid", c.Paciente.Id);

                SqlDataReader DbReader = comm.ExecuteReader();

                while (DbReader.Read())
                {
                    Consulta con = new Consulta();
                    Medico m = new Medico();
                    Paciente p = new Paciente();
                    Diagnostico d = new Diagnostico();
                    Receita r = new Receita();

                    con.DataConsulta = DbReader.GetDateTime(DbReader.GetOrdinal("dataconsulta"));
                    con.NumeroProntuario = DbReader.GetInt32(DbReader.GetOrdinal("numeroprontuario"));
                    con.Observacoes = DbReader.GetString(DbReader.GetOrdinal("obstriagem"));
                    con.Situacao = DbReader.GetString(DbReader.GetOrdinal("situacaoconsulta"));

                    p.Id = DbReader.GetInt32(DbReader.GetOrdinal("pacienteid"));
                    p.Nome = DbReader.GetString(DbReader.GetOrdinal("nomepaciente"));
                    con.Paciente = p;

                    m.Nome = DbReader.GetString(DbReader.GetOrdinal("nomemedico"));
                    con.Medico = m;

                    if ((DbReader.IsDBNull(DbReader.GetOrdinal("diagnostico")) == true))
                    {
                        //do nothing
                    }
                    else
                    {
                        d.Informacoes = DbReader.GetString(DbReader.GetOrdinal("diagnostico"));
                        con.Diagnostico = d;

                    }

                    if ((DbReader.IsDBNull(DbReader.GetOrdinal("numeroreceita")) == true))
                    {
                        //do nothing
                    }
                    else
                    {
                        r.Numero = DbReader.GetInt32(DbReader.GetOrdinal("numeroreceita"));
                        con.Receita = r;
                    }

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

        public List<Medico> listarMedicosList()
        {
            List<Medico> retorno = new List<Medico>();
            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();
                string strMedicos = " select id, nome from medico ";

                SqlCommand comm = new SqlCommand(strMedicos, conex.sqlConn);

                SqlDataReader DbReader = comm.ExecuteReader();

                while (DbReader.Read())
                {

                    Medico m = new Medico();
                    m.Id = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                    m.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));

                    retorno.Add(m);
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

        public Medico loginMedico(Medico m)
        {
            const string strLoginMedico = " select * from medico where id = @id and usuario = @login and senha = @senha ";

            Medico retorno = new Medico();
            bool loginSucesso = false;

            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strLoginMedico, conex.sqlConn);

                comm.Parameters.AddWithValue("@id", m.Id);
                comm.Parameters.AddWithValue("@login", m.Login);
                comm.Parameters.AddWithValue("@senha", m.Senha);

                SqlDataReader DbReader = comm.ExecuteReader();

                //retorna verdadeiro se a busca tiver resultados
                while (DbReader.Read())
                {
                    loginSucesso = true;
                    Medico medicoLogin = new Medico();
                    medicoLogin.Id = DbReader.GetInt32(DbReader.GetOrdinal("id"));

                    Endereco medicoEndereco = new Endereco();
                    medicoEndereco.Id = DbReader.GetInt32(DbReader.GetOrdinal("endereco"));
                    medicoLogin.Endereco = medicoEndereco;

                    medicoLogin.Especializacao = DbReader.GetString(DbReader.GetOrdinal("especializacao"));
                    medicoLogin.Telefone = DbReader.GetString(DbReader.GetOrdinal("telefone"));
                    medicoLogin.DataNascimento = DbReader.GetDateTime(DbReader.GetOrdinal("data_nascimento"));
                    medicoLogin.Rg = DbReader.GetString(DbReader.GetOrdinal("rg"));

                    medicoLogin.Crm = DbReader.GetString(DbReader.GetOrdinal("crm"));
                    medicoLogin.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));

                    retorno = medicoLogin;
                }

                if (!loginSucesso)
                {
                    throw new Exception("Login e senha não cadastrados");
                }
                //fechando o leitor
                DbReader.Close();

                //liberando a memoria
                comm.Dispose();

                //fecha a conexao
                conex.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return retorno;
        }


        //public void ExcluirConsulta(Consulta c)
        //{
        //    const string strExcluirConsulta = " DELETE FROM CONSULTA WHERE NUMERO_PRONTUARIO = @NUMERO_PRONTUARIO";
        //    try
        //    {
        //        GerenciadorConexao conex = new GerenciadorConexao();
        //        conex.abrirConexao();

        //        SqlCommand comm = new SqlCommand(strExcluirConsulta, conex.sqlConn);
        //        comm.Parameters.AddWithValue("@NUMERO_PRONTUARIO", c.NumeroProntuario);

        //        comm.ExecuteNonQuery();
        //        comm.Dispose();

        //        conex.fecharConexao();
        //    }
        //    catch (Exception ex)
        //    {
        //       throw new Exception("DAO: " + ex.Message);
        //    }
        //}

        ////public List<Consulta> ListarConsultas()
        ////{
        ////    List<Consulta> retorno = new List<Consulta>();
        ////    //FAZER OS INNER JOINS DA VIDA
        ////    string strBuscarConsultas = " SELECT * FROM CONSULTA ";
        ////    try
        ////    {
        ////        GerenciadorConexao conex = new GerenciadorConexao();
        ////        conex.abrirConexao();

        ////        SqlCommand comm = new SqlCommand(strBuscarConsultas, conex.sqlConn);

        ////        SqlDataReader DbReader = comm.ExecuteReader();

        ////        //lendo o resultado da consulta
        ////        while (DbReader.Read())
        ////        {
        ////            Consulta c = new Consulta();

        ////            //acessando os dados
        ////            DadosVitais dv = new DadosVitais();

        ////            c.NumeroProntuario = DbReader.GetInt32(DbReader.GetOrdinal("NUMERO_PRONTUARIO"));
        ////            c.Paciente.Id = DbReader.GetInt32(DbReader.GetOrdinal("PACIENTE"));
        ////            c.Medico.Id = DbReader.GetInt32(DbReader.GetOrdinal("MEDICO"));
        ////            c.Enfermeiro.Id = DbReader.GetInt32(DbReader.GetOrdinal("enfermeiro"));
                    
        ////            dv.Id = DbReader.GetInt32(DbReader.GetOrdinal("dados_vitais"));
        ////            c.DadosVitais = dv;

        ////            c.DataConsulta = DbReader.GetDateTime(DbReader.GetOrdinal("data_consulta"));
        ////            c.Observacoes = DbReader.GetString(DbReader.GetOrdinal("observacoes"));

        ////            c.Situacao = DbReader.GetString(DbReader.GetOrdinal("situacao"));                  
                  
        ////            retorno.Add(c);
        ////        }

        ////        //fechando o leitor
        ////        DbReader.Close();


        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        throw new Exception("DAO: " + ex.Message);
        //    }
        //    return retorno;
        //}
    }
}