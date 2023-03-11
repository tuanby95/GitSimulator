﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Entity
{
    public class BranchUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public User User { get; set; }
        public Branch Branch { get; set; }
        public BranchUser()
        {
            User = new User();
            Branch = new Branch();
        }
    }
}
