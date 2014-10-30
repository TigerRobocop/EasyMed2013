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

        public void AlterarConsulta()
        {
           
        }

        public void ExcluirConsulta(Consulta c)
        {
            const string strExcluirConsulta = " DELETE FROM CONSULTA WHERE NUMERO_PRONTUARIO = @NUMERO_PRONTUARIO";
            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strExcluirConsulta, conex.sqlConn);
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
    

        public List<Consulta> ListarConsultas()
        {
            List<Consulta> retorno = new List<Consulta>();
            //FAZER OS INNER JOINS DA VIDA
            string strBuscarConsultas = " SELECT * FROM CONSULTA ";
            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strBuscarConsultas, conex.sqlConn);

                SqlDataReader DbReader = comm.ExecuteReader();

                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Consulta c = new Consulta();

                    //acessando os dados
                    DadosVitais dv = new DadosVitais();

                    c.NumeroProntuario = DbReader.GetInt32(DbReader.GetOrdinal("NUMERO_PRONTUARIO"));
                    c.Paciente.Id = DbReader.GetInt32(DbReader.GetOrdinal("PACIENTE"));
                    c.Medico.Id = DbReader.GetInt32(DbReader.GetOrdinal("MEDICO"));
                    c.Enfermeiro.Id = DbReader.GetInt32(DbReader.GetOrdinal("enfermeiro"));
                    
                    dv.Id = DbReader.GetInt32(DbReader.GetOrdinal("dados_vitais"));
                    c.DadosVitais = dv;

                    c.DataConsulta = DbReader.GetDateTime(DbReader.GetOrdinal("data_consulta"));
                    c.Observacoes = DbReader.GetString(DbReader.GetOrdinal("observacoes"));

                    c.Situacao = DbReader.GetInt32(DbReader.GetOrdinal("situacao"));                  
                  
                    retorno.Add(c);
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
    
    public List<Medicamento> ListarMedicamento()
        {
            List<Medicamento> ListarMedicamento = new List<Medicamento>();
            string strListarMedicamento = " SELECT * FROM MEDICAMENTO ";
            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strListarMedicamento, conex.sqlConn);

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
                    m.Indicacoes = DbReader.GetString(DbReader.GetOrdinal("INDICACOES"));
                    m.Fabricante = DbReader.GetString(DbReader.GetOrdinal("FABRICANTE"));
                    m.Tipo = DbReader.GetString(DbReader.GetOrdinal("TIPO"));

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
    }
}