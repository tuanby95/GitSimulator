using GitSimulator.Entity;

namespace GitSimulator.Service
{
    public class RepoService
    {

        internal List<InviteRequest> InviteMember(Repository? repoId, User? userName)
        {
            var result = new List<InviteRequest>();

            return result;
        }

        //public RepoService(Repository repo)
        //{
        //    this._repo = repo;
        //}

        //internal HashSet<GitFile>? CloneCode(string url)
        //{
        //    if (_repo.Url.Equals(url, StringComparison.OrdinalIgnoreCase))
        //    {
        //        return _repo.Files;
        //    }
        //    return null;
        //}

        //internal Repository GetRepo()
        //{
        //    return _repo;
        //}

        //internal InviteRequest InviteMemmber(int userId)
        //{
        //    var result = new InviteRequest();
        //    //kiem tra user nay co ton tai trong cai repo nay chua
        //    //send email
        //    //
        //    var user = userService.GetUserById(userId);

        //    if (_repo.Contributors.FirstOrDefault(e => e.Id.Equals(user.Id)) == null)
        //    {
        //        var inviteRequest = new InviteRequest() { Receiver = user, CreateTime = DateTime.UtcNow };
        //        _repo.InviteRequests.Add(inviteRequest);
        //    }
        //    return result;
        //}

        //internal HashSet<User> RemoveTeamMember(User member1)
        //{
        //    if (member1 != null && _repo.Contributors.Contains(member1))
        //    {
        //        _repo.Contributors.Remove(member1);
        //        SaveChanges();
        //    }
        //    return _repo.Contributors;
        //}

        //internal HashSet<PullRequest> ViewPullRequest()
        //{
        //    throw new NotImplementedException();
        //}

        //internal PullRequest ViewPullRequestById(int pullrequestId)
        //{
        //    var result = new PullRequest();
        //    return result;
        //}

        private void SaveChanges()
        {

        }
    }
}
