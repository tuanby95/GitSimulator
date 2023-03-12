using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;

namespace GitSimulator.Service.BranchService
{
    public class BranchService : BaseService<Branch>, IBranchService
    {
        public BranchService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}