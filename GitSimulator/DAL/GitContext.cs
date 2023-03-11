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
        public GitContext(DbContextOptions<GitContext> options) : base() { }

        public DbSet<Repo> Repositories { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Commit> Commitments { get; set; }
        public DbSet<GitFile> Files { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PullRequest> PullRequests { get; set; }
        public DbSet<InviteRequest> InviteRequests { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Repository
            modelBuilder.Entity<Repo>()
                .HasOne(o => o.Owner)
                .WithMany(c => c.Repositories);

            modelBuilder.Entity<Repo>()
                .HasMany(c => c.Branches)
                .WithOne(o => o.Repository);

            modelBuilder.Entity<Repo>()
                .HasMany(o => o.InviteRequests)
                .WithOne(c => c.Repository);

            modelBuilder.Entity<Repo>()
                .HasMany(o => o.PullRequests)
                .WithOne(c => c.Repository);
            #endregion

            #region RepoUser
            modelBuilder.Entity<RepoUser>()
                .HasKey(rp => new { rp.RepoId, rp.UserId });

            modelBuilder.Entity<RepoUser>()
                .HasOne(r => r.Repository)
                .WithMany(rp => rp.RepoUsers)
                .HasForeignKey(r => r.RepoId);

            modelBuilder.Entity<RepoUser>()
                .HasOne(r => r.User)
                .WithMany(rp => rp.RepoUsers)
                .HasForeignKey(r => r.UserId);
            #endregion

            #region RepoTeam
            modelBuilder.Entity<RepoTeam>()
                .HasKey(rt => new { rt.RepositoryId, rt.TeamId });

            modelBuilder.Entity<RepoTeam>()
                .HasOne(t => t.Team)
                .WithMany(rt => rt.RepoTeams)
                .HasForeignKey(t => t.TeamId);

            modelBuilder.Entity<RepoTeam>()
                .HasOne(t => t.Repository)
                .WithMany(rt => rt.RepoTeams)
                .HasForeignKey(t => t.RepositoryId);
            #endregion

            #region BranchUser
            modelBuilder.Entity<BranchUser>()
                .HasKey(bu => new { bu.BranchId, bu.UserId });

            modelBuilder.Entity<BranchUser>()
                .HasOne(b => b.Branch)
                .WithMany(bu => bu.BranchUsers)
                .HasForeignKey(t => t.BranchId);

            modelBuilder.Entity<BranchUser>()
                .HasOne(b => b.User)
                .WithMany(bu => bu.BranchUsers)
                .HasForeignKey(t => t.UserId);
            #endregion

            #region User
            modelBuilder.Entity<User>()
              .HasMany(o => o.InviteRequests)
              .WithOne(c => c.Receiver);

            modelBuilder.Entity<User>()
              .HasMany(o => o.PullRequests)
              .WithOne(c => c.Owner);

            modelBuilder.Entity<User>()
                .HasMany(o => PullRequests)
                .WithOne(c => c.Reviewer);
            #endregion

            modelBuilder.Entity<Branch>()
                .HasOne(p => p.Owner)
                .WithMany(c => c.Branches);

            modelBuilder.Entity<InviteRequest>()
                .HasOne(o => o.Receiver)
                .WithMany(c => c.InviteRequests);

            modelBuilder.Entity<Organization>()
                .HasOne(o => o.Owner)
                .WithMany(c => c.Organizations);

            modelBuilder.Entity<Organization>()
                .HasMany(o => o.Teams)
                .WithOne(o => o.Organization);

            modelBuilder.Entity<Organization>()
                .HasMany(o => o.Repositories)
                .WithOne(c => c.Organization);

            modelBuilder.Entity<Commit>()
                .HasMany(o => o.Files)
                .WithOne(c => c.Commit);

            modelBuilder.Entity<Branch>()
                .HasMany(o => o.Commits)
                .WithOne(c => c.Branch);



            modelBuilder.Entity<Commit>()
                .HasOne(o => o.PullRequest)
                .WithMany(c => c.Commits);

        }
    }
}
