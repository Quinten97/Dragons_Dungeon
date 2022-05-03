using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Player
    {
        public static string playerName;

        // Armor Sets hpBonus, manaBonus, armorBonus, magRes, firRes, iceRes, ligRes, bleRes, Name
        public static List<object> equipedArmor = new List<object> { 0, 0, 0, 0, 0, 0, 0, 0, "" };

        // Weapons baseDamage,strRequirement, magRequirement, dexRequirement, magDmg, firDmg, iceDmg, ligDmg, bleDmg, Name
        public static List<object> equipedWeapon = new List<object> { 0, 0, 0, 0, 0, 0, 0, 0, 0, "" };

        public static int baseHp;
        public static int hpBonus;
        public static int maxHp;
        public static int currentHp;

        public static int baseMana;
        public static int manaBonus;
        public static int maxMana;
        public static int currentMana;


        public static int maxExp = 100;
        public static int currentExp = 0;

        public static int strength;
        public static int magic;
        public static int dexterity;

        public static int armorClass;

        public static int magicResistance;
        public static int fireResistance;
        public static int iceResistance;
        public static int lightningResistance;
        public static int bleedResistance;

        public static int physicalDamage;
        public static int magicDamage;
        public static int fireDamage;
        public static int iceDamage;
        public static int lightningDamage;
        public static int bleedDamage;


        public static List<object> consumables = new List<object>();
        public static List<object> inventoryWeapons = new List<object>();
        public static List<object> inventoryArmor = new List<object>();
        public static List<object> keys = new List<object>();




        //---------------------------------------------------------------------------------------------------------------

        //Get stats from equiped armor
        public static int HpFromArmor()
        {
            int weaponInt = (int)equipedArmor[0];
            return weaponInt;
        }
        public static int ManaFromArmor()
        {
            int weaponInt = (int)equipedArmor[1];
            return weaponInt;
        }
        public static int armor()
        {
            int weaponInt = (int)equipedArmor[2];
            return weaponInt;
        }
        public static int MagicFromArmor()
        {
            int weaponInt = (int)equipedArmor[3];
            return weaponInt;
        }
        public static int FireFromArmor()
        {
            int weaponInt = (int)equipedArmor[4];
            return weaponInt;
        }
        public static int IceFromArmor()
        {
            int weaponInt = (int)equipedArmor[5];
            return weaponInt;
        }
        public static int LightningFromArmor()
        {
            int weaponInt = (int)equipedArmor[6];
            return weaponInt;
        }
        public static int BleedFromArmor()
        {
            int weaponInt = (int)equipedArmor[7];
            return weaponInt;
        }

        //---------------------------------------------------------------------------------------------------------------


        //---------------------------------------------------------------------------------------------------------------

        //Get stats from equiped weapon
        public static int PhyDmgWeapon()
        {
            int weaponInt = (int)equipedWeapon[0];
            return weaponInt;
        }
        public static int StrReqWeapon()
        {
            int weaponInt = (int)equipedWeapon[1];
            return weaponInt;
        }
        public static int MagReqWeapon()
        {
            int weaponInt = (int)equipedWeapon[2];
            return weaponInt;
        }
        public static int DexReqWeapon()
        {
            int weaponInt = (int)equipedWeapon[3];
            return weaponInt;
        }
        public static int MagDmgWeapon()
        {
            int weaponInt = (int)equipedWeapon[4];
            return weaponInt;
        }
        public static int FirDmgWeapon()
        {
            int weaponInt = (int)equipedWeapon[5];
            return weaponInt;
        }
        public static int IceDmgWeapon()
        {
            int weaponInt = (int)equipedWeapon[6];
            return weaponInt;
        }
        public static int LigDmgWeapon()
        {
            int weaponInt = (int)equipedWeapon[7];
            return weaponInt;
        }
        public static int BleDmgWeapon()
        {
            int weaponInt = (int)equipedWeapon[8];
            return weaponInt;
        }

        //---------------------------------------------------------------------------------------------------------------


        public static void InitializeStats
         (
            int aBaseHp,
            int aBaseMana,
            int aStrength,
            int aMagic,
            int aDexterity
         )
        {
            baseHp = aBaseHp;
            baseMana = aBaseMana;
            strength = aStrength;
            magic = aMagic;
            dexterity = aDexterity;

        }
        public static void InitializeArmorStats()
        {
            hpBonus = HpFromArmor();
            manaBonus = ManaFromArmor();
            armorClass = armor();
            magicResistance = MagicFromArmor();
            fireResistance = FireFromArmor();
            iceResistance = IceFromArmor();
            lightningResistance = LightningFromArmor();
            bleedResistance = BleedFromArmor();

        }
        public static void InitializeWeaponStats()
        {
            physicalDamage = PhyDmgWeapon();
            magicDamage = MagDmgWeapon();
            fireDamage = FirDmgWeapon();
            iceDamage = IceDmgWeapon();
            lightningDamage = LigDmgWeapon();
            bleedDamage = BleDmgWeapon();
        }
        public static void EquipArmor(dynamic selectedArmor)
        {
            equipedArmor.Clear();
            equipedArmor.AddRange(selectedArmor);
        }
        public static void UnEquipArmor()
        {
            equipedArmor.Clear();
        }
        public static void EquipWeapon(dynamic selectedWeapon)
        {
            equipedWeapon.Clear();
            equipedWeapon.AddRange(selectedWeapon);
        }
        public static void UnEquipWeapon()
        {
            equipedWeapon.Clear();
        }
        public static void CalculateTotals()
        {
            maxHp = baseHp + hpBonus;
            maxMana = baseMana + manaBonus;
        }
    }
}