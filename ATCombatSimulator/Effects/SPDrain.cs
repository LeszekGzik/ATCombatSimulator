using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator.Effects
{
    public class SPDrain : Effect
    {
        int power;
        int crit;
        int accuracy;

        public int Power { get => power; set => power = value; }
        public int Crit { get => crit; set => crit = value; }
        public int Accuracy { get => accuracy; set => accuracy = value; }

        public SPDrain()
        {
            this.Type = "spd";
        }

        public SPDrain(int _pow, int _acc, int _crit)
        {
            Type = "spd";
            Power = _pow;
            Accuracy = _acc;
            Crit = _crit;
        }

        public override String toXMLNode()
        {
            String node = "<effect type=\"" + Type + "\" pow=\"" + Power + "\" acc=\"" + Accuracy + "\" crit=\"" + Crit + "\" />";
            return node;
        }

        public override String execute(Character user, Character target)
        {
            String result = "";
            double damage = Power * (10 + user.level) / 10;
            int hitPercent = Accuracy + 2 * user.AGI - 2 * target.AGI;
            int critPercent = Crit + user.LCK - target.LCK;

            //sprawdzenie trafienia
            if (random.Next(0, 100) < Accuracy)
            {
                //losowanie dmg
                damage *= (random.Next(90, 111) / 100.0);
                //sprawdzenie krytyka
                if (random.Next(0, 100) < Crit)
                {
                    result += "Critical success! ";
                    damage *= 1.5;
                }
                int oldSP = target.currentSP;
                target.currentSP -= (int)damage;
                if (target.currentSP < 0)
                {
                    target.currentSP = 0;
                }
                int drainDone = oldSP - target.currentSP;
                result += target.name + " lost " + drainDone + " SP.\n";
            }
            else
            {
                result += "Miss!\n";
            }

            return result;
        }
    }
}
