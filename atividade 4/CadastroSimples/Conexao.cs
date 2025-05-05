using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSimples
{
    using MySql.Data.MySqlClient;

    public class Conexao
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;database=db_sistema;uid=root;pwd=;");

        public MySqlConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
                conexao.Open();
            return conexao;
        }

        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
                conexao.Close();
        }
    }
}
