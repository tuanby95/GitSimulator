using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;

namespace GitSimulator.Service.UserService
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
