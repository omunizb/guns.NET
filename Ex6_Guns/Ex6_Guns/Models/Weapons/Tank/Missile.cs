using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns.Models.Weapons.Tank
{
    public class Missile : IWeapon
    {
        public string Shoot()
        {
            return "Whooooosh... Bang!";
        }
    }
}
