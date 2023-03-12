using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;

namespace GitSimulator.Service.PullRequestService
{
    public class PullRequestService : BaseService<PullRequest>, IPullRequestService
    {
        public PullRequestService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}