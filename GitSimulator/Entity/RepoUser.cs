using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Entity
{
    public class RepoUser
    {
        public int RepoId { get; set; }
        public Repo Repository { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public RepoUser()
        {
            User = new User();
            Repository = new Repo();
        }
    }
}
