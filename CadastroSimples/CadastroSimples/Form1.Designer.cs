namespace CadastroSimples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            txtNome = new TextBox();
            textBox3 = new TextBox();
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            button1 = new Button();
            button8 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 91);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 125);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 163);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "E-Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 195);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 227);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "CPF:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 23);
            textBox1.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 122);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(452, 23);
            txtNome.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(93, 192);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(136, 23);
            txtTelefone.TabIndex = 8;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(93, 224);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(136, 23);
            txtCpf.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(27, 284);
            button1.Name = "button1";
            button1.Size = new Size(112, 53);
            button1.TabIndex = 10;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button8
            // 
            button8.Location = new Point(164, 284);
            button8.Name = "button8";
            button8.Size = new Size(112, 53);
            button8.TabIndex = 17;
            button8.Text = "Alterar";
            button8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(433, 284);
            button2.Name = "button2";
            button2.Size = new Size(112, 53);
            button2.TabIndex = 18;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(300, 284);
            button3.Name = "button3";
            button3.Size = new Size(112, 53);
            button3.TabIndex = 19;
            button3.Text = "Consultar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(300, 358);
            button4.Name = "button4";
            button4.Size = new Size(112, 53);
            button4.TabIndex = 20;
            button4.Text = "Limpar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(433, 358);
            button5.Name = "button5";
            button5.Size = new Size(112, 53);
            button5.TabIndex = 21;
            button5.Text = "Sair";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(27, 358);
            button6.Name = "button6";
            button6.Size = new Size(249, 53);
            button6.TabIndex = 22;
            button6.Text = "Consultar Lista de Dados";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button8);
            Controls.Add(button1);
            Controls.Add(txtCpf);
            Controls.Add(txtTelefone);
            Controls.Add(textBox3);
            Controls.Add(txtNome);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox txtNome;
        private TextBox textBox3;
        private TextBox txtTelefone;
        private TextBox txtCpf;
        private Button button1;
        private Button button8;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
