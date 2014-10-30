using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceAdmin.EasyMed.Negocio;
using BibliotecaDeClasses;
using ServiceConsulta.Util;
using System.Data.SqlClient;
using System.Data;

namespace ServiceAdmin.EasyMed.DAO
{
    public class DAOAdmin : InAdmin
    {
        private static DAOAdmin instancia;

        public static DAOAdmin getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DAOAdmin();
            }
            return instancia;
        }

        public void CadastrarMedico(Medico m, Endereco e)
        {
            const string strCadastrarEndereco = @" INSERT INTO ENDERECO (LOGRADOURO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, UF, PAIS)
                                                VALUES
                                                (@LOGRADOURO, @NUMERO, @COMPLEMENTO, @BAIRRO, @CIDADE, @UF, @PAIS) SET @ID = SCOPE_IDENTITY()";

            const string strCadastrarMedico = @" INSERT INTO MEDICO (ENDERECO, especializacao, Telefone, DATA_NASCIMENTO, Rg, CRM, Nome,USUARIO, Senha)
                                                VALUES
                                                (@ENDERECO, @especializacao, @Telefone, @DATA_NASCIMENTO, @Rg, @CRM, @Nome,@USUARIO, @Senha)";


            int idEndereco = 0;

            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strCadastrarEndereco, conex.sqlConn);

                comm.Parameters.AddWithValue("@LOGRADOURO", e.Logradouro);
                comm.Parameters.AddWithValue("@NUMERO", e.Numero);
                comm.Parameters.AddWithValue("@COMPLEMENTO", e.Complemento);
                comm.Parameters.AddWithValue("@BAIRRO", e.Bairro);
                comm.Parameters.AddWithValue("@CIDADE", e.Cidade);
                comm.Parameters.AddWithValue("@UF", e.Uf);
                comm.Parameters.AddWithValue("@PAIS", e.Pais);
                comm.Parameters.AddWithValue("@ID", 0).Direction = ParameterDirection.Output;


                comm.ExecuteNonQuery();
                comm.Dispose();
                int id = Convert.ToInt32(comm.Parameters["@ID"].Value);
                idEndereco = id;
                conex.fecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }



            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strCadastrarMedico, conex.sqlConn);

                comm.Parameters.AddWithValue("@ENDERECO", idEndereco);
                comm.Parameters.AddWithValue("@especializacao", m.Especializacao);
                comm.Parameters.AddWithValue("@Telefone", m.Telefone);
                comm.Parameters.AddWithValue("@DATA_NASCIMENTO", m.DataNascimento);
                comm.Parameters.AddWithValue("@Rg", m.Rg);
                comm.Parameters.AddWithValue("@CRM", m.Crm);
                comm.Parameters.AddWithValue("@Nome", m.Nome);
                comm.Parameters.AddWithValue("@USUARIO", m.Login);
                comm.Parameters.AddWithValue("@Senha", m.Senha);

                comm.ExecuteNonQuery();
                comm.Dispose();

                conex.fecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + "Erro ao tentar inserir Informação no Banco" + ex.Message);
            }

        }


        public void ExcluirMedico(Medico m)
        {
            const string strExcluirConsulta = " DELETE FROM MEDICO WHERE Id = @Id";
            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strExcluirConsulta, conex.sqlConn);
                comm.Parameters.AddWithValue("@Id", m.Id);

                comm.ExecuteNonQuery();
                comm.Dispose();

                conex.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }
        }

        public List<Medico> ListarMedico()
        {
            List<Medico> retorno = new List<Medico>();

            string strBuscarMedicos = " SELECT * FROM MEDICO";
            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strBuscarMedicos, conex.sqlConn);

                SqlDataReader DbReader = comm.ExecuteReader();

                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Medico medico = new Medico();
                    Endereco endereco = new Endereco();
                    //acessando os dados
                    DadosVitais dv = new DadosVitais();

                    medico.Id = DbReader.GetInt32(DbReader.GetOrdinal("ID"));
                    endereco.Id = DbReader.GetInt32(DbReader.GetOrdinal("ENDERECO"));
                    medico.DataNascimento = DbReader.GetDateTime(DbReader.GetOrdinal("DATA_NASCIMENTO"));
                    medico.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    medico.Rg = DbReader.GetString(DbReader.GetOrdinal("Rg"));
                    medico.Telefone = DbReader.GetString(DbReader.GetOrdinal("Telefone"));
                    medico.Login = DbReader.GetString(DbReader.GetOrdinal("USUARIO"));
                    medico.Senha = DbReader.GetString(DbReader.GetOrdinal("Senha"));
                    medico.Especializacao = DbReader.GetString(DbReader.GetOrdinal("Especializacao"));
                    medico.Crm = DbReader.GetString(DbReader.GetOrdinal("CRM"));



                    retorno.Add(medico);
                }

                //fechando o leitor
                DbReader.Close();


            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }
            return retorno;
        }


        public List<Medico> FiltroMedico(string crm, string rg, string nome)
        {
            List<Medico> retorno = new List<Medico>();
            string FiltroMedicos = " SELECT * FROM MEDICO Where CRM = @CRM or Rg = @Rg or Nome = @Nome";

            Medico medico = new Medico();
            Endereco endereco = new Endereco();

            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(FiltroMedicos, conex.sqlConn);
                comm.Parameters.AddWithValue("@CRM", crm);
                comm.Parameters.AddWithValue("@Rg", rg);
                comm.Parameters.AddWithValue("@Nome", nome);
                SqlDataReader DbReader = comm.ExecuteReader();

                //lendo o resultado da consulta
                while (DbReader.Read())
                {

                    //acessando os dados
                    DadosVitais dv = new DadosVitais();

                    medico.Id = DbReader.GetInt32(DbReader.GetOrdinal("ID"));
                    endereco.Id = DbReader.GetInt32(DbReader.GetOrdinal("ENDERECO"));
                    medico.DataNascimento = DbReader.GetDateTime(DbReader.GetOrdinal("DATA_NASCIMENTO"));
                    medico.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    medico.Rg = DbReader.GetString(DbReader.GetOrdinal("Rg"));
                    medico.Telefone = DbReader.GetString(DbReader.GetOrdinal("Telefone"));
                    medico.Login = DbReader.GetString(DbReader.GetOrdinal("USUARIO"));
                    medico.Senha = DbReader.GetString(DbReader.GetOrdinal("Senha"));
                    medico.Especializacao = DbReader.GetString(DbReader.GetOrdinal("Especializacao"));
                    medico.Crm = DbReader.GetString(DbReader.GetOrdinal("CRM"));



                    retorno.Add(medico);
                }

                //fechando o leitor
                DbReader.Close();


            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }
            return retorno;
        }

        public void EditarMedico(Medico m, Endereco e)
        {

            const string strAtualizarEndereco = @" UPDATE ENDERECO SET LOGRADOURO = @LOGRADOURO, NUMERO = @NUMERO, COMPLEMENTO = @COMPLEMENTO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, UF = @UF, PAIS = @PAIS WHERE id = @id";

            const string strAtualizarMedico = @" UPDATE MEDICO SET especializacao = @especializacao, Telefone = @Telefone, DATA_NASCIMENTO = @DATA_NASCIMENTO, Rg = @Rg, CRM = @CRM, Nome = @Nome, USUARIO = @USUARIO, Senha = @Senha WHERE ID = @ID";

            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strAtualizarEndereco, conex.sqlConn);

                comm.Parameters.AddWithValue("@LOGRADOURO", e.Logradouro);
                comm.Parameters.AddWithValue("@NUMERO", e.Numero);
                comm.Parameters.AddWithValue("@COMPLEMENTO", e.Complemento);
                comm.Parameters.AddWithValue("@BAIRRO", e.Bairro);
                comm.Parameters.AddWithValue("@CIDADE", e.Cidade);
                comm.Parameters.AddWithValue("@UF", e.Uf);
                comm.Parameters.AddWithValue("@PAIS", e.Pais);
                comm.Parameters.AddWithValue("@id", e.Id);


                comm.ExecuteNonQuery();
                comm.Dispose();
                conex.fecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }



            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strAtualizarMedico, conex.sqlConn);

                
                comm.Parameters.AddWithValue("@especializacao", m.Especializacao);
                comm.Parameters.AddWithValue("@Telefone", m.Telefone);
                comm.Parameters.AddWithValue("@DATA_NASCIMENTO", m.DataNascimento);
                comm.Parameters.AddWithValue("@Rg", m.Rg);
                comm.Parameters.AddWithValue("@CRM", m.Crm);
                comm.Parameters.AddWithValue("@Nome", m.Nome);
                comm.Parameters.AddWithValue("@USUARIO", m.Login);
                comm.Parameters.AddWithValue("@Senha", m.Senha);
                comm.Parameters.AddWithValue("@ID", m.Id);

                comm.ExecuteNonQuery();
                comm.Dispose();

                conex.fecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + "Erro ao tentar atualizar Informação no Banco");
            }
        }

        //Método para Carregar os Médicos no formulário de editar
        public List<Medico> listaMedico(int idMedico)
        {
            List<Medico> retorno = new List<Medico>();

            string strBuscarMedicos = " SELECT * FROM MEDICO where ID = @ID";
            //string strBuscarEndereco = " SELECT * FROM ENDERECO where id = @id";


            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strBuscarMedicos, conex.sqlConn);
                comm.Parameters.AddWithValue("@ID", idMedico);

                SqlDataReader DbReader = comm.ExecuteReader();

                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Medico medico = new Medico();
                    Endereco endereco = new Endereco();
                    
                    //acessando os dados
                    DadosVitais dv = new DadosVitais();

                    medico.Id = DbReader.GetInt32(DbReader.GetOrdinal("ID"));
                    endereco.Id = DbReader.GetInt32(DbReader.GetOrdinal("ENDERECO"));
                    medico.Endereco = endereco;
                    medico.DataNascimento = DbReader.GetDateTime(DbReader.GetOrdinal("DATA_NASCIMENTO"));
                    medico.Nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    medico.Rg = DbReader.GetString(DbReader.GetOrdinal("Rg"));
                    medico.Telefone = DbReader.GetString(DbReader.GetOrdinal("Telefone"));
                    medico.Login = DbReader.GetString(DbReader.GetOrdinal("USUARIO"));
                    medico.Senha = DbReader.GetString(DbReader.GetOrdinal("Senha"));
                    medico.Especializacao = DbReader.GetString(DbReader.GetOrdinal("Especializacao"));
                    medico.Crm = DbReader.GetString(DbReader.GetOrdinal("CRM"));



                    retorno.Add(medico);
                }

                //fechando o leitor
                DbReader.Close();


            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }
            return retorno;
        }

        //Método para Carregar o Endereço no formulário de editar
        public List<Endereco> listaEndereco(int idEndereco)
        {
            List<Endereco> retorno = new List<Endereco>();

            
            string strBuscarEndereco = " SELECT * FROM ENDERECO where id = @id";


            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strBuscarEndereco, conex.sqlConn);
                comm.Parameters.AddWithValue("@ID", idEndereco);

                SqlDataReader DbReader = comm.ExecuteReader();

                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    
                    Endereco endereco = new Endereco();
                    //acessando os dados
                    DadosVitais dv = new DadosVitais();

                    endereco.Id = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                    endereco.Logradouro = DbReader.GetString(DbReader.GetOrdinal("LOGRADOURO"));
                    endereco.Numero = DbReader.GetInt32(DbReader.GetOrdinal("NUMERO"));
                    endereco.Complemento = DbReader.GetString(DbReader.GetOrdinal("COMPLEMENTO"));
                    endereco.Bairro = DbReader.GetString(DbReader.GetOrdinal("BAIRRO"));
                    endereco.Cidade = DbReader.GetString(DbReader.GetOrdinal("CIDADE"));
                    endereco.Uf = DbReader.GetString(DbReader.GetOrdinal("UF"));
                    endereco.Pais = DbReader.GetString(DbReader.GetOrdinal("PAIS"));
                    



                    retorno.Add(endereco);
                }

                //fechando o leitor
                DbReader.Close();


            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }
            return retorno;
        }


       
    }
}