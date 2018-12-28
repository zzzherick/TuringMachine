namespace Turing
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
            this.boxDiv = new System.Windows.Forms.CheckBox();
            this.boxIgualdade = new System.Windows.Forms.CheckBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textFita = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // boxDiv
            // 
            this.boxDiv.AutoSize = true;
            this.boxDiv.Location = new System.Drawing.Point(12, 12);
            this.boxDiv.Name = "boxDiv";
            this.boxDiv.Size = new System.Drawing.Size(61, 17);
            this.boxDiv.TabIndex = 0;
            this.boxDiv.Text = "Divisão";
            this.boxDiv.UseVisualStyleBackColor = true;
            this.boxDiv.CheckedChanged += new System.EventHandler(this.boxDiv_CheckedChanged);
            // 
            // boxIgualdade
            // 
            this.boxIgualdade.AutoSize = true;
            this.boxIgualdade.Location = new System.Drawing.Point(98, 12);
            this.boxIgualdade.Name = "boxIgualdade";
            this.boxIgualdade.Size = new System.Drawing.Size(73, 17);
            this.boxIgualdade.TabIndex = 1;
            this.boxIgualdade.Text = "Igualdade";
            this.boxIgualdade.UseVisualStyleBackColor = true;
            this.boxIgualdade.CheckedChanged += new System.EventHandler(this.boxIgualdade_CheckedChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(177, 33);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 2;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(12, 35);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(61, 20);
            this.textNum1.TabIndex = 3;
            this.textNum1.Text = "nº 1";
            // 
            // textNum2
            // 
            this.textNum2.BackColor = System.Drawing.Color.White;
            this.textNum2.Location = new System.Drawing.Point(98, 35);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(61, 20);
            this.textNum2.TabIndex = 4;
            this.textNum2.Text = "nº 2";
            this.textNum2.TextChanged += new System.EventHandler(this.textNum2_TextChanged);
            // 
            // textFita
            // 
            this.textFita.Location = new System.Drawing.Point(12, 87);
            this.textFita.Multiline = true;
            this.textFita.Name = "textFita";
            this.textFita.Size = new System.Drawing.Size(557, 26);
            this.textFita.TabIndex = 5;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(12, 119);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 6;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(79, 38);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(13, 13);
            this.lblOperador.TabIndex = 7;
            this.lblOperador.Text = "?";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(12, 59);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(247, 13);
            this.lblSeparator.TabIndex = 8;
            this.lblSeparator.Text = "________________________________________";
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(12, 148);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(557, 226);
            this.textArea.TabIndex = 9;
            this.textArea.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 386);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.textFita);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.boxIgualdade);
            this.Controls.Add(this.boxDiv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox boxDiv;
        private System.Windows.Forms.CheckBox boxIgualdade;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textFita;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.RichTextBox textArea;
    }
}

