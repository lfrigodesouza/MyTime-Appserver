using System;
using MyTime.Repository;
using MyTime.Domain;

namespace MyTime.Service
{
    public class UserService
    {
        public TBLUser GetById(int pId)
        {
            using (var _rep = new Repository.UserRepository())
            {
                return _rep.GetById(pId);
            }
        }
    }
}
