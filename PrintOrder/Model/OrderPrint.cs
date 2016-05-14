using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOrder.Model
{
    public class OrderPrint
    {
        public string OrderNumber { get; set; }
        public string DocumentNumber { get; set; }
        public bool IsPrinted { get; set; }

        public override string ToString()
        {
            return OrderNumber;
        }
    }
}
