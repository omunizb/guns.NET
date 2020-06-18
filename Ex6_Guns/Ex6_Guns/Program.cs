using System;

namespace Ex6_Guns
{
    // Exercise derived from https://anexsoft.com/ejemplo-de-inyeccion-de-dependencias-con-c
    class Program
    {
        static void Main(string[] args)
        {
            var soldier = new Soldier(new Gatling());
            Console.WriteLine(soldier.Shoot());
        }
    }
}
