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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            lsbDados = new ListBox();
            bntGoogle = new Button();
            btnSysInfo = new Button();
            btnUser = new Button();
            btnCalc = new Button();
            btnVSCode = new Button();
            btnSair = new Button();
            btnLimpar = new Button();
            btnExibir = new Button();
            cmbNaturalidade = new ComboBox();
            lblNaturalidade = new Label();
            lblSexo = new Label();
            lblDataNascimento = new Label();
            cmbSexo = new ComboBox();
            dtpNascimento = new DateTimePicker();
            mskCPF = new MaskedTextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            lblCPF = new Label();
            lblRM = new Label();
            txtRM = new TextBox();
            btnNotepad = new Button();
            pnlPrincipal = new Panel();
            pictureBox1 = new PictureBox();
            pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lsbDados
            // 
            lsbDados.Font = new Font("Segoe UI", 12F);
            lsbDados.FormattingEnabled = true;
            lsbDados.ItemHeight = 21;
            lsbDados.Location = new Point(402, 217);
            lsbDados.Name = "lsbDados";
            lsbDados.Size = new Size(260, 193);
            lsbDados.TabIndex = 15;
            // 
            // bntGoogle
            // 
            bntGoogle.Font = new Font("Segoe UI", 12F);
            bntGoogle.Location = new Point(24, 360);
            bntGoogle.Name = "bntGoogle";
            bntGoogle.Size = new Size(110, 50);
            bntGoogle.TabIndex = 12;
            bntGoogle.Text = "Google Fatec";
            bntGoogle.UseVisualStyleBackColor = true;
            bntGoogle.Click += btnGoogle_Click;
            // 
            // btnSysInfo
            // 
            btnSysInfo.Font = new Font("Segoe UI", 12F);
            btnSysInfo.Location = new Point(145, 360);
            btnSysInfo.Name = "btnSysInfo";
            btnSysInfo.Size = new Size(110, 50);
            btnSysInfo.TabIndex = 13;
            btnSysInfo.Text = "Informações do sistema";
            btnSysInfo.UseVisualStyleBackColor = true;
            btnSysInfo.Click += btnSysInfo_Click;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI", 12F);
            btnUser.Location = new Point(272, 360);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(110, 50);
            btnUser.TabIndex = 14;
            btnUser.Text = "Informações do usuário";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 12F);
            btnCalc.Location = new Point(24, 291);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(110, 50);
            btnCalc.TabIndex = 9;
            btnCalc.Text = "Calculadora";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnVSCode
            // 
            btnVSCode.Font = new Font("Segoe UI", 12F);
            btnVSCode.Location = new Point(272, 291);
            btnVSCode.Name = "btnVSCode";
            btnVSCode.Size = new Size(110, 50);
            btnVSCode.TabIndex = 11;
            btnVSCode.Text = "Visual Studio Code";
            btnVSCode.UseVisualStyleBackColor = true;
            btnVSCode.Click += btnVSCode_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 12F);
            btnSair.Location = new Point(272, 215);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(110, 50);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 12F);
            btnLimpar.Location = new Point(145, 215);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 50);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExibir
            // 
            btnExibir.Font = new Font("Segoe UI", 12F);
            btnExibir.Location = new Point(24, 215);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(110, 50);
            btnExibir.TabIndex = 6;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // cmbNaturalidade
            // 
            cmbNaturalidade.Font = new Font("Segoe UI", 12F);
            cmbNaturalidade.FormattingEnabled = true;
            cmbNaturalidade.Items.AddRange(new object[] { "Jaboticabal - SP", "Guariba - SP", "Matão - SP", "Monte Alto - SP", "Taquaritinga - SP", "Santa Ernestina - SP" });
            cmbNaturalidade.Location = new Point(417, 148);
            cmbNaturalidade.Name = "cmbNaturalidade";
            cmbNaturalidade.Size = new Size(245, 29);
            cmbNaturalidade.TabIndex = 5;
            // 
            // lblNaturalidade
            // 
            lblNaturalidade.AutoSize = true;
            lblNaturalidade.Font = new Font("Segoe UI", 12F);
            lblNaturalidade.Location = new Point(417, 124);
            lblNaturalidade.Name = "lblNaturalidade";
            lblNaturalidade.Size = new Size(100, 21);
            lblNaturalidade.TabIndex = 12;
            lblNaturalidade.Text = "Naturalidade";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 12F);
            lblSexo.Location = new Point(271, 124);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(43, 21);
            lblSexo.TabIndex = 10;
            lblSexo.Text = "Sexo";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI", 12F);
            lblDataNascimento.Location = new Point(130, 124);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(93, 21);
            lblDataNascimento.TabIndex = 9;
            lblDataNascimento.Text = "Nascimento";
            // 
            // cmbSexo
            // 
            cmbSexo.Font = new Font("Segoe UI", 12F);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Feminino", "Masculino" });
            cmbSexo.Location = new Point(272, 148);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(128, 29);
            cmbSexo.TabIndex = 4;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Font = new Font("Segoe UI", 12F);
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(130, 148);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(126, 29);
            dtpNascimento.TabIndex = 3;
            // 
            // mskCPF
            // 
            mskCPF.Font = new Font("Segoe UI", 12F);
            mskCPF.Location = new Point(130, 82);
            mskCPF.Mask = "000\\.000\\.000-00";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(125, 29);
            mskCPF.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(261, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(401, 29);
            txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(261, 58);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 21);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            lblNome.Click += lblNome_Click;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 12F);
            lblCPF.Location = new Point(130, 59);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(37, 21);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Font = new Font("Segoe UI", 12F);
            lblRM.Location = new Point(24, 58);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(34, 21);
            lblRM.TabIndex = 1;
            lblRM.Text = "RM";
            // 
            // txtRM
            // 
            txtRM.Font = new Font("Segoe UI", 12F);
            txtRM.Location = new Point(24, 82);
            txtRM.MaxLength = 6;
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(100, 29);
            txtRM.TabIndex = 0;
            // 
            // btnNotepad
            // 
            btnNotepad.Font = new Font("Segoe UI", 12F);
            btnNotepad.Location = new Point(145, 291);
            btnNotepad.Name = "btnNotepad";
            btnNotepad.Size = new Size(110, 50);
            btnNotepad.TabIndex = 10;
            btnNotepad.Text = "Bloco de Notas";
            btnNotepad.UseVisualStyleBackColor = true;
            btnNotepad.Click += btnNotepad_Click;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.None;
            pnlPrincipal.BackColor = Color.PowderBlue;
            pnlPrincipal.BorderStyle = BorderStyle.Fixed3D;
            pnlPrincipal.Controls.Add(pictureBox1);
            pnlPrincipal.Controls.Add(btnLimpar);
            pnlPrincipal.Controls.Add(lsbDados);
            pnlPrincipal.Controls.Add(txtRM);
            pnlPrincipal.Controls.Add(btnUser);
            pnlPrincipal.Controls.Add(lblRM);
            pnlPrincipal.Controls.Add(btnSysInfo);
            pnlPrincipal.Controls.Add(lblCPF);
            pnlPrincipal.Controls.Add(bntGoogle);
            pnlPrincipal.Controls.Add(txtNome);
            pnlPrincipal.Controls.Add(btnVSCode);
            pnlPrincipal.Controls.Add(lblNome);
            pnlPrincipal.Controls.Add(btnNotepad);
            pnlPrincipal.Controls.Add(mskCPF);
            pnlPrincipal.Controls.Add(btnCalc);
            pnlPrincipal.Controls.Add(dtpNascimento);
            pnlPrincipal.Controls.Add(btnSair);
            pnlPrincipal.Controls.Add(cmbSexo);
            pnlPrincipal.Controls.Add(lblDataNascimento);
            pnlPrincipal.Controls.Add(btnExibir);
            pnlPrincipal.Controls.Add(lblSexo);
            pnlPrincipal.Controls.Add(lblNaturalidade);
            pnlPrincipal.Controls.Add(cmbNaturalidade);
            pnlPrincipal.Location = new Point(124, 36);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(693, 441);
            pnlPrincipal.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(895, 514);
            Controls.Add(pnlPrincipal);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de usuários";
            WindowState = FormWindowState.Maximized;
            Load += frmUsuarios_Load;
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsbDados;
        private Button bntGoogle;
        private Button btnSysInfo;
        private Button btnUser;
        private Button btnCalc;
        private Button btnVSCode;
        private Button btnSair;
        private Button btnLimpar;
        private Button btnExibir;
        private ComboBox cmbNaturalidade;
        private Label lblNaturalidade;
        private Label lblSexo;
        private Label lblDataNascimento;
        private ComboBox cmbSexo;
        private DateTimePicker dtpNascimento;
        private MaskedTextBox mskCPF;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblCPF;
        private Label lblRM;
        private TextBox txtRM;
        private Button btnNotepad;
        private Panel pnlPrincipal;
        private PictureBox pictureBox1;
    }
}
