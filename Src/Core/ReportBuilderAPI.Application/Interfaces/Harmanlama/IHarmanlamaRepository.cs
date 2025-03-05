using ReportBuilderAPI.Domain.Entities;

namespace ReportBuilderAPI.Application.Interfaces;

public interface IHarmanlamaRepository
{
    Task<IList<Harmanlama>> GetHarmanlamaByDateAsync(DateTime startDate, DateTime endDate);
    Task<IList<Harmanlama>> GetHarmanlamaByReceteAndRevizyonAsync(IList<int> receteler, IList<int> revizyonlar, DateTime startDate, DateTime endDate);
    Task<IList<int>> GetDistinctReceteIdsAsync(DateTime startDate, DateTime endDate);
    Task<IList<int>> GetDistinctRevizyonNosAsync(DateTime startDate, DateTime endDate, IList<int> receteler);
    IQueryable<Harmanlama> GetAll();
    Task<Harmanlama> GetById(int id);
}
