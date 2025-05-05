using MySql.Data.MySqlClient;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace CadastroSimples
{


    public partial class Form1 : Form
    {
        Pessoa pessoa = new Pessoa();
        Pessoa pessoa2 = new Pessoa();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string conexaoString = "server=localhost;database=cadastrodb;uid=root;pwd=;";
                MySqlConnection conexao = new MySqlConnection(conexaoString);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro==> " + ex.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pessoa.codigo = int.Parse(codigo_txt.Text);
            pessoa.nome = nome_txt.Text;
            pessoa.email = txtEmail.Text;
            pessoa.telefone = txtTelefone.Text;
            pessoa.cpf = int.Parse(txtCPF.Text);
            MessageBox.Show("Incluido com sucesso!!");
        }

        private void consultar_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" id: {pessoa.codigo} \n Nome: {pessoa.nome} \n Email: {pessoa.email} \n Telefone: {pessoa.telefone} \n CPF:{pessoa.cpf}");
        }

        private void limpar_btn_Click(object sender, EventArgs e)
        {
            nome_txt.Text = "";
            codigo_txt.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtCPF.Text = "";

        }

        private void sair_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
