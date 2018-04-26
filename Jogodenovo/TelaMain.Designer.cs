namespace Jogodenovo
{
    partial class TelaMain
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
            this.btniniciar = new System.Windows.Forms.Button();
            this.tBmostrar1 = new System.Windows.Forms.TextBox();
            this.lblversao = new System.Windows.Forms.Label();
            this.tBmostrar2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(153, 177);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(105, 42);
            this.btniniciar.TabIndex = 0;
            this.btniniciar.Text = "Clique agora";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // tBmostrar1
            // 
            this.tBmostrar1.Location = new System.Drawing.Point(85, 136);
            this.tBmostrar1.Name = "tBmostrar1";
            this.tBmostrar1.Size = new System.Drawing.Size(100, 20);
            this.tBmostrar1.TabIndex = 1;
            // 
            // lblversao
            // 
            this.lblversao.AutoSize = true;
            this.lblversao.Location = new System.Drawing.Point(150, 271);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(0, 13);
            this.lblversao.TabIndex = 2;
            this.lblversao.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // tBmostrar2
            // 
            this.tBmostrar2.Location = new System.Drawing.Point(233, 136);
            this.tBmostrar2.Name = "tBmostrar2";
            this.tBmostrar2.Size = new System.Drawing.Size(100, 20);
            this.tBmostrar2.TabIndex = 3;
            this.tBmostrar2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TelaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 360);
            this.Controls.Add(this.tBmostrar2);
            this.Controls.Add(this.lblversao);
            this.Controls.Add(this.tBmostrar1);
            this.Controls.Add(this.btniniciar);
            this.Name = "TelaMain";
            this.Text = "TelaMain";
            this.Load += new System.EventHandler(this.Tinicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.TextBox tBmostrar1;
        private System.Windows.Forms.Label lblversao;
        private System.Windows.Forms.TextBox tBmostrar2;
    }
}

