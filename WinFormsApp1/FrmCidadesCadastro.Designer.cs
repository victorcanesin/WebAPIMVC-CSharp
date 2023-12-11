namespace WinFormsApp1
{
    partial class FrmCidadesCadastro
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
            components = new System.ComponentModel.Container();
            txtCodigo = new TextBox();
            txtDescricao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            erro = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)erro).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 31);
            txtCodigo.MaxLength = 9;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            txtCodigo.Validating += txtCodigo_Validating;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(133, 31);
            txtDescricao.MaxLength = 255;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(391, 23);
            txtDescricao.TabIndex = 1;
            txtDescricao.Validating += txtDescricao_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 13);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkCyan;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(368, 71);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(449, 71);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // erro
            // 
            erro.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            erro.ContainerControl = this;
            // 
            // FrmCidadesCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 106);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodigo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmCidadesCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de cidade";
            FormClosed += FrmCidadesCadastro_FormClosed;
            ((System.ComponentModel.ISupportInitialize)erro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnSalvar;
        private Button btnCancelar;
        private ErrorProvider erro;
        public TextBox txtCodigo;
        public TextBox txtDescricao;
    }
}