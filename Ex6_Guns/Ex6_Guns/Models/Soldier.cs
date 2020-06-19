using Ex6_Guns.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns
{
    class Soldier : EquipWeapon
    {
        protected IWeapon[] weapons;

        public Soldier(params IWeapon[] _weapons)
        {
            weapons = _weapons;
        }

        public string Shoot()
        {
            return "unarmed!";
        }
        public string Shoot(IWeapon weapon)
        {
            changeWeapon(weapon);
            return weapon.Shoot();
        }

        public override void changeWeapon(IWeapon weapon)
        {
            Console.WriteLine($"The soldier is now using the {weapon.Name}.");
        }
    }
}
