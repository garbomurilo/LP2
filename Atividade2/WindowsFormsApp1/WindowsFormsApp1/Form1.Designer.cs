namespace WindowsFormsApp1
{
    partial class PCalc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNumero1 = new System.Windows.Forms.Label();
            this.LblNumero2 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSoma = new System.Windows.Forms.Button();
            this.BtnSubtracao = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNumero1
            // 
            this.LblNumero1.AutoSize = true;
            this.LblNumero1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero1.Location = new System.Drawing.Point(94, 154);
            this.LblNumero1.Name = "LblNumero1";
            this.LblNumero1.Size = new System.Drawing.Size(123, 31);
            this.LblNumero1.TabIndex = 0;
            this.LblNumero1.Text = "Número 1";
            // 
            // LblNumero2
            // 
            this.LblNumero2.AutoSize = true;
            this.LblNumero2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero2.Location = new System.Drawing.Point(97, 211);
            this.LblNumero2.Name = "LblNumero2";
            this.LblNumero2.Size = new System.Drawing.Size(123, 31);
            this.LblNumero2.TabIndex = 1;
            this.LblNumero2.Text = "Número 2";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(97, 275);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(124, 31);
            this.LblResultado.TabIndex = 2;
            this.LblResultado.Text = "Resultado";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnLimpar.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(724, 108);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(170, 77);
            this.BtnLimpar.TabIndex = 3;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSoma
            // 
            this.BtnSoma.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoma.Location = new System.Drawing.Point(82, 437);
            this.BtnSoma.Name = "BtnSoma";
            this.BtnSoma.Size = new System.Drawing.Size(151, 98);
            this.BtnSoma.TabIndex = 4;
            this.BtnSoma.Text = "+";
            this.BtnSoma.UseVisualStyleBackColor = true;
            this.BtnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // BtnSubtracao
            // 
            this.BtnSubtracao.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtracao.Location = new System.Drawing.Point(269, 437);
            this.BtnSubtracao.Name = "BtnSubtracao";
            this.BtnSubtracao.Size = new System.Drawing.Size(162, 98);
            this.BtnSubtracao.TabIndex = 5;
            this.BtnSubtracao.Text = "-";
            this.BtnSubtracao.UseVisualStyleBackColor = true;
            this.BtnSubtracao.Click += new System.EventHandler(this.BtnSub);
            // 
            // BtnMult
            // 
            this.BtnMult.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMult.Location = new System.Drawing.Point(470, 437);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(153, 98);
            this.BtnMult.TabIndex = 6;
            this.BtnMult.Text = "*";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSair.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(724, 230);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(170, 76);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Location = new System.Drawing.Point(227, 154);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(427, 20);
            this.TxtNumero1.TabIndex = 8;
            this.TxtNumero1.Validated += new System.EventHandler(this.TxtNumero1_Validated);
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.Location = new System.Drawing.Point(227, 221);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(426, 20);
            this.TxtNumero2.TabIndex = 9;
            this.TxtNumero2.Validated += new System.EventHandler(this.TxtNumero2_Validated);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Enabled = false;
            this.TxtResultado.Location = new System.Drawing.Point(226, 286);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(427, 20);
            this.TxtResultado.TabIndex = 10;
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.Location = new System.Drawing.Point(657, 437);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(156, 98);
            this.BtnDiv.TabIndex = 11;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // PCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(992, 615);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtNumero2);
            this.Controls.Add(this.TxtNumero1);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnSubtracao);
            this.Controls.Add(this.BtnSoma);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblNumero2);
            this.Controls.Add(this.LblNumero1);
            this.Name = "PCalc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumero1;
        private System.Windows.Forms.Label LblNumero2;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSoma;
        private System.Windows.Forms.Button BtnSubtracao;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnDiv;
    }
}

