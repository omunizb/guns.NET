using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns
{
    public class Rifle : IWeapon
    {
        public string Shoot()
        {
            return "Pum pum pum pum pum ..";
        }
    }
}
