using System;
using System.Collections.Generic;
using System.Text;

namespace MyTime.Repository
{
    public interface IBaseRepository<T>
    {
        T Insert(T pItem);
        T Update(T pItem);
        void Delete(T pItem);
        T GetById(int pId);
        T GetByCode(string pCode);
        IList<T> ListAll();
    }
}
