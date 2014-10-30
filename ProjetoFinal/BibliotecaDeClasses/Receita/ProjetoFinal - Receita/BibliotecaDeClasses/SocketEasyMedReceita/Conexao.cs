using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using BibliotecaDeClasses;
using ServiceReceita.EasyMed.DAO;
using System.Data.OleDb;


namespace SocketEasyMedReceita
{
    class Conexao
    {
        public OdbcConnection DbConnection;
        private string nomeConexao = "ConexaoReceitaODBC";
        #region abrir conexao
        public void abrirConexao()
        {
            this.DbConnection = new OdbcConnection("DSN=" + nomeConexao);
            try
            {
                this.DbConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao conectar via ODBC " + ex.Message);
            }

        }
        #endregion
        #region fechar conexão
        public void fecharConexao()
        {
            this.DbConnection.Close();
        }
        #endregion

        //Pegando informações da Receita
        public List<Receita> select(int idReceita)
        {
            List<Receita> retorno = new List<Receita>();
            try
            {
                this.abrirConexao();
                Receita receita = new Receita();
                Medico medico = new Medico();
                Paciente paciente = new Paciente();


                OdbcCommand DbCommandReceita = DbConnection.CreateCommand();
                OdbcCommand DbCommandPaciente = DbConnection.CreateCommand();
                OdbcCommand DbCommandMedico = DbConnection.CreateCommand();
                string sqlReceita = "SELECT * FROM Receita where NUMERO = " + idReceita;
                
               // DbCommandReceita.Parameters.Add("@NUMERO",OdbcType.Int, 60);


                //Para a receita
                DbCommandReceita.CommandText = sqlReceita;
                OdbcDataReader DbReader = DbCommandReceita.ExecuteReader();
                while (DbReader.Read())
                {
                    medico.Id = DbReader.GetInt32(DbReader.GetOrdinal("ID_MEDICO"));
                    receita.Medico = medico;
                    paciente.Id = DbReader.GetInt32(DbReader.GetOrdinal("ID_PACIENTE"));
                    receita.Paciente = paciente;
                    receita.Status = DbReader.GetString(DbReader.GetOrdinal("STATUS"));
                    retorno.Add(receita);
                }
                //Para o Médico
                string sqlMedico = "SELECT * FROM Medico where ID = " + medico.Id;
                DbCommandMedico.CommandText = sqlMedico;


                OdbcDataReader DbReaderMedico = DbCommandMedico.ExecuteReader();
                while (DbReaderMedico.Read())
                {
                    medico.Nome = DbReaderMedico.GetString(DbReaderMedico.GetOrdinal("Nome"));
                    receita.Medico = medico;
                    
                    retorno.Add(receita);
                }

                //Para o Médico
                string sqlPaciente = "SELECT Nome FROM Paciente where ID = " + paciente.Id;
                DbCommandPaciente.CommandText = sqlPaciente;


                OdbcDataReader DbReaderPaciente = DbCommandPaciente.ExecuteReader();
                while (DbReaderPaciente.Read())
                {
                    paciente.Nome = DbReaderPaciente.GetString(DbReaderPaciente.GetOrdinal("Nome"));
                    receita.Paciente = paciente;

                    retorno.Add(receita);
                }

                DbReader.Close();
                DbCommandReceita.Dispose();
                DbReaderMedico.Close();
                DbCommandMedico.Dispose();
                DbReaderPaciente.Close();
                DbCommandPaciente.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao executar instrução select " + e.Message);
            }
            return retorno;
        }


        //Atualizando o Status da Receita
        public void atualizarStatus(int idReceita,string status)
        {
            
            try
            {
                this.abrirConexao();
                Receita receita = new Receita();
                Medico medico = new Medico();
                Paciente paciente = new Paciente();
                

                OdbcCommand DbCommandReceita = DbConnection.CreateCommand();
                string sqlReceita = "UPDATE Receita SET STATUS = " +"'"+status+"'" +  " where NUMERO = " + idReceita;
                

                // DbCommandReceita.Parameters.Add("@NUMERO",OdbcType.Int, 60);

                DbCommandReceita.CommandText = sqlReceita;


                OdbcDataReader DbReader = DbCommandReceita.ExecuteReader();


                DbReader.Close();

                DbCommandReceita.Dispose();
                this.fecharConexao();
            }
            catch (Exception e)
            {

                throw new Exception("Falha ao executar instrução update " + e.Message);
            }
            
        }


        

       
    }
 }

