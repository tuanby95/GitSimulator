using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;

namespace GitSimulator.Service.GitFileService
{
    public class GitFileService : BaseService<GitFile>, IGitFileService
    {
        public GitFileService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
