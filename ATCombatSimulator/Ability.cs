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
        int accuracy;
        int crit;
        Boolean physical;


        public int Power { get => power; set => power = value; }
        public int SpCost { get => spCost; set => spCost = value; }
        public int Accuracy { get => accuracy; set => accuracy = value; }
        public bool Physical { get => physical; set => physical = value; }
        public string Name { get => name; set => name = value; }
        public int Crit { get => crit; set => crit = value; }

        public Ability() { }

        public Ability(String _name, bool _physical, int _power, int _spcost, int _accuracy, int _crit)
        {
            Name = _name;
            Physical = _physical;
            Power = _power;
            SpCost = _spcost;
            Accuracy = _accuracy;
            Crit = _crit;
        }
    }
}
