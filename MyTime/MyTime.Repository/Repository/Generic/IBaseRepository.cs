using System;
using System.Collections.Generic;
using System.Text;

namespace MyTime.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T Insert(T pItem);
        T Update(T pItem);
        void Delete(T pItem);
        T GetById(int pId);
        T GetByCode(string pCode);
        IList<T> ListAll();
    }
}
