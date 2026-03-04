namespace P7
{
    partial class frmExercicio4
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
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblProducao = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblGratificacao = new System.Windows.Forms.Label();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.mskdSalario = new System.Windows.Forms.MaskedTextBox();
            this.mskdGratificacao = new System.Windows.Forms.MaskedTextBox();
            this.mskdSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.White;
            this.txtMatricula.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(132, 106);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(243, 33);
            this.txtMatricula.TabIndex = 2;
            this.txtMatricula.Validated += new System.EventHandler(this.txtMatricula_Validated);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(433, 347);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(172, 81);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(203, 347);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(172, 81);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular salário bruto";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(112, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 33);
            this.txtNome.TabIndex = 1;
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(26, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 21);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.Color.Black;
            this.lblMatricula.Location = new System.Drawing.Point(26, 109);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(94, 21);
            this.lblMatricula.TabIndex = 19;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblProducao
            // 
            this.lblProducao.AutoSize = true;
            this.lblProducao.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducao.ForeColor = System.Drawing.Color.Black;
            this.lblProducao.Location = new System.Drawing.Point(26, 163);
            this.lblProducao.Name = "lblProducao";
            this.lblProducao.Size = new System.Drawing.Size(97, 21);
            this.lblProducao.TabIndex = 20;
            this.lblProducao.Text = "Produção";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.Black;
            this.lblSalario.Location = new System.Drawing.Point(26, 217);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(71, 21);
            this.lblSalario.TabIndex = 21;
            this.lblSalario.Text = "Salário";
            // 
            // lblGratificacao
            // 
            this.lblGratificacao.AutoSize = true;
            this.lblGratificacao.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGratificacao.ForeColor = System.Drawing.Color.Black;
            this.lblGratificacao.Location = new System.Drawing.Point(26, 271);
            this.lblGratificacao.Name = "lblGratificacao";
            this.lblGratificacao.Size = new System.Drawing.Size(116, 21);
            this.lblGratificacao.TabIndex = 22;
            this.lblGratificacao.Text = "Gratificação";
            // 
            // txtProducao
            // 
            this.txtProducao.BackColor = System.Drawing.Color.White;
            this.txtProducao.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducao.Location = new System.Drawing.Point(132, 160);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(243, 33);
            this.txtProducao.TabIndex = 3;
            this.txtProducao.Validated += new System.EventHandler(this.txtProducao_Validated);
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.ForeColor = System.Drawing.Color.Black;
            this.lblSalarioBruto.Location = new System.Drawing.Point(429, 58);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(127, 21);
            this.lblSalarioBruto.TabIndex = 26;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // mskdSalario
            // 
            this.mskdSalario.BackColor = System.Drawing.Color.White;
            this.mskdSalario.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdSalario.Location = new System.Drawing.Point(112, 214);
            this.mskdSalario.Mask = "99990.00";
            this.mskdSalario.Name = "mskdSalario";
            this.mskdSalario.Size = new System.Drawing.Size(263, 33);
            this.mskdSalario.TabIndex = 4;
            this.mskdSalario.Validated += new System.EventHandler(this.mskdSalario_Validated);
            // 
            // mskdGratificacao
            // 
            this.mskdGratificacao.BackColor = System.Drawing.Color.White;
            this.mskdGratificacao.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdGratificacao.Location = new System.Drawing.Point(147, 268);
            this.mskdGratificacao.Mask = "9990.00";
            this.mskdGratificacao.Name = "mskdGratificacao";
            this.mskdGratificacao.Size = new System.Drawing.Size(228, 33);
            this.mskdGratificacao.TabIndex = 5;
            this.mskdGratificacao.Validated += new System.EventHandler(this.mskdGratificacao_Validated);
            // 
            // mskdSalarioBruto
            // 
            this.mskdSalarioBruto.BackColor = System.Drawing.Color.White;
            this.mskdSalarioBruto.Enabled = false;
            this.mskdSalarioBruto.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdSalarioBruto.Location = new System.Drawing.Point(562, 55);
            this.mskdSalarioBruto.Name = "mskdSalarioBruto";
            this.mskdSalarioBruto.Size = new System.Drawing.Size(216, 33);
            this.mskdSalarioBruto.TabIndex = 30;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(821, 473);
            this.Controls.Add(this.mskdSalarioBruto);
            this.Controls.Add(this.mskdGratificacao);
            this.Controls.Add(this.mskdSalario);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.lblGratificacao);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblProducao);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNome);
            this.Name = "frmExercicio4";
            this.Text = "frmExercício4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblProducao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblGratificacao;
        private System.Windows.Forms.TextBox txtProducao;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.MaskedTextBox mskdSalario;
        private System.Windows.Forms.MaskedTextBox mskdGratificacao;
        private System.Windows.Forms.MaskedTextBox mskdSalarioBruto;
    }
}