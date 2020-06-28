namespace Hiper.Avaliacao.Aplicacao.FormProduto
{
    partial class AlteraProduto
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.Testoque = new System.Windows.Forms.TextBox();
            this.Tpreco = new System.Windows.Forms.TextBox();
            this.Tnome = new System.Windows.Forms.TextBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(412, 100);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::Hiper.Avaliacao.Aplicacao.Properties.Resources.undoflat_106020;
            this.BtnCancelar.Location = new System.Drawing.Point(284, 291);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 58);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = global::Hiper.Avaliacao.Aplicacao.Properties.Resources.tool_eraser_115252;
            this.BtnLimpar.Location = new System.Drawing.Point(191, 291);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(87, 58);
            this.BtnLimpar.TabIndex = 14;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Testoque
            // 
            this.Testoque.Location = new System.Drawing.Point(203, 201);
            this.Testoque.Name = "Testoque";
            this.Testoque.Size = new System.Drawing.Size(156, 20);
            this.Testoque.TabIndex = 13;
            // 
            // Tpreco
            // 
            this.Tpreco.Location = new System.Drawing.Point(53, 201);
            this.Tpreco.Name = "Tpreco";
            this.Tpreco.Size = new System.Drawing.Size(144, 20);
            this.Tpreco.TabIndex = 12;
            // 
            // Tnome
            // 
            this.Tnome.Location = new System.Drawing.Point(53, 151);
            this.Tnome.Name = "Tnome";
            this.Tnome.Size = new System.Drawing.Size(306, 20);
            this.Tnome.TabIndex = 11;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Image = global::Hiper.Avaliacao.Aplicacao.Properties.Resources.icons8_sincronização_da_nuvem_48;
            this.BtnAlterar.Location = new System.Drawing.Point(65, 291);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(120, 58);
            this.BtnAlterar.TabIndex = 10;
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome do Produto";
            // 
            // AlteraProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 375);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.Testoque);
            this.Controls.Add(this.Tpreco);
            this.Controls.Add(this.Tnome);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AlteraProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlteraProduto";
            this.Load += new System.EventHandler(this.AlteraProduto_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TextBox Testoque;
        private System.Windows.Forms.TextBox Tpreco;
        private System.Windows.Forms.TextBox Tnome;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}