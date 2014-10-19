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
            JohnTheBaptist Pesho = new JohnTheBaptist("Baptist", "Ooga Booga", 250, 20, 60, 10, 40);
            Console.WriteLine(Gosho.Health);
            Mitko.CastSkillOne(Gosho);
            Console.WriteLine(Gosho.Health);
            Console.WriteLine(Mitko.Health);
            Mitko.CastSkillFour(Gosho);
            Console.WriteLine(Mitko.Health);
            Console.WriteLine(Gosho.Health);
            Pesho.CastSkillFour(Mitko);
            Console.WriteLine(Mitko.Health);
        }
    }
}
