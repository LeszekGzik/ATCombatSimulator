using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator.Effects
{
    class ParalyzeSelf : Effect
    {
        int accuracy;

        public int Accuracy { get => accuracy; set => accuracy = value; }

        public ParalyzeSelf()
        {
            this.Type = "parself";
        }

        public ParalyzeSelf(int _acc)
        {
            this.Type = "parself";
            this.Accuracy = _acc;
        }

        public override String toXMLNode()
        {
            String node = "<effect type=\"" + Type + "\" acc=\"" + Accuracy + "\" />";
            return node;
        }

        public override String execute(Character user, Character target)
        {
            String result = "";
            //sprawdzenie trafienia
            if (random.Next(0, 100) < Accuracy)
            {
                user.paralyzed = true;
                result += user.name + " is now paralyzed.\n";
            }
            return result;
        }
    }
}
