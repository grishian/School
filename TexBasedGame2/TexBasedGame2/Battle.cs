﻿using System;

namespace TexBasedGame2
{
    class Battle
    {
        //fields and properties
        private Enemy e;
        private Champion c;
        private ColorTextEnzo k = new ColorTextEnzo();


        //ctor's
        public Battle(Enemy vijand, Champion speler)
        {
            e = vijand;
            c = speler;
        }

        //methods

        public void Gevecht()
        {
            Console.WriteLine("Druk enter in om te starten...");
            Console.ReadLine();
            Console.Clear();
            k.Yellow();
            Console.WriteLine("\nSpelregels:\n" +
                "- Geef a in om aan te vallen.\n" +
                "- Geef h in om een healing potion te nemen.\n" +
                "- Geef s in om een strength potion te nemen.\n" +
                "- Geef ...\n" +
                "- Geef ...\n");
            Console.WriteLine("Het gevecht is gestart: ...\n\n");


            do
            {
                
                Console.WriteLine("Geef een input in:");
                string input = Console.ReadLine();

                Console.Clear();

                switch (input)
                {
                    default:
                        break;

                    case "a":
                        e.health -= c.ValAan() + e.defence;
                        k.Yellow();
                        BattleScherm();
                        Console.Write($"\n{c.naam} valt aan en doet: ");
                        k.Red();
                        Console.Write($"{c.damage} schade.");
                        k.Reset();
                        Console.WriteLine($" Vijand \"{e.naam}\" heeft nog: {e.health} HP!");
                        break;

                    case "h":
                        c.health += 30;
                        BattleScherm();
                        Console.WriteLine($"\"{c.naam}\" neemt health potion en heeft nu: {c.health} HP!");    
                        break;

                    case "s":
                        c.strength += 30;
                        BattleScherm();
                        Console.WriteLine($"\"{c.naam}\" neemt strength potion en heeft nu: {c.strength} strength!");
                        break;
                }

                if (e.health > 0)
                {
                    k.Orange();
                    c.health -= e.ValAan() + c.defence;

                    k.Orange();
                    Console.Write($"{e.naam} valt aan en doet: ");
                    k.Red();
                    Console.Write($"{e.damage} schade.");
                    k.Reset();
                    Console.WriteLine($" Champion \"{c.naam}\" heeft nog: {c.health} HP!");
                    k.Yellow();
                }

            } while (e.health > 0 && c.health > 0);

            Winnaar();

        }

        public void BattleHealthBarChampion(Champion c) //voor moesten er meerdere champions tegelijk vechten
        {
            string[] healthBar = new string[20];

            int nieuweHealthOpTwintig = c.health/(c.maxHealth/20);

            //ik kan het ook wel met een forloop denk ik :'( oke we doen forloop, want anders gaat het nog lang duren.

            for (int i = 0; i < nieuweHealthOpTwintig; i++)
            {
                healthBar[i] = "#";
            }

            for (int i = 0; i < healthBar.Length; i++)
            {
                Console.Write(healthBar[i]);

            }

            for (int i = 0; i < 48 + (20 - nieuweHealthOpTwintig); i++)
            {
                Console.Write(" ");
            }
            

        }

        public string BattleHealthBarEnemy(Enemy e)
        {
            return string.Format("");
        }

        public void BattleScherm()
        {
            //champion health maak kleur rood als onder de 33%

            k.Purple();
            Console.Write($"{c.naam}: ");

            if (c.health < (c.maxHealth / 3))
            {
                k.Red();
            }
            else
            {
                k.Green();
            }
            //Console.Write($"{c.health}");
           BattleHealthBarChampion(c);
            
            k.Purple();
            Console.Write($"{e.naam}: ");
            if (e.health < (e.maxHealth / 3))
            {
                k.Red();
            }
            else
            {
                k.Green();
            }
            Console.Write($"{e.health}");
            Console.Write($"\n\n\n\n :)                                                                           :)\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("****************************************************************************************");


        }

        public void Winnaar()
        {
            if (e.health <= 0)
            {
                k.Green();
                Console.WriteLine("Champion wint!");
                k.Reset();
            }
            else
            {
                k.Red();
                Console.WriteLine("Enemy wint!");
                k.Reset();
            }
        }


    }
}
