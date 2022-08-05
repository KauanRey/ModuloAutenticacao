//namespace = pasta (lógica)
using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAutenticacao.Classes
{
    public class Conexao
    {
        public static SqlConnection _conn;

        //Propriedade Automática
        public static SqlConnection MinhaInstancia{//Chave da propriedade
            get
            {//chave de método get
                //se não existe conexão.
                if (_conn == null)
                {
                    //criar a conexão com MySQL   //nos parênteses -connection string
                    _conn = new SqlConnection(@"Server = Lab206_19\SQLEXPRESS; Database = ProjetoEstoquev; Uid = sa; Pwd = teste*123;");
                }
                //retorna a conexão
                return _conn;

            }
        }

    }
}
