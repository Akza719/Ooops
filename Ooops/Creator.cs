using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops
{
    public abstract class Creator
    {
        private int _creativityLevel = 100;
        private int _energy = 100;

        public int CreativityLevel
        { 
            get
            {
                return _creativityLevel;
            }
            set
            {
                 if (value >= 0 && value <= 100)
                {
                    _creativityLevel = value;
                }
                else
                {
                    throw new Exception("Creativity Level can only have value between 0 and 100");
                }
            }
        }

        public int Energy
        {
            get
            {
                return _energy;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _energy = value;
                }
                else
                {
                    throw new Exception(" Energy can only have value between 0 and 100");
                }
            }
        }
        public abstract void Create();
    }
}
