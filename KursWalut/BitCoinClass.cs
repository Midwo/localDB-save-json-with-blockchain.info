using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWalut
{
    class BitCoinClass
    {
        public int BitCoinClassId { get; set; }
        public decimal M15 { get; set; }
        public decimal Last { get; set; }
        public decimal Buy { get; set; }
        public decimal Sell { get; set; }
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
    }

}