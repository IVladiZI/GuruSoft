using Core.Dtos;
using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IOperations _operations;
        private readonly IHistoryRepository _historyRepository;
        public HistoryService(IOperations operations, IHistoryRepository historyRepository)
        {
            _operations = operations;
            _historyRepository = historyRepository;
        }
        public IEnumerable<HistoryEntity> Get()
        {
            throw new NotImplementedException();
        }

        public Task<HistoryEntity> Get(long Id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> InsertHistory(HistoryRequest historyRequest)
        {
            string result;
            switch (historyRequest.TypeOperation)
            {
                case 1:
                    result = _operations.Problema1(historyRequest.Request[0]);
                    break;

                case 2:
                    result = _operations.Problema2(int.Parse(historyRequest.Request[0].ToString()), int.Parse(historyRequest.Request[1].ToString()));
                    break;

                case 3:
                    result = _operations.Problema3(historyRequest.Request[0]); ;
                    break;

                default:
                    result = "Opcion Invalida";
                    break;
            }

            return result;


        }
    }
}
