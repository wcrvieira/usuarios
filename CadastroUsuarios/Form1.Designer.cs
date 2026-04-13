namespace CadastroUsuarios
{
    partial class frmUsuarios
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
            txtRM = new TextBox();
            lblRM = new Label();
            lblCPF = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            mskCPF = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            lblDataNascimento = new Label();
            lblSexo = new Label();
            lblNaturalidade = new Label();
            comboBox2 = new ComboBox();
            btnExibir = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txtRM
            // 
            txtRM.Location = new Point(40, 50);
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(100, 23);
            txtRM.TabIndex = 0;
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(40, 32);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(25, 15);
            lblRM.TabIndex = 1;
            lblRM.Text = "RM";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(146, 32);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(268, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(268, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 23);
            txtNome.TabIndex = 4;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(146, 50);
            mskCPF.Mask = "###.###.###-##";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(109, 23);
            mskCPF.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(40, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Feminino", "Masculino" });
            comboBox1.Location = new Point(268, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 8;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(40, 81);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(112, 15);
            lblDataNascimento.TabIndex = 9;
            lblDataNascimento.Text = "Data de nascimento";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(268, 81);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(31, 15);
            lblSexo.TabIndex = 10;
            lblSexo.Text = "Sexo";
            // 
            // lblNaturalidade
            // 
            lblNaturalidade.AutoSize = true;
            lblNaturalidade.Location = new Point(407, 81);
            lblNaturalidade.Name = "lblNaturalidade";
            lblNaturalidade.Size = new Size(75, 15);
            lblNaturalidade.TabIndex = 12;
            lblNaturalidade.Text = "Naturalidade";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Jaboticabal - SP", "Guariba - SP", "Matão - SP", "Monte Alto - SP", "Taquaritinga - SP", "Santa Ernestina - SP" });
            comboBox2.Location = new Point(416, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(40, 138);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(100, 36);
            btnExibir.TabIndex = 13;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(146, 138);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(109, 36);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(261, 138);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(90, 36);
            btnSair.TabIndex = 15;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(261, 212);
            button1.Name = "button1";
            button1.Size = new Size(90, 50);
            button1.TabIndex = 18;
            button1.Text = "Visual Studio Code";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(146, 212);
            button2.Name = "button2";
            button2.Size = new Size(109, 50);
            button2.TabIndex = 17;
            button2.Text = "Bloco de Notas";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(40, 212);
            button3.Name = "button3";
            button3.Size = new Size(100, 50);
            button3.TabIndex = 16;
            button3.Text = "Calculadora";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(261, 271);
            button4.Name = "button4";
            button4.Size = new Size(90, 45);
            button4.TabIndex = 21;
            button4.Text = "Informações do usuário";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(146, 268);
            button5.Name = "button5";
            button5.Size = new Size(109, 48);
            button5.TabIndex = 20;
            button5.Text = "Informações do sistema";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(40, 268);
            button6.Name = "button6";
            button6.Size = new Size(100, 48);
            button6.TabIndex = 19;
            button6.Text = "Painel de Controle";
            button6.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(366, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(171, 184);
            listBox1.TabIndex = 22;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnExibir);
            Controls.Add(lblNaturalidade);
            Controls.Add(comboBox2);
            Controls.Add(lblSexo);
            Controls.Add(lblDataNascimento);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(mskCPF);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCPF);
            Controls.Add(lblRM);
            Controls.Add(txtRM);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de usuários";
            WindowState = FormWindowState.Maximized;
            Load += frmUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRM;
        private Label lblRM;
        private Label lblCPF;
        private Label lblNome;
        private TextBox txtNome;
        private MaskedTextBox mskCPF;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label lblDataNascimento;
        private Label lblSexo;
        private Label lblNaturalidade;
        private ComboBox comboBox2;
        private Button btnExibir;
        private Button btnLimpar;
        private Button btnSair;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ListBox listBox1;
    }
}
