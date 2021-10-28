using ETradeApp.Contexts;
using ETradeApp.Models;
using ETradeApp.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ETradeApp.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ETradeAppContext _eTradeAppContext;
        public ProductRepository(ETradeAppContext eTradeAppContext)
        {
            _eTradeAppContext = eTradeAppContext;
        }

        public void Add(Product entity)
        {
            var addedEntity = _eTradeAppContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            _eTradeAppContext.SaveChanges();
        }

        public void Delete(Product entity)
        {
            var deletedEntity = _eTradeAppContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _eTradeAppContext.SaveChanges();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _eTradeAppContext.Products.Include(x => x.Category).Include(x => x.Pictures).FirstOrDefault(filter);
        }

        public List<Product> GetList(Expression<Func<Product, bool>> filter = null)
        {
            return filter == null
                ? _eTradeAppContext.Products.Include(x => x.Category).Include(x => x.Pictures).ToList()
                : _eTradeAppContext.Products.Include(x => x.Category).Include(x => x.Pictures).Where(filter).ToList();
        }

        public void Update(Product entity)
        {
            var updatedEntity = _eTradeAppContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _eTradeAppContext.SaveChanges();
        }
    }
}
