using Hiper.Avaliacao.Business.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiper.Avaliacao.Aplicacao.FormProduto
{
    public partial class FormProdutos : Form
    {
        ProdutoBO produtoBO;
        public int IdProduto;
        AlteraProduto alteraProduto;


        public FormProdutos()
        {
            InitializeComponent();
        }

        void CarregarDadosNoGrid()
        {
            var lstSituacao = produtoBO.GetTodos();
            this.GridProduto.DataSource = null;
            this.GridProduto.Rows.Clear();
            this.GridProduto.Columns.Clear();
            //configurando datasource
            this.GridProduto.DataSource = lstSituacao;
            //ajustando as colunas por conteudo
            this.GridProduto.AutoResizeColumn(0);
            this.GridProduto.AutoResizeColumn(1);
            this.GridProduto.AutoResizeColumn(2);
            this.GridProduto.Refresh();
        }


        private void Produtos_Load(object sender, EventArgs e)
        {

            alteraProduto = new AlteraProduto();
            alteraProduto.FormClosed += FormProdutos_FormClosed;

            produtoBO = new ProdutoBO(); ;
            CarregarDadosNoGrid();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroProduto frm = new CadastroProduto();
            frm.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {



                try
                {
                    alteraProduto.produtoBO = this.produtoBO;
                    alteraProduto.IdProdutoEditar = IdProduto;
                    alteraProduto.ShowDialog();
                }
                catch (Exception)
                {

                    MessageBox.Show("Selecione um produto para ser editado");
                }

            



           // AlteraProduto frm = new AlteraProduto();
            //frm.Show();
        }

        private void GridProduto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           // int indiceLinha;
            try
            {
                //indiceLinha = e.RowIndex;
                IdProduto = (int)this.GridProduto[0, e.RowIndex].Value;
              //  MessageBox.Show(Convert.ToString(IdProduto));

            }
            catch
            {
               // indiceLinha = 1;
                IdProduto = 1;
               // MessageBox.Show(Convert.ToString(indiceLinha));
            }
        }

        private void FormProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDadosNoGrid();
        }

        private void FormProdutos_Activated(object sender, EventArgs e)
        {
            CarregarDadosNoGrid();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
