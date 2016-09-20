using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmexApp
{
    class InmConsumer : IInmConsumer
    {
        List<StaticVariables.InmConsumerElement> MainInmConsumerList;

        public InmConsumer()
        {
            IniteInmConsumerList();
        }

        public List<InmConsumerDefault> InmConsumerList(StaticVariables.WholesalerElement WholesalerElement)
        {
            throw new NotImplementedException();
        }

        private void IniteInmConsumerList()
        {
            StaticVariables.InmConsumerElement InmConsumerElement;

            InmConsumerElement = new StaticVariables.InmConsumerElement();
            InmConsumerElement.DetailNum = "CBT40";
            InmConsumerElement.DetailNameRusUser = "Опора шаровая";
            InmConsumerElement.AccPriceOrdPotrRUR = 1000;
            InmConsumerElement.AccPriceLastPotrRUR = 1000;
            InmConsumerElement.AccQuantity = 1;
            InmConsumerElement.DestinationLogo = "WMS";
            InmConsumerElement.GlobalId = 111111;
            InmConsumerElement.MakeLogo = "TY";
            InmConsumerElement.PotrebitelId = "111";
            InmConsumerElement.PotrebitelReference = "111";
            InmConsumerElement.PriceLogo = "WMS";
            InmConsumerElement.PotrebitelName = "111";
            InmConsumerElement.UserId = 112;
            InmConsumerElement.timestamp = "111";
            MainInmConsumerList.Add(InmConsumerElement);

            InmConsumerElement = new StaticVariables.InmConsumerElement();
            InmConsumerElement.DetailNum = "CBT41";
            InmConsumerElement.DetailNameRusUser = "Опора шаровая 1";
            InmConsumerElement.AccPriceOrdPotrRUR = 2000;
            InmConsumerElement.AccPriceLastPotrRUR = 2000;
            InmConsumerElement.AccQuantity = 2;
            InmConsumerElement.DestinationLogo = "TMS";
            InmConsumerElement.GlobalId = 2222222;
            InmConsumerElement.MakeLogo = "MC";
            InmConsumerElement.PotrebitelId = "222";
            InmConsumerElement.PotrebitelReference = "222";
            InmConsumerElement.PriceLogo = "TMS";
            InmConsumerElement.PotrebitelName = "222";
            InmConsumerElement.UserId = 112;
            InmConsumerElement.timestamp = "222";
            MainInmConsumerList.Add(InmConsumerElement);

            InmConsumerElement = new StaticVariables.InmConsumerElement();
            InmConsumerElement.DetailNum = "CBT42";
            InmConsumerElement.DetailNameRusUser = "Опора шаровая 2";
            InmConsumerElement.AccPriceOrdPotrRUR = 3000;
            InmConsumerElement.AccPriceLastPotrRUR = 3000;
            InmConsumerElement.AccQuantity = 3;
            InmConsumerElement.DestinationLogo = "YMS";
            InmConsumerElement.GlobalId = 111111;
            InmConsumerElement.MakeLogo = "NS";
            InmConsumerElement.PotrebitelId = "333";
            InmConsumerElement.PotrebitelReference = "333";
            InmConsumerElement.PriceLogo = "YMS";
            InmConsumerElement.PotrebitelName = "333";
            InmConsumerElement.UserId = 112;
            InmConsumerElement.timestamp = "333";
            MainInmConsumerList.Add(InmConsumerElement);

            InmConsumerElement = new StaticVariables.InmConsumerElement();
            InmConsumerElement.DetailNum = "CBT43";
            InmConsumerElement.DetailNameRusUser = "Опора шаровая 4";
            InmConsumerElement.AccPriceOrdPotrRUR = 4000;
            InmConsumerElement.AccPriceLastPotrRUR = 4000;
            InmConsumerElement.AccQuantity = 4;
            InmConsumerElement.DestinationLogo = "EMS";
            InmConsumerElement.GlobalId = 4444444;
            InmConsumerElement.MakeLogo = "MZ";
            InmConsumerElement.PotrebitelId = "444";
            InmConsumerElement.PotrebitelReference = "444";
            InmConsumerElement.PriceLogo = "EMS";
            InmConsumerElement.PotrebitelName = "444";
            InmConsumerElement.UserId = 112;
            InmConsumerElement.timestamp = "444";
            MainInmConsumerList.Add(InmConsumerElement);
        }
    }
}
