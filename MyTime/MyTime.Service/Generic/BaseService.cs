using MyTime.Repository;
using System;

namespace MyTime.Service.Generic
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected readonly IBaseRepository<T> _repository;
        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public T GetById(int pId)
        {
            return _repository.GetById(pId);
        }
    }

}