using Abstraction.Core;
using Laserlab.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Laserlab.Data.Access;

namespace Laserlab.Data.Service
{
    public class LaserlabRepository : IRepository
    {
        private readonly LaserlabContext _ctx;
        public LaserlabRepository()
        {
            _ctx = new LaserlabContext();
        }
        public IEnumerable<Entity> GetAll<Entity>() where Entity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entity> GetBy<Entity>(Expression<Func<Entity, bool>> condition) where Entity : class
        {
            throw new NotImplementedException();
        }
    }
}
