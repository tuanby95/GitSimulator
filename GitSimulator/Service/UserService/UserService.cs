using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;

namespace GitSimulator.Service.UserService
{
    public class UserServices : BaseService<User>, IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        internal User GetUser(int creatorId)
        {
            return _unitOfWork.UserRepository.GetById(creatorId);
        }
    }
}
