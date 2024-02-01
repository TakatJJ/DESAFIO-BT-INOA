using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketGuide
{
    internal class APIResponse
    {
        public List<StocksINFO> Results { get; set; }
        public DateTime RequestedAt { get; set; }
        public string Took { get; set; }
    }
}
