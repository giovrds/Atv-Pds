namespace AppFornecedor
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
            this.btListar = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.Color.White;
            this.btListar.Font = new System.Drawing.Font("Elephant", 9F);
            this.btListar.Location = new System.Drawing.Point(48, 97);
            this.btListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(368, 32);
            this.btListar.TabIndex = 21;
            this.btListar.Text = "Listar Fornecedores";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // btCadastro
            // 
            this.btCadastro.BackColor = System.Drawing.Color.White;
            this.btCadastro.Font = new System.Drawing.Font("Elephant", 9F);
            this.btCadastro.Location = new System.Drawing.Point(48, 48);
            this.btCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(368, 32);
            this.btCadastro.TabIndex = 22;
            this.btCadastro.Text = "Cadastrar Fornecedor";
            this.btCadastro.UseVisualStyleBackColor = false;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Giovanna Rodrigues de Souza - 3ºA Informática";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(474, 199);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.btListar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Label label10;
    }
}

