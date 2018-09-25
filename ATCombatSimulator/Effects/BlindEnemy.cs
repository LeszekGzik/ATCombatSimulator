using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator.Effects
{
    class BlindEnemy : Effect
    {
        int accuracy;

        public int Accuracy { get => accuracy; set => accuracy = value; }

        public BlindEnemy()
        {
            this.Type = "bli";
        }

        public BlindEnemy(int _acc)
        {
            this.Type = "bli";
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
                target.blinded = true;
                result += target.name + " is now blinded.\n";
            }
            return result;
        }
    }
}
