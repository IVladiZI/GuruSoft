using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class HistoryEntity
    {
        public long Id { get; set; }
        public string User { get; set; }
        public string Response { get; set; }
        public string Request { get; set; }
        public DateTime? DateResponse { get; set; }
        public DateTime? DateRequest { get; set; }
    }
}
