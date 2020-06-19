using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns.Models
{
    class Tank : EquipWeapon
    {
        protected IWeapon[] weapons;

        public Tank(params IWeapon[] _weapons)
        {
            weapons = _weapons;
        }

        public string Shoot()
        {
            return "It's a toy tank!";
        }
        public string Shoot(IWeapon weapon)
        {
            changeWeapon(weapon);
            return weapon.Shoot();
        }
        public override void changeWeapon(IWeapon weapon)
        {
            Console.WriteLine($"The tank is now using the {weapon.Name}.");
        }
    }
}
