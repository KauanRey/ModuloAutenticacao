using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ModuloAutenticacao.Classes
 
{
    public class NivelDAO
    {
       public string senai;
       public int i;
      
        public string Inserir(string nome)
        { //abrindo a conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Definindo DML
            comando.CommandText = "INSERT INTO Nivel(Nome)Values(@Nome)";
            //Adicioando parâmetros contra SQL Injection
            comando.Parameters.Add(new SqlParameter("@Nome", nome));
            //Esta tudo pronto! Vamos executar o comando.
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "Dados inseridos com sucesso!";

        }
        public void Atualizar()
        {
           
          
        }
        public DataTable Pesquisar()
        {
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Definindo DML
            comando.CommandText = "select * from Nivel";

            //DataTable (banco de dados na memória)
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();
            return dataTable;
        }
        //sobrecarga de método-mesmo nome
        //everload

        public DataTable Pesquisar(string nome)
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("SELECT * from Nivel where Nome=@Nome;");
            comando.Parameters.AddWithValue("@Nome", nome);
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();
            return dataTable;
        }
        public string Deletar()
        {
            senai = "legal";
            i = 10;
            return "vou deletar um registro";
        }


    }
}
