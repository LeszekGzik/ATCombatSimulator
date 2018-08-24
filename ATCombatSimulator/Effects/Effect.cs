using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator
{
    public abstract class Effect
    {
        String type;

        public string Type { get => type; set => type = value; }

        public abstract String execute(Character user, Character target);
    }
}
