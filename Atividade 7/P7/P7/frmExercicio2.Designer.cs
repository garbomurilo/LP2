namespace P7
{
    partial class frmExercicio2
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
            this.lblNumeroN = new System.Windows.Forms.Label();
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.lblNumeroH = new System.Windows.Forms.Label();
            this.txtNumeroH = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroN
            // 
            this.lblNumeroN.AutoSize = true;
            this.lblNumeroN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroN.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroN.Location = new System.Drawing.Point(190, 91);
            this.lblNumeroN.Name = "lblNumeroN";
            this.lblNumeroN.Size = new System.Drawing.Size(104, 21);
            this.lblNumeroN.TabIndex = 0;
            this.lblNumeroN.Text = "Número N";
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.BackColor = System.Drawing.Color.White;
            this.txtNumeroN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroN.Location = new System.Drawing.Point(300, 86);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(260, 29);
            this.txtNumeroN.TabIndex = 1;
            this.txtNumeroN.Validated += new System.EventHandler(this.txtNumeroN_Validated);
            // 
            // lblNumeroH
            // 
            this.lblNumeroH.AutoSize = true;
            this.lblNumeroH.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroH.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroH.Location = new System.Drawing.Point(190, 158);
            this.lblNumeroH.Name = "lblNumeroH";
            this.lblNumeroH.Size = new System.Drawing.Size(104, 21);
            this.lblNumeroH.TabIndex = 2;
            this.lblNumeroH.Text = "Número H";
            // 
            // txtNumeroH
            // 
            this.txtNumeroH.BackColor = System.Drawing.Color.White;
            this.txtNumeroH.Enabled = false;
            this.txtNumeroH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroH.Location = new System.Drawing.Point(300, 153);
            this.txtNumeroH.Name = "txtNumeroH";
            this.txtNumeroH.Size = new System.Drawing.Size(260, 29);
            this.txtNumeroH.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(194, 234);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(172, 81);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular H";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(388, 234);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(172, 81);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumeroH);
            this.Controls.Add(this.lblNumeroH);
            this.Controls.Add(this.txtNumeroN);
            this.Controls.Add(this.lblNumeroN);
            this.Name = "frmExercicio2";
            this.Text = "frmExercício2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroN;
        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.Label lblNumeroH;
        private System.Windows.Forms.TextBox txtNumeroH;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
    }
}