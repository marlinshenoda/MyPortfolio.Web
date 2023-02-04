using MyPortfolio.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Data.Repository
{
    public class UnitOfWork<T> : IunitOfWork<T> where T : class
    {
        private readonly MyPortolioContext _context;
        private IGenericRepository<T> _entity;

        public UnitOfWork(MyPortolioContext context)
        {
            _context = context;
        }
        public IGenericRepository<T> Entity
        {
            get
            {
                return _entity ?? (_entity = new GenericRepository<T>(_context));
            }

        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
