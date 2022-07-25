using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IHistoryRepository
    {
        Task<IEnumerable<HistoryEntity>> GetAll();
        Task Insert(HistoryEntity historyEntity);
        Task Update(HistoryEntity historyEntity);
        Task Delete(HistoryEntity historyEntity);
    }
}
