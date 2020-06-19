using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns
{
    public class Revolver : IWeapon
    {
        string _name = "revolver";
        public string Name
        {
            get => _name;
        }
        public string Shoot()
        {
            return "Pum Pum ..";
        }
    }
}
