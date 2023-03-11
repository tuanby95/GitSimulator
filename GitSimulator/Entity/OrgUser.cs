using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Entity
{
    public class OrgUser
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public Organization Organization { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public OrgUser()
        {
            Organization = new Organization();
            User = new User();
        }
    }
}
