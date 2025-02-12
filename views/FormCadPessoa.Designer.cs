namespace FormsCadastro.views
{
    partial class FormCadPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            bntGravar = new Button();
            txtCodigo = new TextBox();
            btnNovo = new Button();
            btnExcluir = new Button();
            btnPosterior = new Button();
            btnAnterior = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(89, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(142, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(89, 59);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(142, 23);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 67);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(89, 88);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(142, 23);
            txtTelefone.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 96);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefone:";
            // 
            // bntGravar
            // 
            bntGravar.Location = new Point(258, 59);
            bntGravar.Name = "bntGravar";
            bntGravar.Size = new Size(75, 23);
            bntGravar.TabIndex = 7;
            bntGravar.Text = "Gravar";
            bntGravar.UseVisualStyleBackColor = true;
            bntGravar.Click += bntGravar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 114);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(32, 23);
            txtCodigo.TabIndex = 5;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(258, 30);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 6;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(258, 88);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += button2_Click;
            // 
            // btnPosterior
            // 
            btnPosterior.Location = new Point(190, 117);
            btnPosterior.Name = "btnPosterior";
            btnPosterior.Size = new Size(41, 23);
            btnPosterior.TabIndex = 5;
            btnPosterior.Text = "⏩";
            btnPosterior.UseVisualStyleBackColor = true;
            btnPosterior.Click += btnPosterior_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.AccessibleDescription = "Navegar para o registro anterior";
            btnAnterior.Location = new Point(89, 117);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(41, 23);
            btnAnterior.TabIndex = 4;
            btnAnterior.Text = "⏪";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(258, 117);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormCadPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 168);
            Controls.Add(btnFechar);
            Controls.Add(btnAnterior);
            Controls.Add(btnPosterior);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(txtCodigo);
            Controls.Add(bntGravar);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadPessoa";
            Text = "Cadastro de Pessoas";
            Load += FormCadPessoa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtTelefone;
        private Label label3;
        private Button bntGravar;
        private TextBox txtCodigo;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnPosterior;
        private Button btnAnterior;
        public Button btnFechar;
        private Button button5;
    }
}