using Abstraction.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Generic
{
    public class EntityRepository : IRepository, IDisposable
    {
        private readonly DbContext _cntx;
        public EntityRepository(DbContext dbContext)
        {
            _cntx = dbContext;
        }

        public IEnumerable<Entity> GetAll<Entity>() where Entity : class
        {
            return _cntx.Set<Entity>().ToList();
        }

        public IEnumerable<Entity> GetBy<Entity>(Expression<Func<Entity, bool>> entityPredicate) where Entity : class
        {
            return _cntx.Set<Entity>().Where(entityPredicate).ToList();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.Dispose();
                    GC.Collect();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~EntityRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
