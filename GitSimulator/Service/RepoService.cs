using GitSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Service
{
    public class RepoService
    {
        //tao 1 class chua tat ca cac property
        private Repository _repo;

        public RepoService(Repository repo)
        {
            this._repo = repo;
        }

        internal HashSet<GitFile>? CloneCode(string url)
        {
            if(_repo.Url.Equals(url, StringComparison.OrdinalIgnoreCase))
            {
                return _repo.Files;
            }
            return null;
        }

        internal Repository GetRepo()
        {
            return _repo;
        }


        internal void InviteMemmber(int userId)
        {
            //kiem tra user nay co ton tai trong cai repo nay chua
            var user = GetUserById(userId);
            
            if(_repo.Contributors.FirstOrDefault(e => e.Id.Equals(user.Id)) == null)
            {
                var inviteRequest = new InviteRequest() { Receiver = user, CreateTime = DateTime.UtcNow };
                _repo.InviteRequests.Add(inviteRequest);
            }
            
        }

        private User GetUserById(int userId)
        {
            var user = new User();
            user = _repo.Contributors.FirstOrDefault(e => e.Equals(userId));
            return user;
        }

        internal HashSet<User> RemoveTeamMember(User member1)
        {
            if (member1 != null && _repo.Contributors.Contains(member1))
            {
                _repo.Contributors.Remove(member1);
                SaveChanges();
            }
            return _repo.Contributors;
        }

        internal HashSet<PullRequest> ViewPullRequest()
        {
            throw new NotImplementedException();
        }

        internal PullRequest ViewPullRequestById(int pullrequestId)
        {
            var result = new PullRequest();
            return result;
        }

        private void SaveChanges()
        {

        }
    }
}
