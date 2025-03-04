using ReportBuilderAPI.Application.Interfaces;
using ReportBuilderAPI.Persistence.Context;
using ReportBuilderAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ReportBuilderAPI.Domain.Entities.Common;

namespace ReportBuilderAPI.Persistence.Repositories
{
    public class HarmanlamaRepository(ProjectDbContext context) : BaseEntity, IHarmanlamaRepository
    {
        public async Task<IList<Harmanlama>> GetHarmanlamaByDateAsync(DateTime startDate, DateTime endDate)
        {
            return await context.std_tbl_rapor_harmanlama
                .Where(h => h.dt >= startDate && h.dt <= endDate)
                .Include(h => h.Recete)
                .Include(h => h.Hammadde)
                .ToListAsync();
        }

        public async Task<IList<Harmanlama>> GetHarmanlamaByReceteAndRevizyonAsync(IList<int> receteler, IList<int> revizyonlar, DateTime startDate, DateTime endDate)
        {
            return await context.std_tbl_rapor_harmanlama
                .Where(h => receteler.Contains(h.recete_id)
                         && revizyonlar.Contains(h.Recete.recete_revno)
                         && h.dt >= startDate
                         && h.dt <= endDate)
                .Include(h => h.Recete)
                .Include(h => h.Hammadde)
                .ToListAsync();
        }

        public async Task<IList<int>> GetDistinctReceteIdsAsync(DateTime startDate, DateTime endDate)
        {
            return await context.std_tbl_rapor_harmanlama
                .Where(h => h.dt >= startDate && h.dt <= endDate)
                .Select(h => h.recete_id)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IList<int>> GetDistinctRevizyonNosAsync(DateTime startDate, DateTime endDate, IList<int> receteler)
        {
            return await context.std_tbl_rapor_harmanlama
                .Where(h => h.dt >= startDate && h.dt <= endDate && receteler.Contains(h.recete_id))
                .Select(h => h.Recete.recete_revno)
                .Distinct()
                .ToListAsync();
        }
        public DbSet<Harmanlama> Table => context.Set<Harmanlama>();
        public IQueryable<Harmanlama> GetAll() => Table.AsNoTracking();
    }
}
