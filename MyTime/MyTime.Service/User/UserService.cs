using System;
using MyTime.Repository;
using MyTime.Domain;
using MyTime.Service.Generic;

namespace MyTime.Service
{
    public class UserService : BaseService<TBLUser>, IUserService
    {
        public UserService(IUserRepository repository) : base(repository)
        {
        }
    }
}
