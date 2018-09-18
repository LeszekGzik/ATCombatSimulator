using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator.Effects
{
    class PoisonSelf : Effect
    {
        int accuracy;

        public int Accuracy { get => accuracy; set => accuracy = value; }

        public PoisonSelf()
        {
            this.Type = "psnself";
        }

        public PoisonSelf(int _acc)
        {
            this.Type = "psn";
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
                user.poisoned = true;
                result += user.name + " is now poisoned.\n";
            }
            return result;
        }
    }
}
