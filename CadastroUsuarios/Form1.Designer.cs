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
            btnVSCode = new Button();
            btnNotepad = new Button();
            btnCalc = new Button();
            btnUser = new Button();
            btnSysInfo = new Button();
            bntGoogle = new Button();
            lsbDados = new ListBox();
            SuspendLayout();
            // 
            // txtRM
            // 
            txtRM.Location = new Point(50, 56);
            txtRM.MaxLength = 6;
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(100, 23);
            txtRM.TabIndex = 0;
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(50, 38);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(25, 15);
            lblRM.TabIndex = 1;
            lblRM.Text = "RM";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(156, 38);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(287, 38);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(287, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 23);
            txtNome.TabIndex = 4;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(156, 56);
            mskCPF.Mask = "000\\.000\\.000-00";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(125, 23);
            mskCPF.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(50, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Feminino", "Masculino" });
            comboBox1.Location = new Point(287, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 8;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(50, 87);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(112, 15);
            lblDataNascimento.TabIndex = 9;
            lblDataNascimento.Text = "Data de nascimento";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(287, 87);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(31, 15);
            lblSexo.TabIndex = 10;
            lblSexo.Text = "Sexo";
            // 
            // lblNaturalidade
            // 
            lblNaturalidade.AutoSize = true;
            lblNaturalidade.Location = new Point(426, 87);
            lblNaturalidade.Name = "lblNaturalidade";
            lblNaturalidade.Size = new Size(75, 15);
            lblNaturalidade.TabIndex = 12;
            lblNaturalidade.Text = "Naturalidade";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Jaboticabal - SP", "Guariba - SP", "Matão - SP", "Monte Alto - SP", "Taquaritinga - SP", "Santa Ernestina - SP" });
            comboBox2.Location = new Point(435, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(50, 144);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(100, 36);
            btnExibir.TabIndex = 13;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(156, 144);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(109, 36);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(280, 144);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(90, 36);
            btnSair.TabIndex = 15;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnVSCode
            // 
            btnVSCode.Location = new Point(271, 218);
            btnVSCode.Name = "btnVSCode";
            btnVSCode.Size = new Size(99, 50);
            btnVSCode.TabIndex = 18;
            btnVSCode.Text = "Visual Studio Code";
            btnVSCode.UseVisualStyleBackColor = true;
            btnVSCode.Click += btnVSCode_Click;
            // 
            // btnNotepad
            // 
            btnNotepad.Location = new Point(156, 218);
            btnNotepad.Name = "btnNotepad";
            btnNotepad.Size = new Size(109, 50);
            btnNotepad.TabIndex = 17;
            btnNotepad.Text = "Bloco de Notas";
            btnNotepad.UseVisualStyleBackColor = true;
            btnNotepad.Click += btnNotepad_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(50, 218);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(100, 50);
            btnCalc.TabIndex = 16;
            btnCalc.Text = "Calculadora";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(271, 277);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(99, 45);
            btnUser.TabIndex = 21;
            btnUser.Text = "Informações do usuário";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnSysInfo
            // 
            btnSysInfo.Location = new Point(156, 274);
            btnSysInfo.Name = "btnSysInfo";
            btnSysInfo.Size = new Size(109, 48);
            btnSysInfo.TabIndex = 20;
            btnSysInfo.Text = "Informações do sistema";
            btnSysInfo.UseVisualStyleBackColor = true;
            btnSysInfo.Click += btnSysInfo_Click;
            // 
            // bntGoogle
            // 
            bntGoogle.Location = new Point(50, 274);
            bntGoogle.Name = "bntGoogle";
            bntGoogle.Size = new Size(100, 48);
            bntGoogle.TabIndex = 19;
            bntGoogle.Text = "Google Fatec";
            bntGoogle.UseVisualStyleBackColor = true;
            bntGoogle.Click += btnGoogle_Click;
            // 
            // lsbDados
            // 
            lsbDados.FormattingEnabled = true;
            lsbDados.ItemHeight = 15;
            lsbDados.Location = new Point(385, 144);
            lsbDados.Name = "lsbDados";
            lsbDados.Size = new Size(171, 184);
            lsbDados.TabIndex = 22;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(611, 381);
            Controls.Add(lsbDados);
            Controls.Add(btnUser);
            Controls.Add(btnSysInfo);
            Controls.Add(bntGoogle);
            Controls.Add(btnVSCode);
            Controls.Add(btnNotepad);
            Controls.Add(btnCalc);
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
        private Button btnVSCode;
        private Button btnNotepad;
        private Button btnCalc;
        private Button btnUser;
        private Button btnSysInfo;
        private Button bntGoogle;
        private ListBox lsbDados;
    }
}
