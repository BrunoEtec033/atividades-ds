namespace cadastro_de_veiculos
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
            groupBox1 = new GroupBox();
            cb_estado = new ComboBox();
            cb_fabricante = new ComboBox();
            cb_ano = new ComboBox();
            txt_cidade = new TextBox();
            txt_cor = new TextBox();
            txt_placa = new TextBox();
            txt_modelo = new TextBox();
            btn_limpar = new Button();
            btn_carregar = new Button();
            pic_foto = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label18 = new Label();
            check_veiculo = new CheckBox();
            groupBox3 = new GroupBox();
            rb_feminino = new RadioButton();
            rb_masculino = new RadioButton();
            btn_limpar2 = new Button();
            btn_carregar2 = new Button();
            pic_dono = new PictureBox();
            cb_estadodono = new ComboBox();
            cb_nascimento = new ComboBox();
            txt_cpf = new TextBox();
            txt_rg = new TextBox();
            txt_cidadedono = new TextBox();
            txt_complemento = new TextBox();
            txt_bairro = new TextBox();
            txt_endereco = new TextBox();
            txt_nome = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btn_cadastar = new Button();
            btn_alterar = new Button();
            btn_consultar = new Button();
            btn_excluir = new Button();
            btn_limpardados = new Button();
            btn_sair = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_foto).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_dono).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_estado);
            groupBox1.Controls.Add(cb_fabricante);
            groupBox1.Controls.Add(cb_ano);
            groupBox1.Controls.Add(txt_cidade);
            groupBox1.Controls.Add(txt_cor);
            groupBox1.Controls.Add(txt_placa);
            groupBox1.Controls.Add(txt_modelo);
            groupBox1.Controls.Add(btn_limpar);
            groupBox1.Controls.Add(btn_carregar);
            groupBox1.Controls.Add(pic_foto);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 41);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(950, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Dados do Veiculo";
            // 
            // cb_estado
            // 
            cb_estado.FormattingEnabled = true;
            cb_estado.Items.AddRange(new object[] { "felipe ", "lopes", "luz" });
            cb_estado.Location = new Point(350, 111);
            cb_estado.Margin = new Padding(3, 2, 3, 2);
            cb_estado.Name = "cb_estado";
            cb_estado.Size = new Size(58, 23);
            cb_estado.TabIndex = 16;
            cb_estado.SelectedIndexChanged += cb_estado_SelectedIndexChanged;
            // 
            // cb_fabricante
            // 
            cb_fabricante.FormattingEnabled = true;
            cb_fabricante.Location = new Point(398, 34);
            cb_fabricante.Margin = new Padding(3, 2, 3, 2);
            cb_fabricante.Name = "cb_fabricante";
            cb_fabricante.Size = new Size(133, 23);
            cb_fabricante.TabIndex = 15;
            cb_fabricante.SelectedIndexChanged += cb_fabricante_SelectedIndexChanged;
            // 
            // cb_ano
            // 
            cb_ano.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ano.FormattingEnabled = true;
            cb_ano.Location = new Point(59, 67);
            cb_ano.Margin = new Padding(3, 2, 3, 2);
            cb_ano.Name = "cb_ano";
            cb_ano.Size = new Size(78, 23);
            cb_ano.TabIndex = 14;
            cb_ano.SelectedIndexChanged += cb_ano_SelectedIndexChanged;
            // 
            // txt_cidade
            // 
            txt_cidade.Location = new Point(503, 113);
            txt_cidade.Margin = new Padding(3, 2, 3, 2);
            txt_cidade.Name = "txt_cidade";
            txt_cidade.Size = new Size(143, 23);
            txt_cidade.TabIndex = 13;
            txt_cidade.TextChanged += txt_cidade_TextChanged;
            // 
            // txt_cor
            // 
            txt_cor.Location = new Point(343, 64);
            txt_cor.Margin = new Padding(3, 2, 3, 2);
            txt_cor.Name = "txt_cor";
            txt_cor.Size = new Size(110, 23);
            txt_cor.TabIndex = 12;
            txt_cor.TextChanged += txt_cor_TextChanged;
            // 
            // txt_placa
            // 
            txt_placa.Location = new Point(66, 104);
            txt_placa.Margin = new Padding(3, 2, 3, 2);
            txt_placa.Name = "txt_placa";
            txt_placa.Size = new Size(110, 23);
            txt_placa.TabIndex = 11;
            txt_placa.TextChanged += txt_placa_TextChanged;
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(80, 34);
            txt_modelo.Margin = new Padding(3, 2, 3, 2);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(143, 23);
            txt_modelo.TabIndex = 10;
            txt_modelo.TextChanged += txt_modelo_TextChanged;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(793, 106);
            btn_limpar.Margin = new Padding(3, 2, 3, 2);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(82, 27);
            btn_limpar.TabIndex = 9;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_carregar
            // 
            btn_carregar.Location = new Point(705, 106);
            btn_carregar.Margin = new Padding(3, 2, 3, 2);
            btn_carregar.Name = "btn_carregar";
            btn_carregar.Size = new Size(82, 27);
            btn_carregar.TabIndex = 8;
            btn_carregar.Text = "Carregar";
            btn_carregar.UseVisualStyleBackColor = true;
            btn_carregar.Click += btn_carregar_Click;
            // 
            // pic_foto
            // 
            pic_foto.BackColor = SystemColors.Control;
            pic_foto.Location = new Point(696, 16);
            pic_foto.Margin = new Padding(3, 2, 3, 2);
            pic_foto.Name = "pic_foto";
            pic_foto.Size = new Size(187, 86);
            pic_foto.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_foto.TabIndex = 7;
            pic_foto.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(446, 113);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 6;
            label8.Text = "Cidade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 113);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 5;
            label7.Text = "Estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 67);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 4;
            label6.Text = "Cor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 34);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 3;
            label5.Text = "Fabricante:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 106);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "Placa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 69);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 1;
            label3.Text = "Ano:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 34);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Modelo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 7);
            label1.Name = "label1";
            label1.Size = new Size(317, 45);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Veiculos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(check_veiculo);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(btn_limpar2);
            groupBox2.Controls.Add(btn_carregar2);
            groupBox2.Controls.Add(pic_dono);
            groupBox2.Controls.Add(cb_estadodono);
            groupBox2.Controls.Add(cb_nascimento);
            groupBox2.Controls.Add(txt_cpf);
            groupBox2.Controls.Add(txt_rg);
            groupBox2.Controls.Add(txt_cidadedono);
            groupBox2.Controls.Add(txt_complemento);
            groupBox2.Controls.Add(txt_bairro);
            groupBox2.Controls.Add(txt_endereco);
            groupBox2.Controls.Add(txt_nome);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(10, 189);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(950, 216);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Proprietario";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(7, 179);
            label18.Name = "label18";
            label18.Size = new Size(25, 15);
            label18.TabIndex = 23;
            label18.Text = "RG:";
            // 
            // check_veiculo
            // 
            check_veiculo.AutoSize = true;
            check_veiculo.Location = new Point(514, 76);
            check_veiculo.Margin = new Padding(3, 2, 3, 2);
            check_veiculo.Name = "check_veiculo";
            check_veiculo.Size = new Size(78, 19);
            check_veiculo.TabIndex = 22;
            check_veiculo.Text = "1º Veiculo";
            check_veiculo.UseVisualStyleBackColor = true;
            check_veiculo.CheckedChanged += check_veiculo_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rb_feminino);
            groupBox3.Controls.Add(rb_masculino);
            groupBox3.Location = new Point(503, 99);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(104, 70);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sexo";
            // 
            // rb_feminino
            // 
            rb_feminino.AutoSize = true;
            rb_feminino.Location = new Point(9, 40);
            rb_feminino.Margin = new Padding(3, 2, 3, 2);
            rb_feminino.Name = "rb_feminino";
            rb_feminino.Size = new Size(65, 19);
            rb_feminino.TabIndex = 23;
            rb_feminino.TabStop = true;
            rb_feminino.Text = "Femino";
            rb_feminino.UseVisualStyleBackColor = true;
            // 
            // rb_masculino
            // 
            rb_masculino.AutoSize = true;
            rb_masculino.Location = new Point(5, 20);
            rb_masculino.Margin = new Padding(3, 2, 3, 2);
            rb_masculino.Name = "rb_masculino";
            rb_masculino.Size = new Size(80, 19);
            rb_masculino.TabIndex = 22;
            rb_masculino.TabStop = true;
            rb_masculino.Text = "Masculino\r\n";
            rb_masculino.UseVisualStyleBackColor = true;
            // 
            // btn_limpar2
            // 
            btn_limpar2.Location = new Point(841, 28);
            btn_limpar2.Margin = new Padding(3, 2, 3, 2);
            btn_limpar2.Name = "btn_limpar2";
            btn_limpar2.Size = new Size(90, 35);
            btn_limpar2.TabIndex = 20;
            btn_limpar2.Text = "Limpar";
            btn_limpar2.UseVisualStyleBackColor = true;
            btn_limpar2.Click += btn_limpar2_Click;
            // 
            // btn_carregar2
            // 
            btn_carregar2.Location = new Point(841, 86);
            btn_carregar2.Margin = new Padding(3, 2, 3, 2);
            btn_carregar2.Name = "btn_carregar2";
            btn_carregar2.Size = new Size(92, 35);
            btn_carregar2.TabIndex = 19;
            btn_carregar2.Text = "Carregar";
            btn_carregar2.UseVisualStyleBackColor = true;
            btn_carregar2.Click += btn_carregar2_Click;
            // 
            // pic_dono
            // 
            pic_dono.BackColor = SystemColors.Control;
            pic_dono.Location = new Point(648, 12);
            pic_dono.Margin = new Padding(3, 2, 3, 2);
            pic_dono.Name = "pic_dono";
            pic_dono.Size = new Size(187, 146);
            pic_dono.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_dono.TabIndex = 18;
            pic_dono.TabStop = false;
            // 
            // cb_estadodono
            // 
            cb_estadodono.FormattingEnabled = true;
            cb_estadodono.Location = new Point(318, 147);
            cb_estadodono.Margin = new Padding(3, 2, 3, 2);
            cb_estadodono.Name = "cb_estadodono";
            cb_estadodono.Size = new Size(49, 23);
            cb_estadodono.TabIndex = 17;
            cb_estadodono.SelectedIndexChanged += cb_estadodono_SelectedIndexChanged;
            // 
            // cb_nascimento
            // 
            cb_nascimento.FormattingEnabled = true;
            cb_nascimento.Location = new Point(487, 50);
            cb_nascimento.Margin = new Padding(3, 2, 3, 2);
            cb_nascimento.Name = "cb_nascimento";
            cb_nascimento.Size = new Size(133, 23);
            cb_nascimento.TabIndex = 16;
            cb_nascimento.SelectedIndexChanged += cb_nascimento_SelectedIndexChanged;
            // 
            // txt_cpf
            // 
            txt_cpf.Location = new Point(235, 177);
            txt_cpf.Margin = new Padding(3, 2, 3, 2);
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(158, 23);
            txt_cpf.TabIndex = 15;
            txt_cpf.TextChanged += txt_cpf_TextChanged;
            // 
            // txt_rg
            // 
            txt_rg.Location = new Point(39, 177);
            txt_rg.Margin = new Padding(3, 2, 3, 2);
            txt_rg.Name = "txt_rg";
            txt_rg.Size = new Size(146, 23);
            txt_rg.TabIndex = 14;
            txt_rg.TextChanged += txt_rg_TextChanged;
            // 
            // txt_cidadedono
            // 
            txt_cidadedono.Location = new Point(59, 149);
            txt_cidadedono.Margin = new Padding(3, 2, 3, 2);
            txt_cidadedono.Name = "txt_cidadedono";
            txt_cidadedono.Size = new Size(199, 23);
            txt_cidadedono.TabIndex = 13;
            txt_cidadedono.TextChanged += txt_cidadedono_TextChanged;
            // 
            // txt_complemento
            // 
            txt_complemento.Location = new Point(104, 120);
            txt_complemento.Margin = new Padding(3, 2, 3, 2);
            txt_complemento.Name = "txt_complemento";
            txt_complemento.Size = new Size(281, 23);
            txt_complemento.TabIndex = 12;
            txt_complemento.TextChanged += txt_complemento_TextChanged;
            // 
            // txt_bairro
            // 
            txt_bairro.Location = new Point(59, 86);
            txt_bairro.Margin = new Padding(3, 2, 3, 2);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(327, 23);
            txt_bairro.TabIndex = 11;
            txt_bairro.TextChanged += txt_bairro_TextChanged;
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(75, 56);
            txt_endereco.Margin = new Padding(3, 2, 3, 2);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(310, 23);
            txt_endereco.TabIndex = 10;
            txt_endereco.TextChanged += txt_endereco_TextChanged;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(59, 28);
            txt_nome.Margin = new Padding(3, 2, 3, 2);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(327, 23);
            txt_nome.TabIndex = 9;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(490, 34);
            label17.Name = "label17";
            label17.Size = new Size(117, 15);
            label17.TabIndex = 8;
            label17.Text = "Data de Nascimento:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(262, 149);
            label16.Name = "label16";
            label16.Size = new Size(45, 15);
            label16.TabIndex = 7;
            label16.Text = "Estado:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(201, 179);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 6;
            label15.Text = "CPF:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 152);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 5;
            label14.Text = "Cidade:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 122);
            label13.Name = "label13";
            label13.Size = new Size(87, 15);
            label13.TabIndex = 4;
            label13.Text = "Complemento:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 88);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 3;
            label12.Text = "Bairro:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 56);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 2;
            label11.Text = "Endereço:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 28);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 1;
            label10.Text = "Nome:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 28);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 0;
            // 
            // btn_cadastar
            // 
            btn_cadastar.Location = new Point(97, 422);
            btn_cadastar.Margin = new Padding(3, 2, 3, 2);
            btn_cadastar.Name = "btn_cadastar";
            btn_cadastar.Size = new Size(120, 28);
            btn_cadastar.TabIndex = 4;
            btn_cadastar.Text = "Cadastrar";
            btn_cadastar.UseVisualStyleBackColor = true;
            btn_cadastar.Click += btn_cadastar_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(222, 422);
            btn_alterar.Margin = new Padding(3, 2, 3, 2);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(120, 28);
            btn_alterar.TabIndex = 5;
            btn_alterar.Text = "Alterar ";
            btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(346, 422);
            btn_consultar.Margin = new Padding(3, 2, 3, 2);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(120, 28);
            btn_consultar.TabIndex = 6;
            btn_consultar.Text = "Consuntar";
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(511, 422);
            btn_excluir.Margin = new Padding(3, 2, 3, 2);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(120, 28);
            btn_excluir.TabIndex = 7;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_limpardados
            // 
            btn_limpardados.Location = new Point(658, 422);
            btn_limpardados.Margin = new Padding(3, 2, 3, 2);
            btn_limpardados.Name = "btn_limpardados";
            btn_limpardados.Size = new Size(120, 28);
            btn_limpardados.TabIndex = 8;
            btn_limpardados.Text = "Limpar";
            btn_limpardados.UseVisualStyleBackColor = true;
            btn_limpardados.Click += btn_limpardados_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(803, 422);
            btn_sair.Margin = new Padding(3, 2, 3, 2);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(120, 28);
            btn_sair.TabIndex = 9;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(970, 490);
            Controls.Add(btn_sair);
            Controls.Add(btn_limpardados);
            Controls.Add(btn_excluir);
            Controls.Add(btn_consultar);
            Controls.Add(btn_alterar);
            Controls.Add(btn_cadastar);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_foto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_dono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btn_limpar;
        private Button btn_carregar;
        private PictureBox pic_foto;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cb_estado;
        private ComboBox cb_fabricante;
        private ComboBox cb_ano;
        private TextBox txt_cidade;
        private TextBox txt_cor;
        private TextBox txt_placa;
        private TextBox txt_modelo;
        private GroupBox groupBox2;
        private TextBox txt_rg;
        private TextBox txt_cidadedono;
        private TextBox txt_complemento;
        private TextBox txt_bairro;
        private TextBox txt_endereco;
        private TextBox txt_nome;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private RadioButton rb_feminino;
        private RadioButton rb_masculino;
        private GroupBox groupBox3;
        private Button btn_limpar2;
        private Button btn_carregar2;
        private PictureBox pic_dono;
        private ComboBox cb_estadodono;
        private ComboBox cb_nascimento;
        private TextBox txt_cpf;
        private CheckBox check_veiculo;
        private Label label18;
        private Button btn_cadastar;
        private Button btn_alterar;
        private Button btn_consultar;
        private Button btn_excluir;
        private Button btn_limpardados;
        private Button btn_sair;
    }
}
