using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmexApp
{
    class InmConsumerDefault
    {
        public bool IsChecked { get; set; }
        public string DetailNum { get; set; }
        public string DetailNameRusUser { get; set; }
        public decimal AccPriceOrdPotrRUR { get; set; }
        public decimal AccPriceLastPotrRUR { get; set; }
        public short AccQuantity { get; set; }
        public string DestinationLogo { get; set; }
        public long GlobalId { get; set; }
        public string MakeLogo { get; set; }
        public long PotrebitelId { get; set; }
        public string PotrebitelReference { get; set; }
        public string PriceLogo { get; set; }
        public string PotrebitelName { get; set; }
        public long UserId { get; set; }
        public byte[] timestamp { get; set; }
        public byte state { get; set; }
    }
}
