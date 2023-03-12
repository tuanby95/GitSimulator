using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitSimulator.Service.UserService;

namespace GitSimulator.Service.TeamService
{
    public class TeamService : BaseService<Team>, ITeamService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TeamService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Team CreateTeam(int creatorId, string name, string description)
        {
            var userService = new UserServices(_unitOfWork);
            User creator = userService.GetUser(creatorId);
            var members = new List<User>() { creator };

            Team newTeam = new()
            {
                Description = description,
                Name = name,
                IsParentTeam = true,
                Members = members,
            };
            _unitOfWork.TeamRepository.Create(newTeam);
            _unitOfWork.Save();
            return newTeam;
        }
    }
}
