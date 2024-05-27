using Nemesys.Data;
using Nemesys.Models;
using Nemesys.Models.Interfaces;
using System.Linq;

public class UserVoteRepository : IUserVoteRepository
{
    private readonly ApplicationDbContext _context;

    public UserVoteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public UserVote GetUserVote(string userId, int reportId)
    {
        return _context.UserVotes.FirstOrDefault(uv => uv.UserId == userId && uv.ReportID == reportId);
    }

    public void AddUserVote(UserVote userVote)
    {
        _context.UserVotes.Add(userVote);
        _context.SaveChanges();
    }

    public void RemoveUserVote(UserVote userVote)
    {
        _context.UserVotes.Remove(userVote);
        _context.SaveChanges();
    }
}
