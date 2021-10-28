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
    public class CategoryRepository : ICategoryRepository
    {
        private ETradeAppContext _eTradeAppContext;
        public CategoryRepository(ETradeAppContext eTradeAppContext)
        {
            _eTradeAppContext = eTradeAppContext;
        }
        public void Add(Category entity)
        {
            var addedEntity = _eTradeAppContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            _eTradeAppContext.SaveChanges();
        }

        public void Delete(Category entity)
        {
            var deletedEntity = _eTradeAppContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _eTradeAppContext.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _eTradeAppContext.Categories.FirstOrDefault(filter);
        }

        public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null
                ? _eTradeAppContext.Categories.Include(x => x.Products).ToList()
                : _eTradeAppContext.Categories.Include(x => x.Products).Where(filter).ToList();
        }

        public void Update(Category entity)
        {
            var updatedEntity = _eTradeAppContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _eTradeAppContext.SaveChanges();
        }
    }
}
