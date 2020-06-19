using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns
{
    public class Shotgun : IWeapon
    {
        string _name = "shotgun";
        public string Name
        {
            get => _name;
        }
        public string Shoot()
        {
            return "pum PUMMM !! ..";
        }
    }
}
