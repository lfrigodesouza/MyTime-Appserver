using System;

namespace MyTime.Service.Generic
{
    public interface IBaseService<T> where T : class
    {
        T GetById(int pId);
    }
    
}