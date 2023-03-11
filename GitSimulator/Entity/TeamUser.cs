using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Entity
{
    internal class TeamUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TeamId { get; set; }
        public User User { get; set; }
        public Team Team { get; set; }

        public TeamUser()
        {
            Team = new Team();
            User= new User();
        }
    }
}
