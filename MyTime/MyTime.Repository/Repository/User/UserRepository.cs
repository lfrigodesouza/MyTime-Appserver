using MyTime.Domain;

namespace MyTime.Repository
{
    public class UserRepository : BaseRepository<TBLUser>, IUserRepository
    {
        public UserRepository(MyTimeDbContext context) : base(context)
        {
        }
    }
}