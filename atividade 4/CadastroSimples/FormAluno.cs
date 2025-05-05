using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSimples
{
    private void btnIncluir_Click(object sender, EventArgs e)
    {
        Conexao conexao = new Conexao();
        var cmd = new MySqlCommand("INSERT INTO tb_aluno (nome, cpf, telefone, email) VALUES (@nome, @cpf, @telefone, @email)", conexao.Conectar());
        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
        cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Aluno cadastrado!");
        conexao.Desconectar();
    }

}
