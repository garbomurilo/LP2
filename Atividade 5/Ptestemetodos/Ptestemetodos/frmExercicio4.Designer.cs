namespace Ptestemetodos
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnLetras = new System.Windows.Forms.Button();
            this.btnPosicao = new System.Windows.Forms.Button();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtFrase.Location = new System.Drawing.Point(129, 26);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(544, 200);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnLetras
            // 
            this.btnLetras.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetras.ForeColor = System.Drawing.Color.SlateGray;
            this.btnLetras.Location = new System.Drawing.Point(521, 267);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(167, 90);
            this.btnLetras.TabIndex = 9;
            this.btnLetras.Text = "Conta Letras";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // btnPosicao
            // 
            this.btnPosicao.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosicao.ForeColor = System.Drawing.Color.SlateGray;
            this.btnPosicao.Location = new System.Drawing.Point(302, 267);
            this.btnPosicao.Name = "btnPosicao";
            this.btnPosicao.Size = new System.Drawing.Size(201, 90);
            this.btnPosicao.TabIndex = 8;
            this.btnPosicao.Text = "Posição do 1° caracter branco";
            this.btnPosicao.UseVisualStyleBackColor = true;
            this.btnPosicao.Click += new System.EventHandler(this.btnPosicao_Click);
            // 
            // btnNumeros
            // 
            this.btnNumeros.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeros.ForeColor = System.Drawing.Color.SlateGray;
            this.btnNumeros.Location = new System.Drawing.Point(115, 267);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(167, 90);
            this.btnNumeros.TabIndex = 7;
            this.btnNumeros.Text = "Conta Números";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnPosicao);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.Button btnPosicao;
        private System.Windows.Forms.Button btnNumeros;
    }
}