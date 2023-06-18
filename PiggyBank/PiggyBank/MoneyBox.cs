using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class MoneyBox
    {
        private List<Money> MoneyInTheBox;
        private double TotalVolume;
        private double UsedVolume;

        public MoneyBox()
        {
            MoneyInTheBox = new List<Money>();
            TotalVolume = 7500000; //in mm
            UsedVolume = 0;
        }

        public bool AddMoney (Money moneyToAdd)
        {
            if((UsedVolume + moneyToAdd.Volume) > TotalVolume)
            {
                return false;
            }
            MoneyInTheBox.Add(moneyToAdd);
            UsedVolume += moneyToAdd.Volume;
            return true;
        }

        public List<Money> FinishHim()
        {
            return MoneyInTheBox;
        }
    }
}
