using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOrder.Model
{
    public class OrderDetail
    {
        public string OrderNumber { get; set; }
        public string DocumentNumber { get; set; }
        public string Description { get; set; }
        public string CurrAccCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public int Qty1 { get; set; }
        public decimal Loc_Price { get; set; }
        public decimal Loc_NetAmount { get; set; }
    }
}
