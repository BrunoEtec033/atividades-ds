using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSimples
{
    private void btnEntrar_Click(object sender, EventArgs e)
    {
        Conexao conexao = new Conexao();
        var cmd = new MySqlCommand("SELECT * FROM tb_usuario WHERE login=@login AND senha=@senha", conexao.Conectar());
        cmd.Parameters.AddWithValue("@login", txtLogin.Text);
        cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

        var reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
            MessageBox.Show("Login bem-sucedido!");
            // Abre o menu principal
        }
        else
        {
            MessageBox.Show("Login inválido.");
        }
        conexao.Desconectar();
    }

}
