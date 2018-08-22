using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator
{
    public class Ability
    {
        int power;
        String name;
        int spCost;
        double accuracy;
        Boolean physical;

        public int Power { get => power; set => power = value; }
        public int SpCost { get => spCost; set => spCost = value; }
        public double Accuracy { get => accuracy; set => accuracy = value; }
        public bool Physical { get => physical; set => physical = value; }
        public string Name { get => name; set => name = value; }
    }
}
