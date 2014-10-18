namespace MortalKombat
{
    using System;
    using MortalKombat.Characters;
    using MortalKombat.Interfaces;

    class MainClass
    {
        static void Main()
        {
            Alien Mitko = new Alien("Alien", "Vicious Predator", 200, 40, 50, 50, 20);
            Alien Gosho = new Alien("Predator", "Vicious Alien", 200, 40, 50, 50, 20);
            Console.WriteLine(Gosho.Health);
            Mitko.CastSkillOne(Gosho);
            Console.WriteLine(Gosho.Health);
        }
    }
}
