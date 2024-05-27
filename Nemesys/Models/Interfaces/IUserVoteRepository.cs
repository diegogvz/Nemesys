namespace Nemesys.Models.Interfaces
{
    public interface IUserVoteRepository
    {
        UserVote GetUserVote(string userId, int reportId);
        void AddUserVote(UserVote userVote);
        void RemoveUserVote(UserVote userVote);
    }
}
