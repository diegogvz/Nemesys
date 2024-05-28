using Microsoft.EntityFrameworkCore;
using Nemesys.Data;

namespace Nemesys.Models.Repositories
{
    public class InvestigationsRepository : IInvestigationsRepository
    {
        private readonly ApplicationDbContext _context;

        public InvestigationsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Investigation> GetAllInvestigations()
        {
            return _context.Investigations.ToList();
        }

        public Investigation GetInvestigationById(int investigationId)
        {
            return _context.Investigations.Include(i => i.Report).FirstOrDefault(i => i.InvestigationID == investigationId);
        }

        public void CreateInvestigation(Investigation investigation)
        {
            _context.Investigations.Add(investigation);
            _context.SaveChanges();
        }

        public void UpdateInvestigation(Investigation investigation)
        {
            _context.Investigations.Update(investigation);
            _context.SaveChanges();
        }

        public void DeleteInvestigation(int investigationId)
        {
            var investigation = _context.Investigations.FirstOrDefault(i => i.InvestigationID == investigationId);
            if (investigation != null)
            {
                _context.Investigations.Remove(investigation);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Investigation> GetInvestigationsByInvestigatorId(string investigatorId)
        {
            return _context.Investigations
                .Include(i => i.Report)
                .Where(i => i.InvestigatorEmail == investigatorId)
                .ToList();
        }
    }


}
