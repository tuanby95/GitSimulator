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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlite("Data Source = sqlite.db");
            optionsBuilder.UseInMemoryDatabase("GitDatabase");
        }

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

            #region TeamUser
            modelBuilder.Entity<TeamUser>()
                .HasKey(tu => new { tu.UserId, tu.TeamId });

            modelBuilder.Entity<TeamUser>()
                .HasOne(o => o.Team)
                .WithMany(c => c.TeamUsers)
                .HasForeignKey(k => k.TeamId);

            modelBuilder.Entity<TeamUser>()
                .HasOne(o => o.User)
                .WithMany(o => o.TeamUsers)
                .HasForeignKey(k => k.UserId);
            #endregion

            #region Branch
            modelBuilder.Entity<Branch>()
                .HasOne(p => p.Owner)
                .WithMany(c => c.Branches);

            modelBuilder.Entity<Branch>()
                .HasMany(o => o.Commits)
                .WithOne(c => c.Branch);
            #endregion

            #region BranchFiles
            modelBuilder.Entity<BranchFile>()
                .HasKey(bf => new { bf.FileId, bf.BranchId });

            modelBuilder.Entity<BranchFile>()
                .HasOne(o => o.Branch)
                .WithMany(c => c.BranchFiles)
                .HasForeignKey(k => k.BranchId);
            
            modelBuilder.Entity<BranchFile>()
                .HasOne(o => o.File)
                .WithMany(c => c.BranchFiles)
                .HasForeignKey(k => k.FileId);
            #endregion

            #region InviteRequest
            modelBuilder.Entity<InviteRequest>()
                .HasOne(o => o.Receiver)
                .WithMany(c => c.InviteRequests);
            #endregion

            #region Organization
            modelBuilder.Entity<Organization>()
                .HasOne(o => o.Owner)
                .WithMany(c => c.Organizations);

            modelBuilder.Entity<Organization>()
                .HasMany(o => o.Teams)
                .WithOne(o => o.Organization);

            modelBuilder.Entity<Organization>()
                .HasMany(o => o.Repositories)
                .WithOne(c => c.Organization);
            #endregion

            #region OrgUser
            modelBuilder.Entity<OrgUser>()
                .HasKey(ou => new { ou.OrgId, ou.UserId });

            modelBuilder.Entity<OrgUser>()
                .HasOne(c => c.Organization)
                .WithMany(o => o.OrgUsers)
                .HasForeignKey(k => k.OrgId);

            modelBuilder.Entity<OrgUser>()
                .HasOne(c => c.User)
                .WithMany(o => o.OrgUsers)
                .HasForeignKey(k => k.UserId);
            #endregion

            #region Commit
            modelBuilder.Entity<Commit>()
                .HasMany(o => o.Files)
                .WithOne(c => c.Commit);
            #endregion

            #region PullRequest
            modelBuilder.Entity<PullRequest>()
                .HasOne(o => o.Owner)
                .WithMany(c => c.PullRequests);

            modelBuilder.Entity<PullRequest>()
                .HasOne(o => o.Reviewer)
                .WithMany(c => c.PullRequests);

            modelBuilder.Entity<PullRequest>()
                .HasMany(o => o.Commits)
                .WithOne(c => c.PullRequest);

            modelBuilder.Entity<PullRequest>()
                .HasOne(o => o.ToBranch)
                .WithOne(c => c.PullRequest);

            modelBuilder.Entity<PullRequest>()
                .HasOne(o => o.FromBranch)
                .WithOne(c => c.PullRequest);
            #endregion
        }
    }
}
