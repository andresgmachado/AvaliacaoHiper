using Hiper.Avaliacao.Data.Context;
using Hiper.Avaliacao.Data.DAO;
using Hiper.Avaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiper.Avaliacao.Business.Business
{
    public class ProdutoBO
    {
        ProdutoDAO produtoDAO;
        HiperContext hiperContext;

        public ProdutoBO()
        {
            this.hiperContext = new HiperContext();
            produtoDAO = new ProdutoDAO(hiperContext);
        }

        public bool NovoProduto(Produto produto, out Exception exception)
        {
            try
            {
                produtoDAO.Insert(produto);

                exception = null;
                return true;
            }
            catch (Exception exc)
            {
                exception = exc;
                return false;
            }
        }


        public bool UpdateProduto(Produto produto, out Exception exception)
        {
            try
            {
                produtoDAO.Update(produto);

                exception = null;
                return true;
            }
            catch (Exception exc)
            {
                exception = exc;
                return false;
            }
        }


        public List<Produto> GetTodos()
        {
            try
            {
                return produtoDAO.Getwhere(x => x.Id > 0).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Produto BuscarProdutoPorId(long ID)
        {
            try
            {
                return this.produtoDAO.GetById(ID);

            }
            catch (Exception exc)
            {
                throw exc;
            }
        }


        public void Dispose()
        {
            this.produtoDAO.Dispose();
        }

    }
}
