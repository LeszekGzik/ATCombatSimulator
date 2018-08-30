using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator.Effects
{
    public class SPRecovery : Effect
    {
        int power;
        int crit;
        int accuracy;

        public int Power { get => power; set => power = value; }
        public int Crit { get => crit; set => crit = value; }
        public int Accuracy { get => accuracy; set => accuracy = value; }

        public SPRecovery()
        {
            this.Type = "spr";
        }

        public SPRecovery(int _pow, int _acc, int _crit)
        {
            Type = "spr";
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
            double healing = Power * (10 + user.level) / 10;

            //sprawdzenie trafienia
            if (random.Next(0, 100) < Accuracy)
            {
                //losowanie dmg
                healing *= (random.Next(90, 111) / 100.0);
                //sprawdzenie krytyka
                if (random.Next(0, 100) < Crit)
                {
                    result += "Critical success! ";
                    healing *= 1.5;
                }
                int oldSP = user.currentSP;
                user.currentSP += (int)healing;
                if (user.currentSP > user.maxSP)
                {
                    user.currentSP = user.maxSP;
                }
                int healingDone = user.currentHP - oldSP;
                result += user.name + " recovered " + healingDone + " SP.\n";
            }
            else
            {
                result += "Failed.\n";
            }

            return result;
        }
    }
}
