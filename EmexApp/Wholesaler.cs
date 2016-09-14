using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmexApp
{
    class Wholesaler : IWholesaler
    {
        List<StaticVariables.WholesalerElement> WholesalerList;
        public Wholesaler()
        {
            IniteWholesalerList();

        }

        public Enum WholesalerElement(string WholesalerId)
        {
            throw new NotImplementedException();
        }

        public List<string> WholesalerRepresentationList()
        {
            throw new NotImplementedException();
        }

        private void IniteWholesalerList()
        {
            EmExDictionaries.EmExDictionaries emexServices = new EmExDictionaries.EmExDictionaries();
            EmExDictionaries.ConsumerInfo[] clientsList = emexServices.GetConsumersDict(112, "341292ast", null);
            foreach (EmExDictionaries.ConsumerInfo elements in clientsList)
            {
                //cbClients.Items.Add(elements.UserLogo);
            }
        }
    }
}
