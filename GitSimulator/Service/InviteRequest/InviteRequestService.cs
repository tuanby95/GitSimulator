using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Service.InviteRequestService
{
    public class InviteRequestService : BaseService<InviteRequest>, IInviteService
    {
        public InviteRequestService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
