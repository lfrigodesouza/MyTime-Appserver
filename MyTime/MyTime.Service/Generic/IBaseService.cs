using System;

namespace MyTime.Service
{
    public interface IBaseService<T>
    {
        T GetById(int pId);
    }
    
}