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
        public List<Effect> Effects { get => effects; set => effects = value; }

        public Ability()
        {
            effects = new List<Effect>();
        }

        public Ability(String _name, int _spcost)
        {
            Name = _name;
            SpCost = _spcost;
            Effects = new List<Effect>();
        }

        public String execute(Character user, Character target)
        {
            user.currentSP -= SpCost;
            String result = user.name + " used " + name + "!\n";
            foreach(Effect e in Effects)
            {
                result += e.execute(user, target);
            }
            return result;
        }

        public String getEffectsAsXML()
        {
            String xml = "";
            foreach (Effect e in Effects)
            {
                xml += e.toXMLNode();
            }
            return xml;
        }
    }
}
