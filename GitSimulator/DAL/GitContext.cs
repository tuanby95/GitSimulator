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

        public DbSet<Repository> Repositories { get; set; }
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
            modelBuilder.Entity<Repository>()
                .HasOne(o => o.Owner)
                .WithMany(c => c.Repositories)
                .HasForeignKey(k => k.OwnerId);

            modelBuilder.Entity<Branch>()
                .HasOne(p => p.Owner)
                .WithMany(c => c.Branches)
                .HasForeignKey(k => k.OwnerId);

            modelBuilder.Entity<Branch>()
                .HasOne(o => o.Repository)
                .WithMany(c => c.Branches)
                .HasForeignKey(k => k.RepoId);

            modelBuilder.Entity<InviteRequest>()
                .HasOne(o => o.Repository)
                .WithMany(c => c.InviteRequests)
                .HasForeignKey(k => k.RepoId);

            modelBuilder.Entity<InviteRequest>()
                .HasOne(o => o.Receiver)
                .WithMany(c => c.InviteRequests)
                .HasForeignKey(k => k.ReceiverId);

            modelBuilder.Entity<User>()
                .HasMany(o => o.Repositories)
                .WithMany(c => c.Contributors);

            modelBuilder.Entity<Commit>()
                .HasMany(o => o.Files)
                .WithOne(c => c.Commit)
                .HasForeignKey(k => k.CommitId);

            modelBuilder.Entity<Team>()
                .HasMany(o => o.Members)
                .WithOne(c => c.Team)
                .HasForeignKey(k => k.TeamId);
        }
    }
}
