using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccalc
{
    class Calculator
    {
        public int GetCombatLvl(int atk, int str, int hps, int def, int rng, int mag, int pra)
        {
            int base_lvl = Convert.ToInt32(pra / 2 - 0.5 + hps + def) / 4;
            int melee = Convert.ToInt32((atk + str) * 0.325);
            int range = rng;
            int mage = mag;

            if (range > melee || mage > melee)
            {
                return range >= mage ? base_lvl + Convert.ToInt32(range * 1.5 * 0.325) : base_lvl + Convert.ToInt32(mage * 1.5 * 0.325);
            }

            return base_lvl + melee;
        }
    }
}
