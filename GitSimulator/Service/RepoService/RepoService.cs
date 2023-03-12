using GitSimulator.DAL.Repository;
using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;
using Microsoft.EntityFrameworkCore;

namespace GitSimulator.Service.RepoService
{
    public class RepoService : BaseService<Repo>, IRepoService
    {

        public RepoService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
