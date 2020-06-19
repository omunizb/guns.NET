using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns.Models.Weapons.Tank
{
    public class Missile : IWeapon
    {
        string _name = "anti-tank guided missile";
        public string Name
        {
            get => _name;
        }
        public string Shoot()
        {
            return "Whooooosh... Bang!";
        }
    }
}
