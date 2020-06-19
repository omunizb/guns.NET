using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Guns
{
    public interface IWeapon
    {
        string Name { get; }
        string Shoot();
    }
}
