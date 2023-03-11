using Azure.Core;
using GitSimulator.DAL;
using GitSimulator.Entity;
using GitSimulator.Service;
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
                new User { Name = "Tuan" },
                new User { Name = "Tin" },
                new User { Name = "Tien" },
                new User { Name = "Tung" },
                new User { Name = "Viet" },
            });

            _context.Repositories.AddRange(new List<Repository>
            {
                new Repository { Name = "RepoA", OwnerId = 1 },
                new Repository { Name = "RepoB", OwnerId = 2 },
                new Repository { Name = "RepoC", OwnerId = 3 },
                new Repository { Name = "RepoD", OwnerId = 4 },
                new Repository { Name = "RepoE", OwnerId = 5 },
            });

            _context.Branches.AddRange(new List<Branch>
            {
                new Branch { Name = "BrachA" },
                new Branch { Name = "BrachB" },
                new Branch { Name = "BrachC" },
                new Branch { Name = "BrachD" },
                new Branch { Name = "BrachE" },
            });
        }
        /// <summary>
        /// Test case: invite member
        /// </summary>
        [TestMethod]
        public void InviteMemberTest()
        {
            var repoId = _context.Repositories.FirstOrDefault(e => e.Id.Equals(1));
            var userName = _context.Users.FirstOrDefault(e => e.Id.Equals(1));
            

            //Call InviteMember method in Reposervice
            var repo = new RepoService();
            var result = repo.InviteMember(repoId, userName);

            Assert.AreEqual(result.Count, 1);
        }

        [TestMethod]
        public void CreateTeamTest()
        {
            //Create org
            //Add team into org
            //org can assign team to a repo
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
            Assert.IsNotNull(_context);
        }
    }
}