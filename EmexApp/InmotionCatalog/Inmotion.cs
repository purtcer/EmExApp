using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmexApp;

namespace EmexApp
{
    class Inmotion : IInmotion
    {
        private EmExInmotion.EmExInmotion emexInmotion;
        public Inmotion()
        {
            emexInmotion = new EmExInmotion.EmExInmotion();
        }

        void IInmotion.SetInmotionState(List<StaticVariables.InmotionElement> inmotionElements)
        {
            Consumer consumerObject = new Consumer();
            EmExInmotion.SetInmotionStateByGlobalIdInputItem inputItem;
            foreach (StaticVariables.InmotionElement inmotionElement in inmotionElements)
            {
                int elementsCount = inmotionElements.Count + 1;
                for (int i = 1; i < elementsCount; i++)
                {
                    inputItem = new EmExInmotion.SetInmotionStateByGlobalIdInputItem();
                    inputItem.Count = i;
                    inputItem.GlobalId = inmotionElement.GlobalId;
                    inputItem.State = EmExInmotion.SetInmotionStateEnum.AccReg;
                    EmExInmotion.SetInmotionStateByGlobalIdInputItem[] inputItems = new EmExInmotion.SetInmotionStateByGlobalIdInputItem[1];
                    inputItems[0] = inputItem;
                    EmexApp.EmExInmotion.SetInmotionStateByGlobalIdOutputItem[] result = emexInmotion.SetInmotionStateByGlobalId(consumerObject.login, consumerObject.password, inputItems);
                }
            }
        }
    }
}
