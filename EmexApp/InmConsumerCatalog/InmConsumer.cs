using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmexApp
{
    class InmConsumer : IInmConsumer
    {
        List<InmConsumerDefault> MainInmConsumerList;
        IWholesaler whosalerObject;

        public InmConsumer(IWholesaler whosalerObject)
        {
            this.whosalerObject = whosalerObject;
            IniteInmConsumerList();
        }

        public List<InmConsumerDefault> InmConsumerList(StaticVariables.WholesalerElement WholesalerElement)
        {
            List<InmConsumerDefault> inmConsumerList = new List<InmConsumerDefault>();
            foreach (InmConsumerDefault inmConsumerElement in MainInmConsumerList)
            {
                if (inmConsumerElement.PotrebitelId == WholesalerElement.ConsumerId)
                {
                    inmConsumerList.Add(inmConsumerElement);
                }
            }
            return inmConsumerList;
        }

        private void IniteInmConsumerList()
        {
            Consumer consumerObject = new Consumer();
            MainInmConsumerList = new List<InmConsumerDefault>();
            InmConsumerDefault InmConsumerElement;
            int[] filterStatus = new int[1] { 7 };
            EmExInmotion.EmExInmotion inMotion = new EmExInmotion.EmExInmotion();
            EmExInmotion.InmConsumer_v2[] inmConsumerlist = inMotion.GetWholesalerInmotion(consumerObject.login, consumerObject.password, null, null, null, null, states:filterStatus, reference:null, detailNum:null, timestamp: null, activeOnly:true);
            foreach(EmExInmotion.InmConsumer_v2 inmConsumerElement in inmConsumerlist)
            {
                InmConsumerElement = new InmConsumerDefault();
                InmConsumerElement.DetailNum = inmConsumerElement.DetailNum;
                InmConsumerElement.DetailNameRusUser = inmConsumerElement.DetailNameRusUser;
                InmConsumerElement.AccPriceOrdPotrRUR = (decimal)inmConsumerElement.AccPriceOrdPotrRUR;
                InmConsumerElement.AccPriceLastPotrRUR = (decimal)inmConsumerElement.AccPriceLastPotrRUR;
                InmConsumerElement.AccQuantity = (short)inmConsumerElement.DetailQuantity;
                InmConsumerElement.DestinationLogo = inmConsumerElement.DestinationLogo;
                InmConsumerElement.GlobalId = inmConsumerElement.GlobalId;
                InmConsumerElement.MakeLogo = inmConsumerElement.MakeLogo;
                InmConsumerElement.PotrebitelId = (long)inmConsumerElement.PotrebitelId;
                InmConsumerElement.PotrebitelReference = inmConsumerElement.PotrebitelReference;
                InmConsumerElement.PriceLogo = inmConsumerElement.PriceLogo;
                InmConsumerElement.PotrebitelName = inmConsumerElement.PotrebitelName;
                InmConsumerElement.UserId = inmConsumerElement.UserId;
                InmConsumerElement.state = (byte)inmConsumerElement.State;
                MainInmConsumerList.Add(InmConsumerElement);
                whosalerObject.AddWholesalerElement(inmConsumerElement);
            }
        }
    }
}
