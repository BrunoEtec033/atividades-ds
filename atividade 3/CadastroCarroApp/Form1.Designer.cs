namespace CadastroCarroApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

       
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Button btnCadastrar;

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtAno = new TextBox();
            txtCor = new TextBox();
            btnCadastrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(txtAno);
            groupBox1.Controls.Add(txtCor);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Carro";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Modelo:";
            // 
            // label2
            // 
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Ano:";
            // 
            // label4
            // 
            label4.Location = new Point(20, 150);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Cor:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(126, 30);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 4;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(126, 67);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 5;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(126, 110);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 6;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(126, 147);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(100, 23);
            txtCor.TabIndex = 7;
            txtCor.TextChanged += txtCor_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(80, 220);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(350, 270);
            Controls.Add(groupBox1);
            Controls.Add(btnCadastrar);
            Name = "Form1";
            Text = "Cadastro de Carro";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
    }
}
