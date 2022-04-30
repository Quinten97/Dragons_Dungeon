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

        // Armor Sets hpBonus, manaBonus, armorBonus, magRes, firRes, iceRes, ligRes, bleRes
        public static object[] equipedArmor = { 0, 0, 0, 0, 0, 0, 0, 0 };

        // Weapons baseDamage,strRequirement, magRequirement, dexRequirement, magDmg, firDmg, iceDmg, ligDmg, bleDmg
        public static object[] equipedWeapon = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

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


        public static string[] items = { };


//---------------------------------------------------------------------------------------------------------------

        //Get stats from equiped armor
        public static int HpFromArmor()
        {
            Int32.TryParse(equipedArmor[0].ToString(), out int armorInt);
            return armorInt;
        }
        public static int ManaFromArmor()
        {
            Int32.TryParse(equipedArmor[1].ToString(), out int armorInt);
            return armorInt;
        }
        public static int armor()
        {
            Int32.TryParse(equipedArmor[2].ToString(), out int armorInt);
            return armorInt;
        }
        public static int MagicFromArmor()
        {
            Int32.TryParse(equipedArmor[3].ToString(), out int armorInt);
            return armorInt;
        }
        public static int FireFromArmor()
        {
            Int32.TryParse(equipedArmor[4].ToString(), out int armorInt);
            return armorInt;
        }
        public static int IceFromArmor()
        {
            Int32.TryParse(equipedArmor[5].ToString(), out int armorInt);
            return armorInt;
        }
        public static int LightningFromArmor()
        {
            Int32.TryParse(equipedArmor[6].ToString(), out int armorInt);
            return armorInt;
        }
        public static int BleedFromArmor()
        {
            Int32.TryParse(equipedArmor[7].ToString(), out int armorInt);
            return armorInt;
        }

        //---------------------------------------------------------------------------------------------------------------


        //---------------------------------------------------------------------------------------------------------------

        //Get stats from equiped weapon
        public static int PhyDmgWeapon()
        {
            Int32.TryParse(equipedArmor[0].ToString(), out int weaponint);
            return weaponint;
        }
        public static int StrReqWeapon()
        {
            Int32.TryParse(equipedArmor[1].ToString(), out int weaponint);
            return weaponint;
        }
        public static int MagReqWeapon()
        {
            Int32.TryParse(equipedArmor[2].ToString(), out int weaponint);
            return weaponint;
        }
        public static int DexReqWeapon()
        {
            Int32.TryParse(equipedArmor[3].ToString(), out int weaponint);
            return weaponint;
        }
        public static int MagDmgWeapon()
        {
            Int32.TryParse(equipedArmor[4].ToString(), out int weaponint);
            return weaponint;
        }
        public static int FirDmgWeapon()
        {
            Int32.TryParse(equipedArmor[5].ToString(), out int weaponint);
            return weaponint;
        }
        public static int IceDmgWeapon()
        {
            Int32.TryParse(equipedArmor[6].ToString(), out int weaponint);
            return weaponint;
        }
        public static int LigDmgWeapon()
        {
            Int32.TryParse(equipedArmor[7].ToString(), out int weaponint);
            return weaponint;
        }
        public static int BleDmgWeapon()
        {
            Int32.TryParse(equipedArmor[7].ToString(), out int weaponint);
            return weaponint;
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
        public static void EquipArmor(object[] selectedArmor)
        {
            object[] equipedArmor = selectedArmor;
        }
        public static void UnEquipArmor()
        {
            object[] equipedArmor = { 0, 0, 0, 0, 0, 0, 0, 0 };
        }
        public static void EquipWeapon(object[] selectedWeapon)
        {
            object[] equipedWeapon = selectedWeapon;
        }
        public static void UnEquipWeapon()
        {
            object[] equipedWeapon = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }
        public static void CalculateTotals()
        {
            maxHp = baseHp + hpBonus;
            maxMana = baseMana + manaBonus;
        }
    }
}