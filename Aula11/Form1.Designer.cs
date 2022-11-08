namespace Aula11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.btnferias = new System.Windows.Forms.Button();
            this.btninss = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.Label();
            this.btncomissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempo de serviço(meses)";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(147, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(488, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(147, 105);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(488, 20);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(321, 149);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(314, 20);
            this.txtTempo.TabIndex = 3;
            this.txtTempo.TextChanged += new System.EventHandler(this.txtTempo_TextChanged);
            // 
            // btnferias
            // 
            this.btnferias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnferias.Location = new System.Drawing.Point(83, 268);
            this.btnferias.Name = "btnferias";
            this.btnferias.Size = new System.Drawing.Size(180, 47);
            this.btnferias.TabIndex = 4;
            this.btnferias.Text = "Calcular Férias";
            this.btnferias.UseVisualStyleBackColor = true;
            this.btnferias.Click += new System.EventHandler(this.button1_Click);
            // 
            // btninss
            // 
            this.btninss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninss.Location = new System.Drawing.Point(269, 268);
            this.btninss.Name = "btninss";
            this.btninss.Size = new System.Drawing.Size(180, 47);
            this.btninss.TabIndex = 4;
            this.btninss.Text = "Calcular INSS";
            this.btninss.UseVisualStyleBackColor = true;
            this.btninss.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.AutoSize = true;
            this.txtvalor.Location = new System.Drawing.Point(337, 221);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(0, 13);
            this.txtvalor.TabIndex = 5;
            // 
            // btncomissao
            // 
            this.btncomissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomissao.Location = new System.Drawing.Point(455, 268);
            this.btncomissao.Name = "btncomissao";
            this.btncomissao.Size = new System.Drawing.Size(180, 47);
            this.btncomissao.TabIndex = 6;
            this.btncomissao.Text = "Calcular comissão";
            this.btncomissao.UseVisualStyleBackColor = true;
            this.btncomissao.Click += new System.EventHandler(this.btncomissao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(708, 394);
            this.Controls.Add(this.btncomissao);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btninss);
            this.Controls.Add(this.btnferias);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Button btnferias;
        private System.Windows.Forms.Button btninss;
        private System.Windows.Forms.Label txtvalor;
        private System.Windows.Forms.Button btncomissao;
    }
}

