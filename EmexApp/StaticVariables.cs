using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmexApp
{
    class StaticVariables
    {
        public struct WholesalerElement
        {
            public int UserId;
            public int ConsumerId;
            public string UserFamily;
            public string UserFirstName;
            public string UserLastName;
            public string UserLogo;
            public string LocationId;
            public string LocationAddress;
            public string LocationAddressAdditional;
            public string OptovikManagerId;
            public string OptovikManagerFio;
        }

        public struct InmConsumerElement
        {
            public bool IsChecked;
            public string DetailNum;
            public string DetailNameRusUser;
            public int AccPriceOrdPotrRUR;
            public int AccPriceLastPotrRUR;
            public int AccQuantity;
            public string DestinationLogo;
            public int GlobalId;
            public string MakeLogo;
            public string PotrebitelId;
            public string PotrebitelReference;
            public string PriceLogo;
            public string PotrebitelName;
            public int UserId;
            public string timestamp;
        }

        public struct InmotionElement
        {
            public int GlobalId;
            public int Count;
            public int State;
        }
    }
}
