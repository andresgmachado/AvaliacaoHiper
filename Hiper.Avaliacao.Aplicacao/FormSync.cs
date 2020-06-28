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
    public partial class FormSync : Form
    {


        private async void GetAllProdutos()
        {

            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync("https://localhost:44394/api/ProdutoModel"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                            dgvDados.DataSource = JsonConvert.DeserializeObject<Produto[]>(ProdutoJsonString).ToList();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível conectar a API");
            }
        }


        public FormSync()
        {
            InitializeComponent();
        }

        private void FormSync_Load(object sender, EventArgs e)
        {
            GetAllProdutos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             GetAllProdutos();

           
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
