using GitSimulator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Service
{
    internal class RepoService
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


        internal void InviteMemmber(InviteRequest newInvite)
        {
            var result = _repo.Contributors.FirstOrDefault(e => e.Name.Equals(newInvite.Receiver.Name));
            if (result is null)
            {
                _repo.InviteRequests.Add(newInvite);
                SaveChanges();
            }
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
