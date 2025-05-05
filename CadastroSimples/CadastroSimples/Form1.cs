using MySql.Data.MySqlClient;

namespace CadastroSimples
{
    public partial class Form1 : Form
    {
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

        }
    }
}
