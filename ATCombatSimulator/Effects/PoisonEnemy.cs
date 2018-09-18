using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator.Effects
{
    public class PoisonEnemy : Effect
    {
        int accuracy;

        public int Accuracy { get => accuracy; set => accuracy = value; }

        public PoisonEnemy()
        {
            this.Type = "psn";
        }

        public PoisonEnemy(int _acc)
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
            int hitPercent = Accuracy + 2 * user.AGI - 2 * target.AGI;
            //sprawdzenie trafienia
            if (random.Next(0, 100) < hitPercent)
            {
                target.poisoned = true;
                result += target.name + " is now poisoned.\n";
            }
            return result;
        }
    }
}
