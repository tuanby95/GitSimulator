using GitSimulator.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.DAL
{
    public class GitContext : DbContext
    {
        public GitContext(DbContextOptions<GitContext> options) :base() { }

        public DbSet<Repo> Repositories { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Commit> Commitments { get;set; }
        public DbSet<GitFile> Files { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PullRequest> PullRequests { get; set; }
        public DbSet<InviteRequest> InviteRequests { get; set;}
        public DbSet<Team> Teams { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //reverse all
            modelBuilder.Entity<Repo>()
                .HasOne(o => o.Owner)
                .WithMany(c => c.Repositories);

            modelBuilder.Entity<Branch>()
                .HasOne(p => p.Owner)
                .WithMany(c => c.Branches);

            modelBuilder.Entity<Branch>()
                .HasOne(o => o.Repository)
                .WithMany(c => c.Branches);

            modelBuilder.Entity<InviteRequest>()
                .HasOne(o => o.Repository)
                .WithMany(c => c.InviteRequests);

            modelBuilder.Entity<InviteRequest>()
                .HasOne(o => o.Receiver)
                .WithMany(c => c.InviteRequests);

            modelBuilder.Entity<User>()
                .HasMany(o => o.Repositories)
                .WithMany(c => c.Contributors);
        }
    }
}
