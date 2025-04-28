using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace cadastro_de_veiculos
{
    public partial class Form1 : Form
    {
        Veiculos veiculo = new Veiculos();
        Dono dono = new Dono();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1899; i < 2014; i++)
            {
                cb_ano.Items.Add(i);
            }

            string[] fabricante = { "Alfa Romeo", "Audi", "BMW", "Cross Lander", "Citroën",
"DaimlerChrysler", "Ferrari", "Fiat", "Ford", "General Motors", "Honda", "Hyundai", "Jaguar",
"Kia", "Land Rover", "Mitsubishi", "Nissan", "Peugeot", "Porsche", "Renault", "Seat",
"SsangYong", "Subaru", "Toyota", "Troller", "Volkswagen", "Volvo" };
            cb_fabricante.Items.AddRange(fabricante);

            string[] estados = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI",
"RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
            cb_estado.Items.AddRange(estados);


            cb_estadodono.Items.AddRange(estados);
        }

        private void txt_modelo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                veiculo.Modelo = txt_modelo.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo deu errado");
            }

        }

        private void cb_ano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_placa_TextChanged(object sender, EventArgs e)
        {
            veiculo.PLaca = txt_placa.Text;
        }

        private void cb_fabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            veiculo.Fabricante = cb_fabricante.Text;
        }

        private void txt_cor_TextChanged(object sender, EventArgs e)
        {
            veiculo.Cor = txt_cor.Text;
        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            veiculo.Estado = cb_estado.Text;
        }

        private void txt_cidade_TextChanged(object sender, EventArgs e)
        {
            veiculo.Cidade = txt_cidade.Text;
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "selecione a imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pic_foto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            pic_foto.Image = null;
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            dono.Nome = txt_nome.Text;
        }

        private void txt_endereco_TextChanged(object sender, EventArgs e)
        {
            dono.Endereco = txt_endereco.Text;
        }

        private void txt_bairro_TextChanged(object sender, EventArgs e)
        {
            dono.Bairro = txt_bairro.Text;
        }

        private void txt_complemento_TextChanged(object sender, EventArgs e)
        {
            dono.Complemento = txt_complemento.Text;
        }

        private void txt_cidadedono_TextChanged(object sender, EventArgs e)
        {
            dono.Cidade = txt_cidadedono.Text;
        }

        private void txt_rg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_estadodono_SelectedIndexChanged(object sender, EventArgs e)
        {
            dono.Estado = cb_estado.Text;
        }

        private void cb_nascimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            dono.Nascimento = Convert.ToInt32(cb_nascimento.Text);
        }

        private void check_veiculo_CheckedChanged(object sender, EventArgs e)
        {
            dono.Veiculo = check_veiculo.Checked;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            if (rb_masculino.Checked == true)
            {
                string sexo = "Masculino";
                dono.Sexo = sexo;
            }
            else
            {
                string sexo = "Feminino";
            }
        }

        private void btn_carregar2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "selecione a imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pic_foto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btn_limpar2_Click(object sender, EventArgs e)
        {
            pic_foto.Image = null;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpardados_Click(object sender, EventArgs e)
        {
            txt_modelo.Text = "";
            cb_ano.SelectedIndex = -1;
            txt_placa.Text = "";
            cb_fabricante.SelectedIndex = -1;
            txt_cor.Text = "";
            cb_estado.Text = "";
            txt_cidade.Text = "";



            txt_nome.Text = "";
            txt_endereco.Text = "";
            txt_bairro.Text = "";
            txt_complemento.Text = "";
            txt_cidadedono.Text = "";
            txt_rg.Text = "";
            cb_estadodono.SelectedIndex = -1;
            txt_cpf.Text = "";
            cb_nascimento.SelectedIndex = -1;
            check_veiculo.Checked = false;
            rb_feminino.Checked = false;
            rb_masculino.Checked = false;
        }

        private void btn_cadastar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro feito com sucesso");

        }

        private void btn_consultar_Click(object sender, EventArgs e)
{
    // Tratamento seguro para CPF e RG
    string cpf = string.IsNullOrWhiteSpace(txt_cpf.Text) ? "Não informado" : txt_cpf.Text;
    string rg = string.IsNullOrWhiteSpace(txt_rg.Text) ? "Não informado" : txt_rg.Text;

    // Sexo
    string sexo = rb_masculino.Checked ? "Masculino" :
                  rb_feminino.Checked ? "Feminino" : "Não informado";

    // Veículo
    string info = $"--- DADOS DO VEÍCULO ---\n" +
                  $"Modelo: {txt_modelo.Text}\n" +
                  $"Ano: {cb_ano.Text}\n" +
                  $"Placa: {txt_placa.Text}\n" +
                  $"Fabricante: {cb_fabricante.Text}\n" +
                  $"Cor: {txt_cor.Text}\n" +
                  $"Estado: {cb_estado.Text}\n" +
                  $"Cidade: {txt_cidade.Text}\n\n" +

                  $"--- DADOS DO DONO ---\n" +
                  $"Nome: {txt_nome.Text}\n" +
                  $"Endereço: {txt_endereco.Text}\n" +
                  $"Bairro: {txt_bairro.Text}\n" +
                  $"Complemento: {txt_complemento.Text}\n" +
                  $"Cidade: {txt_cidadedono.Text}\n" +
                  $"Estado: {cb_estadodono.Text}\n" +
                  $"Nascimento: {cb_nascimento.Text}\n" +
                  $"CPF: {cpf}\n" +
                  $"RG: {rg}\n" +
                  $"Sexo: {sexo}\n" +
                  $"Possui Veículo?: {(check_veiculo.Checked ? "Sim" : "Não")}";

    MessageBox.Show(info, "Consulta de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

    }
}
