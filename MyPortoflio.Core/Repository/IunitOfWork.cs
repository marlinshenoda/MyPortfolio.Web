using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Data.Repository
{
    public interface IunitOfWork<T>where T : class
    {
        IGenericRepository<T> Entity { get; }
        void Save();
    }
}
