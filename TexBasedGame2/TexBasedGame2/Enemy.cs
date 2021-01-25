using System;
using System.Collections.Generic;
using System.Text;

namespace TexBasedGame2
{
    class Enemy : IInteractie
    {

        //fields and properties

        public string naam { get; set; }
        public int health { get; set; }
        public int maxHealth { get; set; }
        public int strength { get; set; }
        public int attack { get; set; }
        public int defence { get; set; }
        public int damage { get; set; }

        private Random rndm;
        private int points = 15;
        ColorTextEnzo k = new ColorTextEnzo();

        //ctor's
        public Enemy() { 
            naam = "Voldemort";
            health = 0;
            attack = 0;
            strength = 0;
            defence = 0;
        }
        public Enemy(string naam, int health, int attack, int strength, int defence) {
            this.naam = naam;
            this.health = health;
            maxHealth = health;
            this.attack = attack;
            this.strength = strength;
            this.defence = defence;
        }

        //methods
        public string Customize()
        {
            k.White();
            Console.WriteLine("Customize de enemy:\n");
            k.Reset();
            k.Yellow();
            Console.WriteLine($"Je krijgt {points} punten om in je vaardigheden te steken.\n" +
                $"Punten beschrijven hoe goed je bent in een bepaalde vaardigheid.\n" +
                $"Beschikbare vaardigheden:\n" +
                $"- Health\n" +
                $"- Attack\n" +
                $"- Strenght\n" +
                $"- Defence\n");
            k.Reset();

            do
            {
                points += health;
                k.Green();
                Console.WriteLine($"Puntenstand: {points}");
                k.Reset();
                Console.Write("\nGeef je punten in voor de Health vaardigheid: ");
                health = int.Parse(Console.ReadLine());
                maxHealth = health*100;
                points -= health;

                if (points < 0)
                {
                    k.Red();
                    Console.WriteLine($"Je hebt te veel punten willen gebruiken. Puntenstand: {points}\n" +
                        $"Probeer op nieuw: \n");
                    k.Reset();
                }

                Console.WriteLine("--------------------------------------------------------");
                health *= 100;

            } while (points < 0);

            do
            {
                points += attack;
                k.Green();
                Console.WriteLine($"Puntenstand: {points}");
                k.Reset();
                Console.Write("\nGeef je punten in voor de Attack vaardigheid: ");
                attack = int.Parse(Console.ReadLine());
                points -= attack;

                if (points < 0)
                {
                    k.Red();
                    Console.WriteLine($"Je hebt te veel punten willen gebruiken. Puntenstand: {points}\n" +
                        $"Probeer op nieuw: \n");
                    k.Reset();
                }

                Console.WriteLine("--------------------------------------------------------");

            } while (points < 0);

            do
            {
                points += strength;
                k.Green();
                Console.WriteLine($"Puntenstand: {points}");
                k.Reset();
                Console.Write("\nGeef je punten in voor de Strength vaardigheid: ");
                strength = int.Parse(Console.ReadLine());
                points -= strength;

                if (points < 0)
                {
                    k.Red();
                    Console.WriteLine($"Je hebt te veel punten willen gebruiken. Puntenstand: {points}\n" +
                        $"Probeer op nieuw: \n");
                    k.Reset();
                }

                Console.WriteLine("--------------------------------------------------------");

            } while (points < 0);

            do
            {
                points += defence;
                k.Green();
                Console.WriteLine($"Puntenstand: {points}");
                k.Reset();
                Console.Write("\nGeef je punten in voor de Defence vaardigheid: ");
                defence = int.Parse(Console.ReadLine());
                points -= defence;

                if (points < 0)
                {
                    k.Red();
                    Console.WriteLine($"Je hebt te veel punten willen gebruiken. Puntenstand: {points}\n" +
                        $"Probeer op nieuw: \n");
                    k.Reset();
                }

                Console.WriteLine("--------------------------------------------------------");

            } while (points < 0);


            k.Orange();
            return string.Format($"Customization voltooid!\n" +
                $"Jouw vaardigheden:\n" +
                $"- Health: {health}\n" +
                $"- Attack: {attack}\n" +
                $"- Strenght: {strength}\n" +
                $"- Defence: {defence}\n");
        }
        public int ValAan()
        {
            rndm = new Random();
            damage = rndm.Next(0 + attack, 51 + strength);


            return damage;
        }

        public string ShowStats()
        {

            k.Orange();

            return string.Format($"" +
                $"- Enemy naam: {naam}\n" +
                $"- Health: {health}\n" +
                $"- Attack: {attack}\n" +
                $"- Strength: {strength}\n" +
                $"- Defence: {defence}\n");
        }

        public int Schild()
        {
            throw new NotImplementedException();
        }

        public int Ontwijk()
        {
            throw new NotImplementedException();
        }

        public int Heal()
        {
            throw new NotImplementedException();
        }
    }
}
