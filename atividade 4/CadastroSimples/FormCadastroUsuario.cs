using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSimples
{
    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        Conexao conexao = new Conexao();
        var cmd = new MySqlCommand("INSERT INTO tb_usuario (nome, login, senha) VALUES (@nome, @login, @senha)", conexao.Conectar());
        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
        cmd.Parameters.AddWithValue("@login", txtLogin.Text);
        cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Usuário cadastrado com sucesso!");
        conexao.Desconectar();
    }

}
