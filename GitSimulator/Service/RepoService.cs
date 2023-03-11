using GitSimulator.DAL.Repository;
using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;

namespace GitSimulator.Service
{
    public class RepoService
    {
        public IUnitOfWork  _unitOfWork;
        public RepoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
