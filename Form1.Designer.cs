
namespace ButDeConversa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSair = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboAssunto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDificuldade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(713, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(9, 38);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(168, 23);
            this.textNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira seu nome";
            // 
            // comboAssunto
            // 
            this.comboAssunto.FormattingEnabled = true;
            this.comboAssunto.Items.AddRange(new object[] {
            "Escola",
            "Família",
            "Amigos",
            "Dinheiro"});
            this.comboAssunto.Location = new System.Drawing.Point(9, 113);
            this.comboAssunto.Name = "comboAssunto";
            this.comboAssunto.Size = new System.Drawing.Size(168, 23);
            this.comboAssunto.TabIndex = 3;
            this.comboAssunto.Text = "Escola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sobre o que você quer falar?";
            // 
            // comboDificuldade
            // 
            this.comboDificuldade.FormattingEnabled = true;
            this.comboDificuldade.Items.AddRange(new object[] {
            "Nota baixa",
            "Bullying",
            "Sobrecarga de atividades",
            "Transporte inacessível",
            "Merenda ruim",
            "Salas muito quentes ",
            "Professor ruim"});
            this.comboDificuldade.Location = new System.Drawing.Point(9, 195);
            this.comboDificuldade.Name = "comboDificuldade";
            this.comboDificuldade.Size = new System.Drawing.Size(165, 23);
            this.comboDificuldade.TabIndex = 5;
            this.comboDificuldade.Text = "Nota ruim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qual  é a sua dificuldade?";
            // 
            // BtnExecutar
            // 
            this.BtnExecutar.Location = new System.Drawing.Point(57, 238);
            this.BtnExecutar.Name = "BtnExecutar";
            this.BtnExecutar.Size = new System.Drawing.Size(75, 23);
            this.BtnExecutar.TabIndex = 7;
            this.BtnExecutar.Text = "Executar";
            this.BtnExecutar.UseVisualStyleBackColor = true;
            this.BtnExecutar.Click += new System.EventHandler(this.BtnExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExecutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboDificuldade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboAssunto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.BtnSair);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDificuldade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnExecutar;
    }
}

