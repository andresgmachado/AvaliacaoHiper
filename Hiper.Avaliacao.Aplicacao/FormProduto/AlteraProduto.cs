using Hiper.Avaliacao.Business.Business;
using Hiper.Avaliacao.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiper.Avaliacao.Aplicacao.FormProduto
{
    public partial class AlteraProduto : Form
    {
        public ProdutoBO produtoBO;
        public int IdProdutoEditar;
        Produto produto;

        string URI = "https://localhost:44394/api/ProdutoModel";


        private async void UpdateProduto(Produto produto)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI , produto);
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível salvar na API");
            }

        }

        public AlteraProduto()
        {
            InitializeComponent();
        }



        private void AlteraProduto_Load(object sender, EventArgs e)
        {
            this.Tnome.Text = "";
            this.Testoque.Text = "";
            this.Tpreco.Text = "";
            if (IdProdutoEditar > 0)
            {
                produto = produtoBO.BuscarProdutoPorId(IdProdutoEditar);
                if (produto != null)
                    this.Tnome.Text = produto.Nome;
                    this.Tpreco.Text = Convert.ToString(produto.Preco);
                    this.Testoque.Text = Convert.ToString(produto.Estoque);
            }
            else
            {
                this.Close();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.Tnome.Text))
            {
                if (produto != null)
                {
                    produto.Nome = this.Tnome.Text;
                    produto.Preco = Convert.ToDecimal(this.Tpreco.Text);
                    produto.Estoque = Convert.ToDecimal(this.Testoque.Text);
                    Exception exc;
                    if (produtoBO.UpdateProduto(produto, out exc))
                    {
                        UpdateProduto(produto);
                        MessageBox.Show("Produto Alterado Com Sucesso");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar nova situacao - ERRO:[ " + exc.Message + "]");
                    }
                }
            }
            else
            {
                MessageBox.Show("Não foi informado nenhuma descrição.");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.Tnome.Text = "";
            this.Testoque.Text = "";
            this.Tpreco.Text = "";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
