using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class BankNote:Money
    {

        public BankNote()
        {

        }
        public BankNote(string name, double value, int width, int height, int length) : base(name, value)
        {
            base.Volume = width * height * length;
        }
    }
}
