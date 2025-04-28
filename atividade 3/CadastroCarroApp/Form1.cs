using System;
using System.Windows.Forms;

namespace CadastroCarroApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string ano = txtAno.Text;
            string cor = txtCor.Text;


            MessageBox.Show($"Carro cadastrado Modelo: {modelo}Marca: {marca}Ano: {ano}Cor: {cor}", "Cadastro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
