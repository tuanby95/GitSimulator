using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Service.OrganizationService
{
    public class OrganizationService : BaseService<Organization>, IOrganizationService
    {
        public OrganizationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
