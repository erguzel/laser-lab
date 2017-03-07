using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Abstraction.Core;

namespace GenericRepositoryEF
{
    public class UnitOfWork<T> where T : DbContext
    {
        private readonly T _ctx;

        public UnitOfWork(T dbContext)
        {
            _ctx = dbContext;

        }
        public IRepository EntityRepo { get { return new EntityRepository(_ctx); } }
        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }
    }
}

