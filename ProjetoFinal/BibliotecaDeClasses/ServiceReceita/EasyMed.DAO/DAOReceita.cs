using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using ServiceReceita.EasyMed.Negocio;
using ServiceReceita.Util;
using BibliotecaDeClasses;


namespace ServiceReceita.EasyMed.DAO
{
    public class DAOReceita : IReceita
    {
        private static DAOReceita instancia;

        public static DAOReceita getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DAOReceita();
            }
            return instancia;
        }

        public int CadastrarReceita (Receita r)
        {
            int receitaID = 0;
            try
            {
                GerenciadorConexao g = new GerenciadorConexao();
                g.abrirConexao();

                string strCadastrarReceita = @" INSERT INTO RECEITA 
                                        (ID_PACIENTE, ID_MEDICO)
                                         VALUES (@ID_PACIENTE, @ID_MEDICO); ";

                strCadastrarReceita += " SELECT CAST(scope_identity() AS int)";

                SqlCommand comm = new SqlCommand(strCadastrarReceita, g.sqlConn);

                //parametros 
                comm.Parameters.AddWithValue("@ID_PACIENTE",  r.Paciente.Id);
                comm.Parameters.AddWithValue("@ID_MEDICO", r.Medico.Id);
                //comm.Parameters.AddWithValue("@INSTRUCOES", r.Instrucoes);
                //comm.Parameters.AddWithValue("@QUANTIDADE", r.Quantidade);
                //comm.Parameters.AddWithValue("@DOSAGEM",r.Dosagem );
                //comm.Parameters.AddWithValue("@TEMPO_TRATAMENTO", r.TempoTratamento);

                receitaID = (Int32)comm.ExecuteScalar();
                r.Numero = receitaID;

                foreach (ReceitaMedicamento med in r.ListaMedicamentos)
                {


                    string strInserirMedicamentoreceita = @" INSERT INTO RECEITA_MEDICAMENTO (CODIGO_MEDICAMENTO, NUMERO_RECEITA, INSTRUCOES, QUANTIDADE, DOSAGEM, TEMPO_TRATAMENTO)
                                                    VALUES
                                                        (@CODIGO_MEDICAMENTO, @NUMERO_RECEITA, @INSTRUCOES, @QUANTIDADE, @DOSAGEM, @TEMPO_TRATAMENTO)";

                    SqlCommand commLista = new SqlCommand(strInserirMedicamentoreceita, g.sqlConn);

                    commLista.Parameters.AddWithValue("@CODIGO_MEDICAMENTO", med.Medicamento.Codigo);
                    commLista.Parameters.AddWithValue("@NUMERO_RECEITA", r.Numero);
                    commLista.Parameters.AddWithValue("@INSTRUCOES", med.Instrucoes);
                    commLista.Parameters.AddWithValue("@QUANTIDADE", med.Quantidade);
                    commLista.Parameters.AddWithValue("@DOSAGEM", med.Dosagem);
                    commLista.Parameters.AddWithValue("@TEMPO_TRATAMENTO", med.TempoTratamento);

                    commLista.ExecuteNonQuery();
                }

                

                comm.Dispose();
                g.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }

            return receitaID;
        }

        public void AlterarReceita(Receita r)
        {

        }

        public void ExcluirReceita(Receita r)
        {
            const string strExcluirReceita = " DELETE FROM RECEITA WHERE NUMERO = @NUMERO ";
            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strExcluirReceita, conex.sqlConn);

                comm.Parameters.AddWithValue("@NUMERO", r.Numero);

                comm.ExecuteNonQuery();
                comm.Dispose();
                conex.fecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }
        }
        public List<Receita> ListarReceitas()
        {
            List<Receita> listaReceita = new List<Receita>();

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return listaReceita;
        }

        public List<Receita> BuscarReceita(Receita filtro)
        {
            List<Receita> retorno = new List<Receita>();
            const string strSelectReceita = @"SELECT Receita.Numero as numeroReceita, 
                                            Receita.NO_PACIENTE as idPaciente, PACIENTE.Nome as nomePaciente, 
                                            Receita.NO_MEDICO as idMedico, Medico.Nome as nomeMedico
                                            FROM Medico 
                                            INNER JOIN PACIENTE ON Medico.ID = PACIENTE.ID 
                                            INNER JOIN Receita ON Medico.ID = Receita.NO_MEDICO AND PACIENTE.ID = Receita.NO_PACIENTE ";

            try
            {
                GerenciadorConexao conex = new GerenciadorConexao();
                conex.abrirConexao();

                SqlCommand comm = new SqlCommand(strSelectReceita, conex.sqlConn);

                SqlDataReader DbReader = comm.ExecuteReader();

                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Receita r = new Receita();

                    //acessando os dados

                    r.Numero = DbReader.GetInt32(DbReader.GetOrdinal("numeroReceita"));
                    r.Paciente.Id = DbReader.GetInt32(DbReader.GetOrdinal("idPaciente"));
                    r.Medico.Id = DbReader.GetInt32(DbReader.GetOrdinal("idMedico"));
                    retorno.Add(r);
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
                throw new Exception("DAO: " + ex.Message);
            }
            return retorno;
        }

    }
}