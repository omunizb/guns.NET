using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns
{
    public class Gatling : IWeapon
    {
        string _name = "gatling";
        public string Name
        {
            get => _name;
        }

        public string Shoot()
        {
            return "Ra ta ta ta ta ..";
        }
    }
}
