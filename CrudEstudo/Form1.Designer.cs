namespace CrudEstudo
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
            dgClientes = new DataGridView();
            lId = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            lNome = new Label();
            txtIdade = new TextBox();
            lIdade = new Label();
            txtSexo = new TextBox();
            lSexo = new Label();
            txtTelefone = new TextBox();
            lTelefone = new Label();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            txtCPF = new TextBox();
            lCPF = new Label();
            btnLimpar = new Button();
            btnIr = new Button();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            SuspendLayout();
            // 
            // dgClientes
            // 
            dgClientes.AllowUserToAddRows = false;
            dgClientes.AllowUserToDeleteRows = false;
            dgClientes.AllowUserToResizeColumns = false;
            dgClientes.AllowUserToResizeRows = false;
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Location = new Point(12, 230);
            dgClientes.Name = "dgClientes";
            dgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgClientes.Size = new Size(578, 178);
            dgClientes.TabIndex = 0;
            dgClientes.CellDoubleClick += dgClientes_CellDoubleClick;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.Location = new Point(12, 52);
            lId.Name = "lId";
            lId.Size = new Size(17, 15);
            lId.TabIndex = 1;
            lId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(12, 70);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 123);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(283, 23);
            txtNome.TabIndex = 4;
            // 
            // lNome
            // 
            lNome.AutoSize = true;
            lNome.Location = new Point(12, 105);
            lNome.Name = "lNome";
            lNome.Size = new Size(40, 15);
            lNome.TabIndex = 3;
            lNome.Text = "Nome";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(477, 123);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(113, 23);
            txtIdade.TabIndex = 8;
            // 
            // lIdade
            // 
            lIdade.AutoSize = true;
            lIdade.Location = new Point(477, 105);
            lIdade.Name = "lIdade";
            lIdade.Size = new Size(36, 15);
            lIdade.TabIndex = 7;
            lIdade.Text = "Idade";
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(12, 179);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(113, 23);
            txtSexo.TabIndex = 10;
            // 
            // lSexo
            // 
            lSexo.AutoSize = true;
            lSexo.Location = new Point(12, 161);
            lSexo.Name = "lSexo";
            lSexo.Size = new Size(32, 15);
            lSexo.TabIndex = 9;
            lSexo.Text = "Sexo";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(182, 179);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(113, 23);
            txtTelefone.TabIndex = 12;
            // 
            // lTelefone
            // 
            lTelefone.AutoSize = true;
            lTelefone.Location = new Point(182, 161);
            lTelefone.Name = "lTelefone";
            lTelefone.Size = new Size(51, 15);
            lTelefone.TabIndex = 11;
            lTelefone.Text = "Telefone";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(323, 179);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(418, 179);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 14;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(515, 179);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(333, 123);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(113, 23);
            txtCPF.TabIndex = 16;
            // 
            // lCPF
            // 
            lCPF.AutoSize = true;
            lCPF.Location = new Point(333, 105);
            lCPF.Name = "lCPF";
            lCPF.Size = new Size(28, 15);
            lCPF.TabIndex = 17;
            lCPF.Text = "CPF";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(515, 35);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnIr
            // 
            btnIr.Location = new Point(323, 35);
            btnIr.Name = "btnIr";
            btnIr.Size = new Size(75, 23);
            btnIr.TabIndex = 19;
            btnIr.Text = "Fornecedor";
            btnIr.UseVisualStyleBackColor = true;
            btnIr.Click += btnIr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 421);
            Controls.Add(btnIr);
            Controls.Add(btnLimpar);
            Controls.Add(lCPF);
            Controls.Add(txtCPF);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtTelefone);
            Controls.Add(lTelefone);
            Controls.Add(txtSexo);
            Controls.Add(lSexo);
            Controls.Add(txtIdade);
            Controls.Add(lIdade);
            Controls.Add(txtNome);
            Controls.Add(lNome);
            Controls.Add(txtId);
            Controls.Add(lId);
            Controls.Add(dgClientes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgClientes;
        private Label lId;
        private TextBox txtId;
        private TextBox txtNome;
        private Label lNome;
        private TextBox txtIdade;
        private Label lIdade;
        private TextBox txtSexo;
        private Label lSexo;
        private TextBox txtTelefone;
        private Label lTelefone;
        private Button btnCadastrar;
        private Button btnAlterar;
        private Button btnExcluir;
        private TextBox txtCPF;
        private Label lCPF;
        private Button btnLimpar;
        private Button btnIr;
    }
}
