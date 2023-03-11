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
            
            modelBuilder.Entity<Repo>()
                .HasOne(o => o.Owner)
                .WithMany(c => c.Repositories);

            modelBuilder.Entity<Branch>()
                .HasOne(p => p.Owner)
                .WithMany(c => c.Branches);

            modelBuilder.Entity<Repo>()
                .HasMany(c => c.Branches)
                .WithOne(o => o.Repository);

            modelBuilder.Entity<Repo>()
                .HasMany(o => o.InviteRequests)
                .WithOne(c => c.Repository);

            modelBuilder.Entity<InviteRequest>()
                .HasOne(o => o.Receiver)
                .WithMany(c => c.InviteRequests);

            modelBuilder.Entity<Organization>()
                .HasOne(o => o.Owner)
                .WithMany(c => c.Organizations);

            modelBuilder.Entity<Organization>()
                .HasMany(o => o.Teams)
                .WithOne(o => o.Organization);

            modelBuilder.Entity<User>()
                .HasMany(o => o.InviteRequests)
                .WithOne(c => c.Receiver);

            modelBuilder.Entity<Commit>()
                .HasMany(o => o.Files)
                .WithOne(c => c.Commit);

            modelBuilder.Entity<Branch>()
                .HasMany(o => o.Commits)
                .WithOne(c => c.Branch);

            modelBuilder.Entity<User>()
                .HasMany(o => o.PullRequests)
                .WithOne(c => c.Owner);

            modelBuilder.Entity<User>()
                .HasMany(o => PullRequests)
                .WithOne(c => c.Reviewer);

            modelBuilder.Entity<Commit>()
                .HasOne(o => o.PullRequest)
                .WithMany(c => c.Commits);

        }
    }
}
