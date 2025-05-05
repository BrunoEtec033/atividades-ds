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
            txtNome = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            nome_txt = new TextBox();
            codigo_txt = new TextBox();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            btnIncluir_Click = new Button();
            alter_btn = new Button();
            excluir_btn = new Button();
            consultar_btn = new Button();
            limpar_btn = new Button();
            sair_btn = new Button();
            consultar_lista_btn = new Button();
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
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Location = new Point(37, 163);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(44, 15);
            txtNome.TabIndex = 2;
            txtNome.Text = "E-Mail:";
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
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(452, 23);
            txtEmail.TabIndex = 5;
            // 
            // nome_txt
            // 
            nome_txt.Location = new Point(93, 122);
            nome_txt.Name = "nome_txt";
            nome_txt.Size = new Size(452, 23);
            nome_txt.TabIndex = 6;
            // 
            // codigo_txt
            // 
            codigo_txt.Location = new Point(93, 88);
            codigo_txt.Name = "codigo_txt";
            codigo_txt.Size = new Size(100, 23);
            codigo_txt.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(93, 192);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(136, 23);
            txtTelefone.TabIndex = 8;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(75, 224);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(136, 23);
            txtCPF.TabIndex = 9;
            // 
            // btnIncluir_Click
            // 
            btnIncluir_Click.Location = new Point(27, 284);
            btnIncluir_Click.Name = "btnIncluir_Click";
            btnIncluir_Click.Size = new Size(112, 53);
            btnIncluir_Click.TabIndex = 10;
            btnIncluir_Click.Text = "Incluir";
            btnIncluir_Click.UseVisualStyleBackColor = true;
            btnIncluir_Click.Click += button1_Click;
            // 
            // alter_btn
            // 
            alter_btn.Location = new Point(164, 284);
            alter_btn.Name = "alter_btn";
            alter_btn.Size = new Size(112, 53);
            alter_btn.TabIndex = 17;
            alter_btn.Text = "Alterar";
            alter_btn.UseVisualStyleBackColor = true;
            // 
            // excluir_btn
            // 
            excluir_btn.Location = new Point(433, 284);
            excluir_btn.Name = "excluir_btn";
            excluir_btn.Size = new Size(112, 53);
            excluir_btn.TabIndex = 18;
            excluir_btn.Text = "Excluir";
            excluir_btn.UseVisualStyleBackColor = true;
            // 
            // consultar_btn
            // 
            consultar_btn.Location = new Point(300, 284);
            consultar_btn.Name = "consultar_btn";
            consultar_btn.Size = new Size(112, 53);
            consultar_btn.TabIndex = 19;
            consultar_btn.Text = "Consultar";
            consultar_btn.UseVisualStyleBackColor = true;
            consultar_btn.Click += consultar_btn_Click;
            // 
            // limpar_btn
            // 
            limpar_btn.Location = new Point(300, 358);
            limpar_btn.Name = "limpar_btn";
            limpar_btn.Size = new Size(112, 53);
            limpar_btn.TabIndex = 20;
            limpar_btn.Text = "Limpar";
            limpar_btn.UseVisualStyleBackColor = true;
            limpar_btn.Click += limpar_btn_Click;
            // 
            // sair_btn
            // 
            sair_btn.Location = new Point(433, 358);
            sair_btn.Name = "sair_btn";
            sair_btn.Size = new Size(112, 53);
            sair_btn.TabIndex = 21;
            sair_btn.Text = "Sair";
            sair_btn.UseVisualStyleBackColor = true;
            sair_btn.Click += sair_btn_Click;
            // 
            // consultar_lista_btn
            // 
            consultar_lista_btn.Location = new Point(27, 358);
            consultar_lista_btn.Name = "consultar_lista_btn";
            consultar_lista_btn.Size = new Size(249, 53);
            consultar_lista_btn.TabIndex = 22;
            consultar_lista_btn.Text = "Consultar Lista de Dados";
            consultar_lista_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(consultar_lista_btn);
            Controls.Add(sair_btn);
            Controls.Add(limpar_btn);
            Controls.Add(consultar_btn);
            Controls.Add(excluir_btn);
            Controls.Add(alter_btn);
            Controls.Add(btnIncluir_Click);
            Controls.Add(txtCPF);
            Controls.Add(txtTelefone);
            Controls.Add(codigo_txt);
            Controls.Add(nome_txt);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNome);
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
        private Label txtNome;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox nome_txt;
        private TextBox codigo_txt;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private Button btnIncluir_Click;
        private Button button;
        private Button excluir_btn;
        private Button consultar_btn;
        private Button limpar_btn;
        private Button sair_btn;
        private Button consultar_lista_btn;
        private Button alter_btn;
    }
}
