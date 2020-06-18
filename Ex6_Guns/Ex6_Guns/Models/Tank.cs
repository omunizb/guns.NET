using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns.Models
{
    class Tank
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
            return weapon.Shoot();
        }
    }
}
