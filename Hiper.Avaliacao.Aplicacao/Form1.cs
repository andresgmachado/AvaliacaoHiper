using Hiper.Avaliacao.Aplicacao.FormProduto;
using System;
using System.Windows.Forms;


namespace Hiper.Avaliacao.Aplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProdutos frm = new FormProdutos();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSync frm = new FormSync();
            frm.Show();
        }
    }
}
