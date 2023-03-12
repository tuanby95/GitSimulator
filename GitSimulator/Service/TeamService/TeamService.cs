using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Service.TeamService
{
    public class TeamService : BaseService<Team>, ITeamService
    {
        public TeamService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
