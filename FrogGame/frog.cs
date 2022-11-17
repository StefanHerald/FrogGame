using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogGame
{
    internal abstract class Frog
    {
        protected float width, stability;
        protected int flyCost, fireFlyCost;
        protected List<subType> subTypes = new List<subType>();
        protected List<status> statuses = new List<status>();
        public enum subType
        {
            fly_catching,
            ferocious,
            resistant,
            coldresistant,
            flameresistant
        }

        public enum status
        {
            brittle,
            frozen,
            onfire, 
        }
    }
}
