using GitSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.DAL.Repository.InviteRequestRepository
{
    public class InviteRequestRepository : GenericRepository<InviteRequest>, IInviteRequestRepository
    {
        public InviteRequestRepository(GitContext context) : base(context)
        {
        }
    }
}
