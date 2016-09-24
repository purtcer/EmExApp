using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmexApp
{
    interface IWholesaler
    {
        StaticVariables.WholesalerElement WholesalerElement(int WholesalerIndex);
        List<string> WholesalerRepresentationList();
        void AddWholesalerElement(EmExInmotion.InmConsumer_v2 inmConsumerElement);
    }
}
