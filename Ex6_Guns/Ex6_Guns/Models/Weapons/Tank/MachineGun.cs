using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns.Models.Weapons.Tank
{
    public class MachineGun : IWeapon
    {
        string _name = "machine gun";
        public string Name
        {
            get => _name;
        }
        public string Shoot()
        {
            return "RA TATATATATA ..";
        }
    }
}
