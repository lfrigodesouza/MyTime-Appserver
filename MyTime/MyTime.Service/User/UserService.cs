using System;
using MyTime.Repository;
using MyTime.Domain;

namespace MyTime.Service
{
    public class UserService : IBaseService<TBLUser>
    {
        public IBaseRepository<TBLUser> _repository { get; set; }
        public UserService(IBaseRepository<TBLUser> repository)
        {
            _repository = repository;
        }

        public TBLUser GetById(int pId)
        {
           return _repository.GetById(pId);
        }
    }
}
