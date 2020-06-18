using System;

namespace Ex6_Guns
{
    // Exercise derived from https://anexsoft.com/ejemplo-de-inyeccion-de-dependencias-con-c
    class Program
    {
        static void Main(string[] args)
        {
            Gatling gatling = new Gatling();
            Rifle rifle = new Rifle();
            Soldier soldier = new Soldier(gatling, rifle);
            Console.WriteLine(soldier.Shoot(rifle));
        }
    }
}
