using System.Collections.Generic;
using Common.Models;

namespace UI.ViewModels
{
    public class StockLogIndexViewModel
    {
        public int Quantity { get; set; }
        public List<StockLog> StockLogs { get; set; }
    }
}
