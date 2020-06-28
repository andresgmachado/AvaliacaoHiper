using Hiper.Avaliacao.Data.Context;
using Hiper.Avaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hiper.Avaliacao.Data.DAO
{
    public class ProdutoDAO
    {
        HiperContext Hipercontext;

        public ProdutoDAO(HiperContext context)
        {
            Hipercontext = context;
        }

        public void Dispose()
        {
            Hipercontext.Dispose();
        }

        public Produto Insert(Produto produto)
        {
            try
            {
                Produto ProdutoAdd = this.Hipercontext.Produto.Add(produto);
                Hipercontext.SaveChanges();
                return ProdutoAdd;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Produto Update(Produto produto)
        {
            try
            {
                this.Hipercontext.Entry(produto).State = System.Data.Entity.EntityState.Modified;

                this.Hipercontext.SaveChanges();

                return produto;

            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IQueryable<Produto> GetAll()
        {
            try
            {
                return this.Hipercontext.Produto.AsQueryable();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IQueryable<Produto> Getwhere(Expression<Func<Produto, bool>> predicate)
        {
            try
            {
                return this.Hipercontext.Produto.Where(predicate);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Produto GetById(long ID)
        {
            try
            {
                return this.Hipercontext.Produto.FirstOrDefault(st => st.Id == ID);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
