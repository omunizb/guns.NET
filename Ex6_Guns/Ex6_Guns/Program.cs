using Ex6_Guns.Models;
using Ex6_Guns.Models.Weapons.Tank;
using System;

namespace Ex6_Guns
{
    // Exercise derived from https://anexsoft.com/ejemplo-de-inyeccion-de-dependencias-con-c
    class Program
    {
        static void Main(string[] args)
        {
            Revolver revolver = new Revolver();
            Rifle rifle = new Rifle();
            Shotgun shotgun = new Shotgun();
            Gatling gatling = new Gatling();

            IWeapon[] soldierWeapons = { revolver, rifle, shotgun, gatling };

            Soldier soldier = new Soldier(soldierWeapons);
            Console.WriteLine("The soldier is trying his weapons: ");
            for (int i = 0; i < soldierWeapons.Length; i++)
            {
                Console.WriteLine(soldier.Shoot(soldierWeapons[i]));
            }

            Console.WriteLine();

            Console.WriteLine("The tank operators are doing some weapon tests: ");

            TankGun tankGun = new TankGun();
            MachineGun machineGun = new MachineGun();
            Missile missile = new Missile();

            IWeapon[] tankWeapons = { tankGun, machineGun, missile };

            Tank tank = new Tank(tankWeapons);
            for (int i = 0; i < tankWeapons.Length; i++)
            {
                Console.WriteLine(tank.Shoot(tankWeapons[i]));
            }
        }
    }
}
