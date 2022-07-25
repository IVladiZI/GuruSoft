using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly GuruSoftContext _guruSoftContext;
        public HistoryRepository(GuruSoftContext guruSoftContext)
        {
            _guruSoftContext = guruSoftContext;
        }
        public async Task<IEnumerable<HistoryEntity>> GetAll()
        {
            return await _guruSoftContext.History.ToListAsync();
        }
        public async Task Insert(HistoryEntity Entity)
        {
           _guruSoftContext.History.Add(Entity);
            await _guruSoftContext.SaveChangesAsync();
           
        }
        public async Task Update(HistoryEntity Entity)
        {
            _guruSoftContext.Update(Entity);
            await _guruSoftContext.SaveChangesAsync();
        }
        public async Task Delete(HistoryEntity entity)
        {
            _guruSoftContext.Remove(entity);
            await _guruSoftContext.SaveChangesAsync();
        }

    }
}
