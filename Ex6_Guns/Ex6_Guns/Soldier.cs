using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns
{
    class Soldier
    {
        protected IWeapon weapon;

        public Soldier(IWeapon _weapon)
        {
            this.weapon = _weapon;
        }

        public string Shoot()
        {
            return weapon.Shoot();
        }
    }
}
