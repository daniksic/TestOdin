using System;
using System.Collections.Generic;

namespace TestOdin.Data
{
    public abstract class RepositoryBase<T> : IRepository<T> where T :IEntity
    {
        private List<T> _list;
        bool disposed = false;

        protected RepositoryBase(IEnumerable<T> list)
        {
            _list = list as List<T>;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _list;
        }

        public virtual bool Add(T data)
        {
            _list.Add(data);
            return true;
        }

        public virtual bool AddUpdate(T data)
        {
            _list.RemoveAll(p => p.Id == data.Id);
            _list.Add(data);

            return true;
        }

        public virtual bool Delete(T data)
        {
            _list.Remove(data);
            return true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here. 
                //
            }

            // Free any unmanaged objects here. 
            //
            disposed = true;
        }

    }
}
