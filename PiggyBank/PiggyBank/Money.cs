using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Money
    {
        private string _Name;
        private double _Value;
        private double _Volume;

        public Money()
        {

        }
        public Money(string name, double val)
        {
            _Name = name;
            _Value = val;
        }

        public string Name { get => _Name; set => _Name = value; }
        public double Value { get => _Value; set => _Value = value; }
        public double Volume { get => _Volume; set => _Volume = value; }
    }
}
