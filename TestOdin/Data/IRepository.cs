using System;
using System.Collections.Generic;

namespace TestOdin.Data
{
    public interface IRepository<T>:IDisposable  where T : IEntity
    {
        bool Add(T data);
        bool AddUpdate(T data);
        bool Delete(T data);
        IEnumerable<T> GetAll();
    }
}