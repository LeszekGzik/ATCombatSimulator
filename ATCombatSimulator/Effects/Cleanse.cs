﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator.Effects
{
    class Cleanse : Effect
    {
        public Cleanse()
        {
            this.Type = "cleanse";
        }

        public override String toXMLNode()
        {
            String node = "<effect type=\"" + Type + "\" />";
            return node;
        }

        public override String execute(Character user, Character target)
        {
            String result = "";
            if (user.poisoned)
            {
                user.poisoned = false;
                result += user.name + " is no longer poisoned.\n";
            }

            return result;
        }
    }
}
