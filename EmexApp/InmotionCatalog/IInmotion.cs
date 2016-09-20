using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmexApp
{
    interface IInmotion
    {
        void SetInmotionState(List<StaticVariables.InmotionElement> inmotionElement);
    }
}
