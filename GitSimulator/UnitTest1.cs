using GitSimulator.Entity;
using GitSimulator.Service;
using System.Xml.Linq;

namespace GitSimulator
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test case: invite member
        /// </summary>
        [TestMethod]
        public void InviteMemberTest()
        {
            //Create owner and repository
            var owner = new User()
            { Id = 1, Name = "John" };
            var repo = new Repository();
            repo.Owner = owner;

            //Create receiver and invite request
            var receiver = new User()
            { Id = 2, Name = "Hall" };
            var newInvite = new InviteRequest(owner, receiver);

            //Call RepositoryService to invite member
            var repoService = new RepoService(repo);
            repoService.InviteMemmber(newInvite);

            //Check request have been sent to receiver
            Assert.AreEqual(repo.InviteRequests.Count, 1);
        }

        [TestMethod]
        public void CreateTeamTest()
        {
            //Create org
            //Add team into org
            //org can assign team to a repo

        }

        [TestMethod]
        public void RemoveTeamMemberTest()
        {
            //Create a repository
            var repo = new Repository();

            //Create owner and team members
            var owner = new User()
            { Name = "Diana" };
            repo.Owner = owner;

            var member1 = new User()
            { Name = "John" };
            var member2 = new User()
            { Name = "David" };

            //Add user & owner into team
            repo.Contributors.Add(owner);
            repo.Contributors.Add(member1);
            repo.Contributors.Add(member2);

            //Call RepositoryService to remove a member
            var repoService = new RepoService(repo);
            repoService.RemoveTeamMember(member1);
            //Checking whether the member have been removed from team yet
            Assert.AreEqual(repo.Contributors.Contains(member1), false);
        }

        [TestMethod]
        public void CreateBranchTest()
        {
            var repo = new Repository();
            var creator = new User();
            string branchName = "New Branch";
            var files = new HashSet<GitFile>();

            var result = BranchService.CreateBranch(repo, creator, branchName, files);
            Assert.AreEqual(branchName, result.Name);
        }

        [TestMethod]
        public void CreateSubBranchTest()
        {
            var baseBranch = new Branch()
            { Name = "Base branch" };
            var subBranch = new Branch()
            { Name = "Sub branch" };

            var result = BranchService.CreateSubBranch(baseBranch, subBranch);
            Assert.AreEqual(result.Name, subBranch.Name);
        }

        [TestMethod]
        public void GetCodeByBranchTest()
        {
            var branch = new Branch()
            {
                Name = "new branch",
                Files = new HashSet<GitFile>()
                { new GitFile() { Name = "README.md" } }
            };
            var repo = new Repository()
            { Name = "new repo" };

            repo.Branches.Add(branch);

            var result = BranchService.GetCodeByBranch(repo, branch);
            Assert.AreEqual(result, branch.Files);
        }

        [TestMethod]
        public void ClondeCodeTest()
        {
            var repo = new Repository()
            {
                Url = "https://hello.com",
                Files = new HashSet<GitFile>()
                { new GitFile { Name = "hello" } }
            };
            var url = "https://hello.com";

            //input must be Id
            var repoService = new RepoService(repo);
            var result = repoService.CloneCode(url);

            Assert.AreNotEqual(result, null);
        }

        [TestMethod]
        public void ViewLastFileTest()
        {
            var repo = new Repository() { Name = "new repo" };
            var branch = new Branch() { Name = "master" };
            var file = new GitFile() { Name = "git.ignore" };

            branch.Files.Add(file);
            repo.Branches.Add(branch);

            var result = BranchService.ViewLastFile(repo, branch);
            Assert.AreEqual(result, file);
        }

        [TestMethod]
        public void ViewPullRequestTest()
        {
            var repo = new Repository();
            
            var result = PullRequestService.ViewPullRequest(repo);
            Assert.AreEqual(result, null);
        }

        [TestMethod]
        public void ViewPullRequestByIdTest()
        {
            var repo = new Repository();
            var pullrequestId = 1;

            
            var result = PullRequestService.ViewPullRequestById(pullrequestId);
        }

        [TestMethod]
        public void ViewOlderVersionFileTest()
        {
            var branch = new Branch();
            var file = new GitFile() 
            { Id = 1, Name = ".gitignore", CreatedTime = DateTime.Now, Version = "1" };
            var olderFile = new GitFile()
            { Id = 1, Name = ".gitignore", CreatedTime = DateTime.Now, Version = "2" };
            file.Versions.Add(olderFile);
            branch.Files.Add(file);

            var version = "2";
            var result = GitFileService.ViewOlderVersionFileTest(branch, file, version);
            Assert.AreEqual(olderFile, result);
        }

        [TestMethod]
        public void ViewLatestVersionFileTest()
        {
            var branch = new Branch();
            var file = new GitFile()
            { Id = 1, Name = ".gitignore", CreatedTime = DateTime.Now, Version = "1" };
            var olderFile = new GitFile()
            { Id = 1, Name = ".gitignore", CreatedTime = DateTime.Now, Version = "2" };
            file.Versions.Add(olderFile);
            branch.Files.Add(file);

            var fileID = 1;
            var result = GitFileService.ViewLatestVersionFile(branch, fileID);
            Assert.AreEqual(file, result);
        }

        [TestMethod]
        public void GetNumbersOfVersionFileTest()
        {
            var branch = new Branch();
            var file = new GitFile()
            { Id = 1, Name = ".gitignore", CreatedTime = DateTime.Now, Version = "1" };
            var olderFile = new GitFile()
            { Id = 2, Name = ".gitignore", CreatedTime = DateTime.Now, Version = "2" };
            file.Versions.Add(olderFile);
            branch.Files.Add(file);

            var result = GitFileService.GetNumbersOfVersionFile(branch, file);
            Assert.AreEqual(2, result);
        }
    }
}