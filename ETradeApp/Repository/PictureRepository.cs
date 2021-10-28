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
    public class PictureRepository : IPictureRepository
    {
        private ETradeAppContext _eTradeAppContext;
        public PictureRepository(ETradeAppContext eTradeAppContext)
        {
            _eTradeAppContext = eTradeAppContext;
        }
        public void Add(Picture entity)
        {
            var addedEntity = _eTradeAppContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            _eTradeAppContext.SaveChanges();
        }

        public void Delete(Picture entity)
        {
            var deletedEntity = _eTradeAppContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _eTradeAppContext.SaveChanges();
        }

        public Picture Get(Expression<Func<Picture, bool>> filter)
        {
            return _eTradeAppContext.Pictures.FirstOrDefault(filter);
        }

        public List<Picture> GetList(Expression<Func<Picture, bool>> filter = null)
        {
            return filter == null
                ? _eTradeAppContext.Pictures.ToList()
                : _eTradeAppContext.Pictures.Where(filter).ToList();
        }

        public void Update(Picture entity)
        {
            var updatedEntity = _eTradeAppContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _eTradeAppContext.SaveChanges();
        }
    }
}
