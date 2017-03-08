using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laserlab.Data.Access;
using System.Data.Entity;
using Abstraction.Core;
using System.Linq.Expressions;

namespace Laserlab.Service
{
    public class LaserlabService<entity>:IService<entity>, IDisposable where entity:class 
    {
        private LaserlabContext _ctx;
        public LaserlabService()
        {
            _ctx = new LaserlabContext();           
        }
        public IEnumerable<entity> GetAll()
        {
          return  _ctx.Set<entity>().ToList();
        }
        public IEnumerable<entity> GetBy(Expression<Func<entity, bool>> entityPredicate) 
        {
            return _ctx.Set<entity>().Where(entityPredicate).ToList();
        }
        public entity Find(Expression<Func<entity, bool>> entityPredicate)
        {
          return  _ctx.Set<entity>().Find(entityPredicate);
        }

        public bool Insert(entity entity)
        {
            try
            {
                _ctx.Set<entity>().Add(entity);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                // todo: log errors via Nlog 
                return false;
            }          
        }

        public bool Delete(entity entity)
        {
            try
            {
                _ctx.Set<entity>().Remove(entity);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                // todo: log errors via Nlog 
                return false;
            }
            
        }

        public bool InsertRange(IEnumerable<entity> entityRange)
        {
            try
            {
                _ctx.Set<entity>().AddRange(entityRange);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                string stackTrace = e.StackTrace.ToString();
                throw new Exception(stackTrace);
                // todo: log errors via Nlog 
            }
        }

        public bool DeleteRange(IEnumerable<entity> entityRange)
        {
            try
            {
                _ctx.Set<entity>().RemoveRange(entityRange);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                // todo: log errors via Nlog 
                return false;
            }
        }

        public bool InjectTSQL(StringBuilder command, object[] parameters = null)
        {
            int isSuccessful;
            isSuccessful =  _ctx.Database.ExecuteSqlCommand(command.ToString(), parameters);
            return isSuccessful > 0 ? true : false; // todo: catch the sql exception
        }
        public bool InjectTSQL(string command)
        {
            int isSuccessful;
            isSuccessful = _ctx.Database.ExecuteSqlCommand(command);
            return isSuccessful > 0 ? true : false;
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
        // ~LaserlabService() {
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
