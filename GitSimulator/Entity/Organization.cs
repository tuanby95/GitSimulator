using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Entity
{
    public class Organization
    {
        public int Id { get; set; }
        public string? OrgName { get; set; }
        public User Owner { get; set; }
        public HashSet<Repo>? Repositories { get; set; }
        public HashSet<Team>? Teams { get; set; }
        public HashSet<OrgUser> OrgUsers { get; set; }

        public Organization()
        {
            Owner = new User();
            OrgUsers = new HashSet<OrgUser>();
        }
    }
}
