using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmexApp
{
    class WholesalerMock : IWholesaler
    {
        List<StaticVariables.WholesalerElement> WholesalerList;
        public WholesalerMock()
        {
            IniteWholesalerList();
        }

        public StaticVariables.WholesalerElement WholesalerElement(int WholesalerIndex)
        {
            return WholesalerList[WholesalerIndex];
        }

        public List<string> WholesalerRepresentationList()
        {
            List<string> RepresentationList = new List<string>();
            foreach (StaticVariables.WholesalerElement Wholesaler in WholesalerList)
            {
                StringBuilder WholesalerRepresentation = new StringBuilder();
                WholesalerRepresentation.Append(Wholesaler.UserLogo);
                WholesalerRepresentation.Append(" (");
                WholesalerRepresentation.Append(Wholesaler.UserFamily);
                WholesalerRepresentation.Append(Wholesaler.UserFirstName);
                WholesalerRepresentation.Append(Wholesaler.UserLastName);
                WholesalerRepresentation.Append(")");
                RepresentationList.Add(WholesalerRepresentation.ToString());
            }
            return RepresentationList;
        }

        private void IniteWholesalerList()
        {
            WholesalerList = new List<StaticVariables.WholesalerElement>();
            StaticVariables.WholesalerElement Wholesaler;

            Wholesaler = new StaticVariables.WholesalerElement();
            Wholesaler.UserId = 1;
            Wholesaler.ConsumerId = 11;
            Wholesaler.UserFamily = "Иванов";
            Wholesaler.UserFirstName = "Иван";
            Wholesaler.UserLastName = "Иванович";
            Wholesaler.UserLogo = "Иванов";
            Wholesaler.LocationId = "Астрахань";
            Wholesaler.LocationAddress = "город Астрахань";
            Wholesaler.LocationAddressAdditional = "Астраханб снова";
            Wholesaler.OptovikManagerId = "Иванов продавец";
            Wholesaler.OptovikManagerFio = "Иванов Иван продавец";
            WholesalerList.Add(Wholesaler);

            Wholesaler = new StaticVariables.WholesalerElement();
            Wholesaler.UserId = 2;
            Wholesaler.ConsumerId = 22;
            Wholesaler.UserFamily = "Петров";
            Wholesaler.UserFirstName = "Петр";
            Wholesaler.UserLastName = "Петрович";
            Wholesaler.UserLogo = "Иванов";
            Wholesaler.LocationId = "Волгоград";
            Wholesaler.LocationAddress = "город Волгоград";
            Wholesaler.LocationAddressAdditional = "Волгоград снова";
            Wholesaler.OptovikManagerId = "Петров продавец";
            Wholesaler.OptovikManagerFio = "Петров Петр продавец";
            WholesalerList.Add(Wholesaler);

            Wholesaler = new StaticVariables.WholesalerElement();
            Wholesaler.UserId = 3;
            Wholesaler.ConsumerId = 33;
            Wholesaler.UserFamily = "Федоров";
            Wholesaler.UserFirstName = "Федор";
            Wholesaler.UserLastName = "Федорович";
            Wholesaler.UserLogo = "Федоров";
            Wholesaler.LocationId = "Москва";
            Wholesaler.LocationAddress = "город Москва";
            Wholesaler.LocationAddressAdditional = "Москва снова";
            Wholesaler.OptovikManagerId = "Федоров продавец";
            Wholesaler.OptovikManagerFio = "Федоров Федор продавец";
            WholesalerList.Add(Wholesaler);
        }
    }
}