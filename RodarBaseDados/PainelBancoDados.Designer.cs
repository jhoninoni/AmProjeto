namespace RodarBaseDados
{
    partial class PainelBancoDados
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
            this.btnCriaBaseDados = new System.Windows.Forms.Button();
            this.btnRodaMassaDados = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnDroparBanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriaBaseDados
            // 
            this.btnCriaBaseDados.Location = new System.Drawing.Point(29, 59);
            this.btnCriaBaseDados.Name = "btnCriaBaseDados";
            this.btnCriaBaseDados.Size = new System.Drawing.Size(224, 23);
            this.btnCriaBaseDados.TabIndex = 0;
            this.btnCriaBaseDados.Text = "Criar Base Dados";
            this.btnCriaBaseDados.UseVisualStyleBackColor = true;
            this.btnCriaBaseDados.Click += new System.EventHandler(this.btnCriaBaseDados_Click);
            // 
            // btnRodaMassaDados
            // 
            this.btnRodaMassaDados.Location = new System.Drawing.Point(29, 88);
            this.btnRodaMassaDados.Name = "btnRodaMassaDados";
            this.btnRodaMassaDados.Size = new System.Drawing.Size(224, 23);
            this.btnRodaMassaDados.TabIndex = 1;
            this.btnRodaMassaDados.Text = "Rodar Massa Dados";
            this.btnRodaMassaDados.UseVisualStyleBackColor = true;
            this.btnRodaMassaDados.Click += new System.EventHandler(this.btnRodaMassaDados_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(35, 186);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 25);
            this.lblMensagem.TabIndex = 2;
            // 
            // btnDroparBanco
            // 
            this.btnDroparBanco.Location = new System.Drawing.Point(29, 30);
            this.btnDroparBanco.Name = "btnDroparBanco";
            this.btnDroparBanco.Size = new System.Drawing.Size(224, 23);
            this.btnDroparBanco.TabIndex = 3;
            this.btnDroparBanco.Text = "Deletar Banco Atual";
            this.btnDroparBanco.UseVisualStyleBackColor = true;
            this.btnDroparBanco.Click += new System.EventHandler(this.btnDroparBanco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDroparBanco);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnRodaMassaDados);
            this.Controls.Add(this.btnCriaBaseDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriaBaseDados;
        private System.Windows.Forms.Button btnRodaMassaDados;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnDroparBanco;
    }
}

