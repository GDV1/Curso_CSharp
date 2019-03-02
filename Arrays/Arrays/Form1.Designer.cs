namespace Arrays
{
    partial class Form1
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
            this.btnVetor = new System.Windows.Forms.Button();
            this.btnTextos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVetor
            // 
            this.btnVetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetor.Location = new System.Drawing.Point(108, 40);
            this.btnVetor.Name = "btnVetor";
            this.btnVetor.Size = new System.Drawing.Size(182, 79);
            this.btnVetor.TabIndex = 0;
            this.btnVetor.Text = "Teste Vetor";
            this.btnVetor.UseVisualStyleBackColor = true;
            this.btnVetor.Click += new System.EventHandler(this.btnVetor_Click);
            // 
            // btnTextos
            // 
            this.btnTextos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextos.Location = new System.Drawing.Point(108, 174);
            this.btnTextos.Name = "btnTextos";
            this.btnTextos.Size = new System.Drawing.Size(182, 79);
            this.btnTextos.TabIndex = 1;
            this.btnTextos.Text = "Vetor Textos";
            this.btnTextos.UseVisualStyleBackColor = true;
            this.btnTextos.Click += new System.EventHandler(this.btnTextos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 316);
            this.Controls.Add(this.btnTextos);
            this.Controls.Add(this.btnVetor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVetor;
        private System.Windows.Forms.Button btnTextos;
    }
}

