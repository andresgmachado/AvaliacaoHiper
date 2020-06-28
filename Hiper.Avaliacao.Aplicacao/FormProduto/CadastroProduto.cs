using Hiper.Avaliacao.Business.Business;
using Hiper.Avaliacao.Models;
using Newtonsoft.Json;
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

namespace Hiper.Avaliacao.Aplicacao
{
    public partial class CadastroProduto : Form
    {
        ProdutoBO produtoBO;
        string URI = "https://localhost:44394/api/ProdutoModel";

        private async void AddProduto(Produto produto)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var serializedProduto = JsonConvert.SerializeObject(produto);
                    var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(URI, content);
                }
            } catch
            {
                MessageBox.Show("Não foi possível salvar na API");
            }
          
        }

        public CadastroProduto()
        {
            InitializeComponent();
        }


        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            produtoBO = new ProdutoBO(); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Tnome.Text.Equals(""))
            {
                MessageBox.Show("O campo Nome é obrigatório");
            }
            else
            {
                Produto produto = new Produto()
                {
                    Nome = Tnome.Text,
                    Preco = Convert.ToDecimal(Tpreco.Text),
                    Estoque = Convert.ToDecimal(Testoque.Text)
                };
                Exception exc;
                if (produtoBO.NovoProduto(produto, out exc))
                {
                    MessageBox.Show("Salvo com sucesso.");
                    AddProduto(produto);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar o produto - ERRO:[ " + exc.Message + "]");
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Tnome.Clear();
            Tpreco.Clear();
            Testoque.Clear();
        }
    }
}
