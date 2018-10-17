namespace Exercicio_2_vt2
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
            this.carroNovoBox = new System.Windows.Forms.TextBox();
            this.carroUsadoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.parcelaBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pagarLabel = new System.Windows.Forms.Label();
            this.parcelaLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carroNovoBox
            // 
            this.carroNovoBox.Location = new System.Drawing.Point(105, 12);
            this.carroNovoBox.Name = "carroNovoBox";
            this.carroNovoBox.Size = new System.Drawing.Size(43, 20);
            this.carroNovoBox.TabIndex = 0;
            // 
            // carroUsadoBox
            // 
            this.carroUsadoBox.Location = new System.Drawing.Point(105, 45);
            this.carroUsadoBox.Name = "carroUsadoBox";
            this.carroUsadoBox.Size = new System.Drawing.Size(43, 20);
            this.carroUsadoBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor carro novo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor carro usado:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcula!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // parcelaBox
            // 
            this.parcelaBox.FormattingEnabled = true;
            this.parcelaBox.Items.AddRange(new object[] {
            "x1",
            "x12",
            "x24"});
            this.parcelaBox.Location = new System.Drawing.Point(-1, 109);
            this.parcelaBox.Name = "parcelaBox";
            this.parcelaBox.Size = new System.Drawing.Size(202, 21);
            this.parcelaBox.TabIndex = 9;
            this.parcelaBox.Text = "Selecione uma forma de pagamento;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total a pagar em R$:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor das parcelas R$:";
            // 
            // pagarLabel
            // 
            this.pagarLabel.AutoSize = true;
            this.pagarLabel.Location = new System.Drawing.Point(150, 169);
            this.pagarLabel.Name = "pagarLabel";
            this.pagarLabel.Size = new System.Drawing.Size(0, 13);
            this.pagarLabel.TabIndex = 12;
            // 
            // parcelaLabel
            // 
            this.parcelaLabel.AutoSize = true;
            this.parcelaLabel.Location = new System.Drawing.Point(151, 214);
            this.parcelaLabel.Name = "parcelaLabel";
            this.parcelaLabel.Size = new System.Drawing.Size(0, 13);
            this.parcelaLabel.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(319, 287);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.parcelaLabel);
            this.Controls.Add(this.pagarLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parcelaBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carroUsadoBox);
            this.Controls.Add(this.carroNovoBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox carroNovoBox;
        private System.Windows.Forms.TextBox carroUsadoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox parcelaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pagarLabel;
        private System.Windows.Forms.Label parcelaLabel;
        private System.Windows.Forms.Button button2;
    }
}

