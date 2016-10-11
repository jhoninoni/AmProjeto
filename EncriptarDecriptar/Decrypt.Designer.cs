namespace RodarBaseDados
{
    partial class Decrypt
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.txtValorResultado = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(30, 104);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 38);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Location = new System.Drawing.Point(12, 48);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(260, 20);
            this.txtValorRecebido.TabIndex = 1;
            // 
            // txtValorResultado
            // 
            this.txtValorResultado.Location = new System.Drawing.Point(12, 183);
            this.txtValorResultado.Name = "txtValorResultado";
            this.txtValorResultado.Size = new System.Drawing.Size(260, 20);
            this.txtValorResultado.TabIndex = 2;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(164, 104);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 38);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtValorResultado);
            this.Controls.Add(this.txtValorRecebido);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Decrypt";
            this.Text = "Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.TextBox txtValorResultado;
        private System.Windows.Forms.Button btnDecrypt;
    }
}