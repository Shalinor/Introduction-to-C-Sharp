using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Crap
    {
        int individualValue = 1;

        public Crap()
        {
        }

        public void SetValue(int increment_)
        {
            individualValue = increment_;
        }

        public void IncrementValue()
        {
            individualValue += 100;
        }

        public int GetValue()
        {
            return individualValue;
        }

        public static Crap Duplicate (Crap c1)
        {
            Crap temp = new Crap();
            temp.individualValue = c1.individualValue;
            return temp;
        }
    }
}
