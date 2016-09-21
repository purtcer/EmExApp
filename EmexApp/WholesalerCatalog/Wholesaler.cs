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

        public StaticVariables.WholesalerElement WholesalerElement(int WholesalerIndex)
        {
            return WholesalerList[WholesalerIndex];
        }

        public List<string> WholesalerRepresentationList()
        {
            Consumer consumerObject = new Consumer();
            EmExDictionaries.EmExDictionaries emexServices = new EmExDictionaries.EmExDictionaries();
            EmExDictionaries.ConsumerInfo[] clientsList = emexServices.GetConsumersDict(consumerObject.login, consumerObject.password, null);
            List<string> representationList = new List<string>();
            foreach (EmExDictionaries.ConsumerInfo consumerElement in clientsList)
            {
                StringBuilder WholesalerRepresentation = new StringBuilder();
                WholesalerRepresentation.Append(consumerElement.UserLogo);
                WholesalerRepresentation.Append(" (");
                WholesalerRepresentation.Append(consumerElement.UserFamily);
                WholesalerRepresentation.Append(consumerElement.UserFirstName);
                WholesalerRepresentation.Append(consumerElement.UserLastName);
                WholesalerRepresentation.Append(")");
                representationList.Add(WholesalerRepresentation.ToString());
            }
            return representationList;
        }

        private void IniteWholesalerList()
        {
            WholesalerList = new List<StaticVariables.WholesalerElement>();
            StaticVariables.WholesalerElement Wholesaler;
            Consumer consumerObject = new Consumer();
            EmExDictionaries.EmExDictionaries emexServices = new EmExDictionaries.EmExDictionaries();
            EmExDictionaries.ConsumerInfo[] clientsList = emexServices.GetConsumersDict(consumerObject.login, consumerObject.password, null);
            foreach (EmExDictionaries.ConsumerInfo element in clientsList)
            {
                Wholesaler = new StaticVariables.WholesalerElement();
                Wholesaler.UserId = element.UserId;
                Wholesaler.ConsumerId = element.ConsumerId;
                Wholesaler.UserFamily = element.UserFamily;
                Wholesaler.UserFirstName = element.UserFirstName;
                Wholesaler.UserLastName = element.UserLastName;
                Wholesaler.UserLogo = element.UserLogo;
                Wholesaler.LocationId = element.LocationId;
                Wholesaler.LocationAddress = element.LocationAddress;
                Wholesaler.LocationAddressAdditional = element.LocationAddressAdditional;
                Wholesaler.OptovikManagerId = element.OptovikManagerId;
                Wholesaler.OptovikManagerFio = element.OptovikManagerFio;
                WholesalerList.Add(Wholesaler);
            }
        }
    }
}
