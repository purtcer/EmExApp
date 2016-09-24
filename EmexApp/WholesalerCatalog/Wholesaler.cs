using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EmexApp
{
    class Wholesaler : IWholesaler
    {
        List<StaticVariables.WholesalerElement> WholesalerList = new List<StaticVariables.WholesalerElement>();
        Hashtable wholesalerCollection = new Hashtable();
        EmExDictionaries.EmExDictionaries emexDict = new EmexApp.EmExDictionaries.EmExDictionaries();

        public Wholesaler()
        {
            emexDict.TestConnect("Test");
        }

        public StaticVariables.WholesalerElement WholesalerElement(int WholesalerIndex)
        {
            return WholesalerList[WholesalerIndex];
        }

        public void AddWholesalerElement(EmExInmotion.InmConsumer_v2 inmConsumerElement)
        {
            if(wholesalerCollection[inmConsumerElement.PotrebitelId] == null)
            {
                wholesalerCollection.Add(inmConsumerElement.PotrebitelId, inmConsumerElement.PotrebitelId);
                AddWholesalerListElement(inmConsumerElement);
            }
        }

        public List<string> WholesalerRepresentationList()
        {
            List<string> representationList = new List<string>();
            foreach (StaticVariables.WholesalerElement consumerElement in WholesalerList)
            {
                StringBuilder WholesalerRepresentation = new StringBuilder();
                WholesalerRepresentation.Append(consumerElement.UserLogo);
                WholesalerRepresentation.Append(" ");
                WholesalerRepresentation.Append(consumerElement.UserFirstName);
                WholesalerRepresentation.Append(" ");
                WholesalerRepresentation.Append(consumerElement.ConsumerId);
                representationList.Add(WholesalerRepresentation.ToString());
            }
            return representationList;
        }

        private void AddWholesalerListElement(EmExInmotion.InmConsumer_v2 inmConsumerElement)
        {
            StaticVariables.WholesalerElement Wholesaler;

            Wholesaler = new StaticVariables.WholesalerElement();
            Wholesaler.UserId = inmConsumerElement.UserId;
            Wholesaler.ConsumerId = inmConsumerElement.PotrebitelId;
            Wholesaler.UserFamily = inmConsumerElement.PotrebitelName;
            Wholesaler.UserFirstName = inmConsumerElement.PotrebitelName;
            Wholesaler.UserLastName = inmConsumerElement.PotrebitelName;
            Wholesaler.UserLogo = inmConsumerElement.PotrebitelLogo;
            WholesalerList.Add(Wholesaler);

        }
    }
}
