using Azure.Core;
using GitSimulator.DAL;
using GitSimulator.DAL.Repository;
using GitSimulator.DAL.UnitOfWork;
using GitSimulator.Entity;
using GitSimulator.Service;
using GitSimulator.Service.RepoService;
using GitSimulator.Service.TeamService;
using Microsoft.EntityFrameworkCore;

namespace GitSimulator
{
    [TestClass]
    public class UnitTest1
    {
        GitContext _context;

        [TestInitialize]
        public void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<GitContext>()
                .UseInMemoryDatabase(databaseName: "GitDatabase")
                .Options;

            _context = new GitContext(options);

            _context.Users.AddRange(new List<User>
            {
                new User { UserName = "Tuan" },
                new User { UserName = "Tin" },
                new User { UserName = "Tien" },
                new User { UserName = "Tung" },
                new User { UserName = "Viet" },
            });

            _context.Repositories.AddRange(new List<Repo>
            {
                new Repo { RepoName = "RepoA"},
                new Repo { RepoName = "RepoB" },
                new Repo { RepoName = "RepoC" },
                new Repo { RepoName = "RepoD" },
                new Repo { RepoName = "RepoE" }
            });

            _context.Branches.AddRange(new List<Branch>
            {
                new Branch { BranchName = "BrachA" },
                new Branch { BranchName = "BrachB" },
                new Branch { BranchName = "BrachC" },
                new Branch { BranchName = "BrachD" },
                new Branch { BranchName = "BrachE" },
            });
        }
        /// <summary>
        /// Test case: invite member
        /// </summary>
        [TestMethod]
        public void InviteMemberTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void CreateTeamTest()
        {
            //Create org
            //Add team into org
            //org can assign team to a repo
            string name = "New team";
            string description = "Lorem ipsum";
            int creatorId = 1;
            var uow = new UnitOfWork(_context);
            var teamService = new TeamService(uow);

            Team newTeam = teamService.CreateTeam(creatorId, name, description);

            Assert.AreEqual(creatorId, newTeam.Members.FirstOrDefault().Id);

            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void RemoveTeamMemberTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void CreateBranchTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void CreateSubBranchTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void GetCodeByBranchTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void ClondeCodeTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void ViewLastFileTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void ViewPullRequestTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void ViewPullRequestByIdTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void ViewOlderVersionFileTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void ViewLatestVersionFileTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void GetNumbersOfVersionFileTest()
        {
            Assert.IsNotNull(_context);
        }

        [TestMethod]
        public void ServiceTest()
        {
            var uow = new UnitOfWork(_context);
            var repo = new RepoService(uow);
            var user = uow.UserRepository.GetAll();

            Assert.IsNotNull(user);
        }
    }
}