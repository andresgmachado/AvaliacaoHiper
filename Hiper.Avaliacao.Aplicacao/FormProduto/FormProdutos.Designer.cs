namespace Hiper.Avaliacao.Aplicacao.FormProduto
{
    partial class FormProdutos
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GridProduto = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduto)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 474);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(385, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // GridProduto
            // 
            this.GridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduto.Location = new System.Drawing.Point(12, 120);
            this.GridProduto.Name = "GridProduto";
            this.GridProduto.Size = new System.Drawing.Size(364, 245);
            this.GridProduto.TabIndex = 1;
            this.GridProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProduto_CellClick_1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(385, 100);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCadastrar.Image = global::Hiper.Avaliacao.Aplicacao.Properties.Resources.pluscircleflat_105960;
            this.BtnCadastrar.Location = new System.Drawing.Point(12, 393);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(116, 63);
            this.BtnCadastrar.TabIndex = 1;
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEditar.Image = global::Hiper.Avaliacao.Aplicacao.Properties.Resources.pencilflat_106027;
            this.BtnEditar.Location = new System.Drawing.Point(139, 393);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(115, 62);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSair.Image = global::Hiper.Avaliacao.Aplicacao.Properties.Resources.undoflat_106020;
            this.BtnSair.Location = new System.Drawing.Point(268, 393);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(108, 62);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 474);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.GridProduto);
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Activated += new System.EventHandler(this.FormProdutos_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProdutos_FormClosed);
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProduto)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView GridProduto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
    }
}