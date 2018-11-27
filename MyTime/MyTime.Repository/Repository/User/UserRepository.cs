using MyTime.Domain;

namespace MyTime.Repository
{
    public class UserRepository : BaseRepository<TBLUser>
    {
        public UserRepository(MyTimeDbContext context) : base(context)
        {
        }
    }
}