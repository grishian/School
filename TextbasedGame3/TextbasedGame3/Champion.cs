using System;

namespace TexBasedGame3
{
    class Champion : IInteractie
    {

        //fields and properties

        public string naam { get; set; }
        public int health { get; set; }
        public int maxHealth { get; set; }
        public int stamina { get; set; }
        public int maxStamina { get; set; }
        public int strength { get; set; }
        public int attack { get; set; }
        public int defence { get; set; }

        private Random rndm;
        private int points = 10;
        private ColorTextEnzo k = new ColorTextEnzo();
        public int damage { get; set; }
        public int healPotions { get; set; }
        public int strengthPotions { get; set; }

        //ctor's
        public Champion()
        {
            naam = "Dirk";
            health = 0;
        }
        public Champion(string naam, int health, int attack, int strength, int defence, int stamina)
        {
            this.naam = naam;
            this.health = health;
            this.stamina = stamina;
            maxStamina = stamina;
            maxHealth = health;
            this.attack = attack;
            this.strength = strength;
            this.defence = defence;

            healPotions = 3;
            strengthPotions = 3;
            //voor het aantal potions iets in te stellen.
        }
        //methods
        public string Customize()
        {
            k.White();
            Console.WriteLine("Customize de champion:\n");
            k.Reset();
            k.Yellow();
            Console.WriteLine($"Je krijgt {points} punten om in je vaardigheden te steken.\n" +
                $"Punten beschrijven hoe goed je bent in een bepaalde vaardigheid.\n" +
                $"Beschikbare vaardigheden:\n" +
                $"- Health\n" +
                $"- Attack\n" +
                $"- Strenght\n" +
                $"- Defence\n" +
                $"- Stamina\n");
            k.Reset();

            do
            {
                points += stamina / 100;

                k.Green();
                Console.WriteLine($"Puntenstand: {points}");
                k.Reset();
                Console.Write("\nGeef je punten in voor de Stamina vaardigheid: ");
                stamina = int.Parse(Console.ReadLine());
                maxStamina = stamina * 100;
                points -= stamina;

                if (points < 0)
                {
                    k.Red();
                    Console.WriteLine($"Je hebt te veel punten willen gebruiken. Puntenstand: {points}\n" +
                        $"Probeer op nieuw: \n");
                    k.Reset();
                }

                Console.WriteLine("--------------------------------------------------------");
                stamina *= 100;

            } while (points < 0);

            do
            {
                points += health / 100;

                k.Green();
                Console.WriteLine($"Puntenstand: {points}");
                k.Reset();
                Console.Write("\nGeef je punten in voor de Health vaardigheid: ");
                health = int.Parse(Console.ReadLine());
                maxHealth = health * 100;
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

            Console.Clear();
            k.Orange();
            return string.Format($"Customization voltooid!\n" +
                $"Jouw vaardigheden:\n" +
                $"- Health: {health}\n" +
                $"- Attack: {attack}\n" +
                $"- Strenght: {strength}\n" +
                $"- Defence: {defence}\n" +
                $"- Stamnia: {stamina}\n");
        }


        public int ValAan()
        {
            rndm = new Random();
            damage = rndm.Next(0 + attack, 51 + strength);


            return damage;
        }

        public string ShowStats()
        {

            return string.Format($"" +
                $"Champion naam: {naam}\n" +
                $"Health: {health}\n" +
                $"Attack: {attack}\n" +
                $"Strength: {strength}\n" +
                $"Defence: {defence}\n" +
                $"Stamina: {stamina}\n");
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
