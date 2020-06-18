using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns
{
    class Soldier
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
            return weapon.Shoot();
        }
    }
}
