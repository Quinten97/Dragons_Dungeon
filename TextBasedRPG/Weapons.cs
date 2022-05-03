using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Weapons
    { 
 // Weapons baseDamage,strRequirement, magRequirement, dexRequirement, magDmg, firDmg, iceDmg, ligDmg, bleDmg, Name
        public static List<object> battleAxe = new List<object> { 4, 3, 0, 1, 0, 0, 0, 0, 0, "Battle Axe" };
        public static List<object> mageStaff = new List<object> { 1, 0, 3, 1, 3, 0, 0, 0, 0, "Mage Staff" };
        public static List<object> twinDaggers = new List<object> { 2, 1, 1, 1, 0, 0, 0, 0, 2, "Twin Daggers" };
    }
}