using System;
using System.Collections.Generic;
using System.Text;

namespace MyTime.Service.Generic
{
    interface IBaseService<T>
    {
        T Insert(T pItem);
        T Update(T pItem);
        T Delete(T pItem);
        T GetById(int pId);
        T GetByCode(string pCode);
        IList<T> ListAll();
    }
}
