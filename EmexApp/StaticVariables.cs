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
            public long UserId;
            public long ConsumerId;
            public string UserFamily;
            public string UserFirstName;
            public string UserLastName;
            public string UserLogo;
            public long LocationId;
            public string LocationAddress;
            public string LocationAddressAdditional;
            public long OptovikManagerId;
            public string OptovikManagerFio;
        }

        public struct InmotionElement
        {
            public long GlobalId;
            public int Count;
            public int State;
        }
    }
}
