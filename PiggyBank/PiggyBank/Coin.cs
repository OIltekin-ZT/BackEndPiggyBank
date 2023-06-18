using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Coin:Money
    {
        private readonly double piNum = 3.14;

        public Coin()
        {

        }
        public Coin(string name, double value, double radius, int height):base(name, value)
        {
            base.Volume = Math.Pow(radius, 2) * height * piNum;
        }
    }
}
