using Nemesys.Models;

public interface IInvestigationsRepository
{
    IEnumerable<Investigation> GetAllInvestigations();
    Investigation GetInvestigationById(int investigationId);
    void CreateInvestigation(Investigation investigation);
    void DeleteInvestigation(int investigationId);
    void UpdateInvestigation(Investigation investigation);
}
