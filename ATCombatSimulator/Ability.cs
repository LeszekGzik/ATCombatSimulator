using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator
{
    public class Ability
    {
        String name;
        int spCost;
        List<Effect> effects;

        public int SpCost { get => spCost; set => spCost = value; }
        public string Name { get => name; set => name = value; }

        public Ability() { }

        public Ability(String _name, int _spcost)
        {
            Name = _name;
            SpCost = _spcost;
            effects = new List<Effect>();
        }

        public String execute(Character user, Character target)
        {
            user.currentSP -= SpCost;
            String result = "";
            foreach(Effect e in effects)
            {
                result += e.execute(user, target);
            }
            return result;
        }
    }
}
