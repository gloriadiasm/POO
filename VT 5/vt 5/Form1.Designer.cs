namespace vt_5
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
            this.textBoxQuantidadeAlunos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNotaAluno = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelQuantidadeNotas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCorte = new System.Windows.Forms.TextBox();
            this.buttonCalcularMedia = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMediaNotasCorte = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMediatotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "quantidade de alunos :";
            // 
            // textBoxQuantidadeAlunos
            // 
            this.textBoxQuantidadeAlunos.Location = new System.Drawing.Point(149, 48);
            this.textBoxQuantidadeAlunos.Name = "textBoxQuantidadeAlunos";
            this.textBoxQuantidadeAlunos.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidadeAlunos.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nota Do Aluno:";
            // 
            // textBoxNotaAluno
            // 
            this.textBoxNotaAluno.Location = new System.Drawing.Point(149, 47);
            this.textBoxNotaAluno.Name = "textBoxNotaAluno";
            this.textBoxNotaAluno.Size = new System.Drawing.Size(100, 20);
            this.textBoxNotaAluno.TabIndex = 6;
            this.textBoxNotaAluno.TextChanged += new System.EventHandler(this.textBoxNotaAluno_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Inserir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade de notas Inseridas :";
            // 
            // labelQuantidadeNotas
            // 
            this.labelQuantidadeNotas.AutoSize = true;
            this.labelQuantidadeNotas.Location = new System.Drawing.Point(202, 113);
            this.labelQuantidadeNotas.Name = "labelQuantidadeNotas";
            this.labelQuantidadeNotas.Size = new System.Drawing.Size(16, 13);
            this.labelQuantidadeNotas.TabIndex = 9;
            this.labelQuantidadeNotas.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Média";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nota De Corte :";
            // 
            // textBoxCorte
            // 
            this.textBoxCorte.Location = new System.Drawing.Point(149, 49);
            this.textBoxCorte.Name = "textBoxCorte";
            this.textBoxCorte.Size = new System.Drawing.Size(100, 20);
            this.textBoxCorte.TabIndex = 12;
            // 
            // buttonCalcularMedia
            // 
            this.buttonCalcularMedia.Location = new System.Drawing.Point(291, 49);
            this.buttonCalcularMedia.Name = "buttonCalcularMedia";
            this.buttonCalcularMedia.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcularMedia.TabIndex = 13;
            this.buttonCalcularMedia.Text = "Calcular";
            this.buttonCalcularMedia.UseVisualStyleBackColor = true;
            this.buttonCalcularMedia.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Média das notas acima do valor de corte :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelMediaNotasCorte
            // 
            this.labelMediaNotasCorte.AutoSize = true;
            this.labelMediaNotasCorte.Location = new System.Drawing.Point(214, 113);
            this.labelMediaNotasCorte.Name = "labelMediaNotasCorte";
            this.labelMediaNotasCorte.Size = new System.Drawing.Size(16, 13);
            this.labelMediaNotasCorte.TabIndex = 15;
            this.labelMediaNotasCorte.Text = "...";
            this.labelMediaNotasCorte.Click += new System.EventHandler(this.labelMediaNotasCorte_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Média total das notas:";
            // 
            // labelMediatotal
            // 
            this.labelMediatotal.AutoSize = true;
            this.labelMediatotal.Location = new System.Drawing.Point(120, 136);
            this.labelMediatotal.Name = "labelMediatotal";
            this.labelMediatotal.Size = new System.Drawing.Size(16, 13);
            this.labelMediatotal.TabIndex = 17;
            this.labelMediatotal.Text = "...";
            this.labelMediatotal.Click += new System.EventHandler(this.labelMediatotal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxQuantidadeAlunos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 119);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelQuantidadeNotas);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBoxNotaAluno);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(20, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 143);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCalcularMedia);
            this.panel3.Controls.Add(this.textBoxCorte);
            this.panel3.Controls.Add(this.labelMediatotal);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.labelMediaNotasCorte);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(20, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 161);
            this.panel3.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantidadeAlunos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNotaAluno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelQuantidadeNotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCorte;
        private System.Windows.Forms.Button buttonCalcularMedia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMediaNotasCorte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelMediatotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

