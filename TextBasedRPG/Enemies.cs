using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Enemies
    {
        /* Name, HP, MP, Armor, magRes, 
         * firRes, iceRes, ligRes, bleRes, 
         * damage, magDmg, firDmg, iceDmg, 
         * ligDmg, bleDmg */

        public static List<object> orc = new List<object> {
            /*Name 0*/ "ogre",
            /*HP 1*/ 25, 
            /*MP 2*/ 10, 
            /*Armor 3*/ 3, 
            /*magRes 4*/ 1,
            /*firRes 5*/ -1,
            /*iceRes 6*/ 0,
            /*ligRes 7*/ 0,
            /*bleRes 8*/ -1,
            /*Dmg 9*/ 4,
            /*magDmg 10*/ 0,
            /*firDmg 11*/ 0,
            /*iceDmg 12*/ 0,
            /*ligDmg 13*/ 0,
            /*bleDmg 14*/ 0
        };
    }
}
