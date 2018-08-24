using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator.Effects
{
    public class PhysicalDamage : Effect
    {
        int power;
        int crit;
        int accuracy;

        public int Power { get => power; set => power = value; }
        public int Crit { get => crit; set => crit = value; }
        public int Accuracy { get => accuracy; set => accuracy = value; }

        public PhysicalDamage()
        {
            this.Type = "pdmg";
        }

        public override String execute(Character user, Character target)
        {
            String result = "";
            Random random = new Random();
            int hitPercent = Accuracy + 2 * user.AGI - 2 * target.AGI;
            int critPercent = Crit + user.LCK - target.LCK;
            double damage = (user.ATK * (10 + user.level) * Power) / (10 * target.DEF);

            //sprawdzenie trafienia
            if (random.Next(0, 100) < hitPercent)
            {
                //losowanie dmg
                damage *= (random.Next(90, 111) / 100.0);
                //sprawdzenie krytyka
                if (random.Next(0, 100) < critPercent)
                {
                    result += "Critical hit! ";
                    damage *= 1.5;
                }
                target.currentHP -= (int)damage;
                result += target.name + " took " + (int)damage + " damage.\n";
            }
            else
            {
                result += "Miss!\n";
            }
            return result;
        }
    }
}
