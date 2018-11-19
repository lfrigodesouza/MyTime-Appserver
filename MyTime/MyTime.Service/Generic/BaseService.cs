using System;
using System.Collections.Generic;
using System.Text;

namespace MyTime.Service.Generic
{
    class BaseService<T> : IBaseService<T> where T : class
    {
        public T Delete(T pItem)
        {
            throw new NotImplementedException();
        }

        public T GetByCode(string pCode)
        {
            throw new NotImplementedException();
        }

        public T GetById(int pId)
        {
            throw new NotImplementedException();
        }

        public T Insert(T pItem)
        {
            throw new NotImplementedException();
        }

        public IList<T> ListAll()
        {
            throw new NotImplementedException();
        }

        public T Update(T pItem)
        {
            throw new NotImplementedException();
        }
    }
}
