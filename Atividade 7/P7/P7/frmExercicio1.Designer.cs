namespace P7
{
    partial class frmExercicio1
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
            this.btnEspaco = new System.Windows.Forms.Button();
            this.btnNumeroR = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.BackColor = System.Drawing.Color.White;
            this.rchtxtFrase.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtFrase.Location = new System.Drawing.Point(60, 54);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(672, 201);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnEspaco
            // 
            this.btnEspaco.BackColor = System.Drawing.Color.White;
            this.btnEspaco.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspaco.Location = new System.Drawing.Point(60, 281);
            this.btnEspaco.Name = "btnEspaco";
            this.btnEspaco.Size = new System.Drawing.Size(154, 89);
            this.btnEspaco.TabIndex = 1;
            this.btnEspaco.Text = "Número de espaços em banco";
            this.btnEspaco.UseVisualStyleBackColor = false;
            this.btnEspaco.Click += new System.EventHandler(this.btnEspaco_Click);
            // 
            // btnNumeroR
            // 
            this.btnNumeroR.BackColor = System.Drawing.Color.White;
            this.btnNumeroR.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeroR.Location = new System.Drawing.Point(232, 281);
            this.btnNumeroR.Name = "btnNumeroR";
            this.btnNumeroR.Size = new System.Drawing.Size(154, 89);
            this.btnNumeroR.TabIndex = 2;
            this.btnNumeroR.Text = "Número de \"R\"";
            this.btnNumeroR.UseVisualStyleBackColor = false;
            this.btnNumeroR.Click += new System.EventHandler(this.btnNumeroR_Click);
            // 
            // btnPares
            // 
            this.btnPares.BackColor = System.Drawing.Color.White;
            this.btnPares.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPares.Location = new System.Drawing.Point(408, 281);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(154, 89);
            this.btnPares.TabIndex = 3;
            this.btnPares.Text = "Número de pares de letras";
            this.btnPares.UseVisualStyleBackColor = false;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(578, 281);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 89);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnNumeroR);
            this.Controls.Add(this.btnEspaco);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio1";
            this.Text = "frmExercício1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnEspaco;
        private System.Windows.Forms.Button btnNumeroR;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnLimpar;
    }
}