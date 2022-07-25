using Core.Dtos;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IHistoryService
    {
        IEnumerable<HistoryEntity> Get();
        Task<HistoryEntity> Get(long Id);
        Task<string> InsertHistory(HistoryRequest historyRequest);
    }
}
