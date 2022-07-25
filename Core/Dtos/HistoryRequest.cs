using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class HistoryRequest
    {
        public int TypeOperation { get; set; }
        public List<string> Request{ get; set; }
        public string User { get; set; }
    }
}
