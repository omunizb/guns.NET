using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns.Models.Weapons.Tank
{
    public class TankGun : IWeapon
    {
        string _name = "tank gun";
        public string Name
        {
            get => _name;
        }
        public string Shoot()
        {
            return "Booooooom! ..";
        }
    }
}
